/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Modifier } from '@azure-tools/codegen-csharp';
import { Class } from '@azure-tools/codegen-csharp';
import { Method } from '@azure-tools/codegen-csharp';

import { items } from '@azure-tools/linq';
import { dotnet } from '@azure-tools/codegen-csharp';
import { Namespace } from '@azure-tools/codegen-csharp';
import { Parameter } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { State } from '../generator';
import { DeepPartial } from '@azure-tools/codegen';

export class JsonSerializerClass extends Class {

  constructor(namespace: Namespace, protected state: State, objectInitializer?: DeepPartial<JsonSerializerClass>) {
    super(namespace, 'JsonSerialization');
    this.apply(objectInitializer);

    this.partial = true;
    this.isStatic = true;

    const tojson = this.addMethod(new Method('ToJson', ClientRuntime.JsonNode, { static: Modifier.Static }));
    const objP = tojson.addParameter(new Parameter('obj', dotnet.ThisObject));
    const container = tojson.addParameter(new Parameter('container', ClientRuntime.JsonObject, { defaultInitializer: dotnet.Null }));
    tojson.add('return null;');

    const schemas = state.model.schemas;

    // iterate thru all the models
    // each model should have a class and an interface.
    // if the class has a discriminator value, tell the parent model that it has children
    for (const { key: index, value: schema } of items(schemas)) {
      const state = this.state.path('components', 'schemas', index);
      if (schema.details.csharp && schema.details.csharp.classImplementation) {
        // must be a class.
        // const implData: CSharpSchemaDetails = schema.details.csharp;
      }

      schema.details;
      const x = state.project.modelsNamespace.resolveTypeDeclaration(schema, true, state);
    }
  }
}
