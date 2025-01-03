// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.PowerShell;

    /// <summary>
    /// Informatica runtime resource metadata as received via the informatica fetch all runtime environments API
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(InfaRuntimeResourceFetchMetaDataTypeConverter))]
    public partial class InfaRuntimeResourceFetchMetaData
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaRuntimeResourceFetchMetaData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InfaRuntimeResourceFetchMetaData(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaRuntimeResourceFetchMetaData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InfaRuntimeResourceFetchMetaData(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InfaRuntimeResourceFetchMetaData" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="InfaRuntimeResourceFetchMetaData" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaRuntimeResourceFetchMetaData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InfaRuntimeResourceFetchMetaData(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ServerlessConfigProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties) content.GetValueForProperty("ServerlessConfigProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaServerlessFetchConfigPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).CreatedTime = (string) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).CreatedTime, global::System.Convert.ToString);
            }
            if (content.Contains("UpdatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).UpdatedTime = (string) content.GetValueForProperty("UpdatedTime",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).UpdatedTime, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).CreatedBy = (string) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).CreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("UpdatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).UpdatedBy = (string) content.GetValueForProperty("UpdatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).UpdatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("StatusLocalized"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).StatusLocalized = (string) content.GetValueForProperty("StatusLocalized",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).StatusLocalized, global::System.Convert.ToString);
            }
            if (content.Contains("StatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).StatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyTenantId = (string) content.GetValueForProperty("ServerlessConfigPropertyTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertySubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySubnet = (string) content.GetValueForProperty("ServerlessConfigPropertySubnet",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySubnet, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyApplicationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyApplicationType = (string) content.GetValueForProperty("ServerlessConfigPropertyApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyApplicationType, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyResourceGroupName = (string) content.GetValueForProperty("ServerlessConfigPropertyResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyAdvancedCustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyAdvancedCustomProperty = (string) content.GetValueForProperty("ServerlessConfigPropertyAdvancedCustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyAdvancedCustomProperty, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertySupplementaryFileLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySupplementaryFileLocation = (string) content.GetValueForProperty("ServerlessConfigPropertySupplementaryFileLocation",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySupplementaryFileLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyPlatform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyPlatform = (string) content.GetValueForProperty("ServerlessConfigPropertyPlatform",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyPlatform, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyTag = (string) content.GetValueForProperty("ServerlessConfigPropertyTag",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyTag, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyVnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyVnet = (string) content.GetValueForProperty("ServerlessConfigPropertyVnet",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyVnet, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyExecutionTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyExecutionTimeout = (string) content.GetValueForProperty("ServerlessConfigPropertyExecutionTimeout",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyExecutionTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyComputeUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyComputeUnit = (string) content.GetValueForProperty("ServerlessConfigPropertyComputeUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyComputeUnit, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertySubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySubscriptionId = (string) content.GetValueForProperty("ServerlessConfigPropertySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyRegion = (string) content.GetValueForProperty("ServerlessConfigPropertyRegion",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyRegion, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyServerlessArmResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyServerlessArmResourceId = (string) content.GetValueForProperty("ServerlessConfigPropertyServerlessArmResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyServerlessArmResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaRuntimeResourceFetchMetaData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InfaRuntimeResourceFetchMetaData(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ServerlessConfigProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties) content.GetValueForProperty("ServerlessConfigProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.InfaServerlessFetchConfigPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).CreatedTime = (string) content.GetValueForProperty("CreatedTime",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).CreatedTime, global::System.Convert.ToString);
            }
            if (content.Contains("UpdatedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).UpdatedTime = (string) content.GetValueForProperty("UpdatedTime",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).UpdatedTime, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).CreatedBy = (string) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).CreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("UpdatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).UpdatedBy = (string) content.GetValueForProperty("UpdatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).UpdatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("StatusLocalized"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).StatusLocalized = (string) content.GetValueForProperty("StatusLocalized",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).StatusLocalized, global::System.Convert.ToString);
            }
            if (content.Contains("StatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).StatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyTenantId = (string) content.GetValueForProperty("ServerlessConfigPropertyTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertySubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySubnet = (string) content.GetValueForProperty("ServerlessConfigPropertySubnet",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySubnet, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyApplicationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyApplicationType = (string) content.GetValueForProperty("ServerlessConfigPropertyApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyApplicationType, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyResourceGroupName = (string) content.GetValueForProperty("ServerlessConfigPropertyResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyAdvancedCustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyAdvancedCustomProperty = (string) content.GetValueForProperty("ServerlessConfigPropertyAdvancedCustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyAdvancedCustomProperty, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertySupplementaryFileLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySupplementaryFileLocation = (string) content.GetValueForProperty("ServerlessConfigPropertySupplementaryFileLocation",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySupplementaryFileLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyPlatform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyPlatform = (string) content.GetValueForProperty("ServerlessConfigPropertyPlatform",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyPlatform, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyTag = (string) content.GetValueForProperty("ServerlessConfigPropertyTag",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyTag, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyVnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyVnet = (string) content.GetValueForProperty("ServerlessConfigPropertyVnet",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyVnet, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyExecutionTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyExecutionTimeout = (string) content.GetValueForProperty("ServerlessConfigPropertyExecutionTimeout",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyExecutionTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyComputeUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyComputeUnit = (string) content.GetValueForProperty("ServerlessConfigPropertyComputeUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyComputeUnit, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertySubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySubscriptionId = (string) content.GetValueForProperty("ServerlessConfigPropertySubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertySubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyRegion = (string) content.GetValueForProperty("ServerlessConfigPropertyRegion",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyRegion, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyServerlessArmResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyServerlessArmResourceId = (string) content.GetValueForProperty("ServerlessConfigPropertyServerlessArmResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaDataInternal)this).ServerlessConfigPropertyServerlessArmResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Informatica runtime resource metadata as received via the informatica fetch all runtime environments API
    [System.ComponentModel.TypeConverter(typeof(InfaRuntimeResourceFetchMetaDataTypeConverter))]
    public partial interface IInfaRuntimeResourceFetchMetaData

    {

    }
}