/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Host, Channel } from '@azure-tools/autorest-extension-base';
import { codemodel, processCodeModel, allVirtualParameters, allVirtualProperties, resolveParameterNames, resolvePropertyNames, ModelState, ParameterLocation, isMediaTypeMultipartFormData, VirtualParameter } from '@azure-tools/codemodel-v3';
import { deconstruct, removeProhibitedPrefix, removeSequentialDuplicates, pascalCase } from '@azure-tools/codegen';
import { items, values, keys, Dictionary, length } from '@azure-tools/linq';
import * as linq from '@azure-tools/linq';
import { singularize } from '../internal/name-inferrer';

type State = ModelState<codemodel.Model>;

function getCmdletName(verb: string, subjectPrefix: string, subject: string): string {
  return `${verb}-${subjectPrefix}${subject}`;
}

export function getDeduplicatedNoun(subjectPrefix: string, subject: string): { subjectPrefix: string; subject: string } {
  // dedup parts
  const dedupedPrefix = [...removeSequentialDuplicates(deconstruct(subjectPrefix))];
  const dedupedSubject = [...removeSequentialDuplicates(deconstruct(subject))];

  // dedup the noun
  const dedupedMerge = [...removeSequentialDuplicates([...dedupedPrefix, ...dedupedSubject])];

  // figure out what belongs to the subject
  const reversedFinalSubject = new Array<string>();
  for (let mCount = length(dedupedMerge) - 1, sCount = length(dedupedSubject) - 1; sCount >= 0 && mCount >= 0; mCount-- , sCount--) {
    if (dedupedMerge[mCount] !== dedupedSubject[sCount]) {
      break;
    }

    reversedFinalSubject.push(<string>dedupedMerge.pop());
  }

  // what's left belongs to the prefix
  const finalPrefix = new Array<string>();
  for (const each of dedupedMerge) {
    finalPrefix.push(each);
  }

  return { subjectPrefix: pascalCase(finalPrefix), subject: pascalCase(reversedFinalSubject.reverse()) };
}

async function tweakModel(state: State): Promise<codemodel.Model> {
  // get the value 
  const isAzure = await state.getValue('azure', false);
  const shouldSanitize = await state.getValue('sanitize-names', isAzure);

  // make sure recursively that every details field has csharp
  for (const { index, instance } of linq.visitor(state.model)) {
    if (index === 'details' && instance.default && !instance.csharp) {
      instance.csharp = linq.clone(instance.default, false, undefined, undefined, ['schema', 'origin']);
    }
  }

  if (shouldSanitize) {
    for (const operation of values(state.model.commands.operations)) {
      // clean the noun (i.e. subjectPrefix + subject)
      const prevSubjectPrefix = operation.details.csharp.subjectPrefix;
      const prevSubject = operation.details.csharp.subject;
      const dedupedNounParts = getDeduplicatedNoun(operation.details.csharp.subjectPrefix, operation.details.csharp.subject);
      if (prevSubjectPrefix !== dedupedNounParts.subjectPrefix || prevSubject !== dedupedNounParts.subject) {
        const verb = operation.details.csharp.verb;
        const variantName = operation.details.csharp.name;
        const prevCmdletName = getCmdletName(verb, prevSubjectPrefix, prevSubject);
        operation.details.csharp.subjectPrefix = dedupedNounParts.subjectPrefix;
        operation.details.csharp.subject = dedupedNounParts.subject;
        const newCmdletName = getCmdletName(verb, operation.details.csharp.subjectPrefix, operation.details.csharp.subject);
        state.message(
          {
            Channel: Channel.Debug,
            Text: `Sanitized cmdlet-name -> Changed cmdlet-name from ${prevCmdletName} to ${newCmdletName}: {subjectPrefix: ${operation.details.csharp.subjectPrefix}, subject: ${operation.details.csharp.subject}${variantName ? `, variant: ${variantName}}` : '}'}`
          }
        );
      }

      const virtualParameters = [...allVirtualParameters(operation.details.csharp.virtualParameters)];
      for (const parameter of virtualParameters) {
        let prevName = parameter.name;
        const otherParametersNames = values(virtualParameters)
          .select(each => each.name)
          .where(name => name !== parameter.name)
          .toArray();

        // first try to singularize the parameter
        const singularName = singularize(parameter.name);
        if (prevName != singularName) {
          parameter.name = singularName;
          state.message({ Channel: Channel.Debug, Text: `Sanitized parameter-name -> Changed parameter-name from ${prevName} to singular ${parameter.name} from command ${operation.verb}-${operation.details.csharp.subjectPrefix}${operation.details.csharp.subject}` });
        }

        // save the name again to compare in case it was modified
        prevName = parameter.name;

        // now remove the subject from the beginning of the parameter
        // to reduce naming redundancy, but just for path parameters
        // e.g. get-vm -vmname ---> get-vm -name
        if ((<any>parameter.origin).in === ParameterLocation.Path) {
          const sanitizedName = removeProhibitedPrefix(
            parameter.name,
            operation.details.csharp.subject,
            otherParametersNames
          );

          if (prevName !== sanitizedName) {
            if (parameter.alias === undefined) {
              parameter.alias = [];
            }

            // saved the prev name as alias
            parameter.alias.push(parameter.name);

            // change name
            parameter.name = sanitizedName;
            state.message({ Channel: Channel.Debug, Text: `Sanitized parameter-name -> Changed parameter-name from ${prevName} to ${parameter.name} from command ${operation.verb}-${operation.details.csharp.subjectPrefix}${operation.details.csharp.subject}` });
            state.message({ Channel: Channel.Debug, Text: `                         -> And, added alias '${prevName}'` });
          }
        }
      }
    }

    for (const schema of values(state.model.schemas)) {
      const virtualProperties = [...allVirtualProperties(schema.details.csharp.virtualProperties)];

      for (const property of virtualProperties) {
        let prevName = property.name;
        const otherPropertiesNames = values(virtualProperties)
          .select(each => each.name)
          .where(name => name !== property.name)
          .toArray();

        // first try to singularize the property
        const singularName = singularize(property.name);
        if (prevName != singularName) {
          property.name = singularName;
          state.message({ Channel: Channel.Debug, Text: `Sanitized property-name -> Changed property-name from ${prevName} to singular ${property.name} from model ${schema.details.csharp.name}` });
        }

        // save the name again to compare in case it was modified
        prevName = property.name;

        // now remove the model=name from the beginning of the property-name
        // to reduce naming redundancy
        const sanitizedName = removeProhibitedPrefix(
          property.name,
          schema.details.csharp.name,
          otherPropertiesNames
        );

        if (prevName !== sanitizedName) {
          property.alias = property.alias || [];

          // saved the prev name as alias
          property.alias.push(property.name);

          // change name
          property.name = sanitizedName;
          state.message({ Channel: Channel.Debug, Text: `Sanitized property-name -> Changed property-name from ${prevName} to ${property.name} from model ${schema.details.csharp.name}` });
          state.message({ Channel: Channel.Debug, Text: `                        -> And, added alias '${prevName}'` });

          // update shared properties too
          if (property.sharedWith) {
            for (const sharedProperty of property.sharedWith) {
              if (sharedProperty.name !== sanitizedName) {
                state.message({ Channel: Channel.Debug, Text: `Changing shared property ${sharedProperty.name} to ${sanitizedName}` });
                sharedProperty.alias = sharedProperty.alias || [];
                sharedProperty.alias.push(sharedProperty.name);
                sharedProperty.name = sanitizedName;
              }
            }
          }
        }
      }
    }
  }

  // do collision detection work.
  for (const command of values(state.model.commands.operations)) {
    const vp = command.details.csharp.virtualParameters;
    if (vp) {
      resolveParameterNames([], vp);
    }
  }

  for (const schema of values(state.model.schemas)) {
    const vp = schema.details.csharp.virtualProperties;
    if (vp) {
      resolvePropertyNames([schema.details.csharp.name], vp);
    }
  }
  return state.model;
}


export async function namer(service: Host) {
  return processCodeModel(tweakModel, service, 'psnamer');
}