// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.PowerShell;

    /// <summary>The model for updating storageClass properties</summary>
    [System.ComponentModel.TypeConverter(typeof(StorageClassPropertiesUpdateTypeConverter))]
    public partial class StorageClassPropertiesUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StorageClassPropertiesUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StorageClassPropertiesUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StorageClassPropertiesUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="StorageClassPropertiesUpdate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StorageClassPropertiesUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TypeProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypeProperty = (Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdate) content.GetValueForProperty("TypeProperty",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypeProperty, Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypePropertiesUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("AllowVolumeExpansion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).AllowVolumeExpansion = (string) content.GetValueForProperty("AllowVolumeExpansion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).AllowVolumeExpansion, global::System.Convert.ToString);
            }
            if (content.Contains("MountOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).MountOption = (System.Collections.Generic.List<string>) content.GetValueForProperty("MountOption",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).MountOption, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AccessMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).AccessMode = (System.Collections.Generic.List<string>) content.GetValueForProperty("AccessMode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).AccessMode, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DataResilience"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).DataResilience = (string) content.GetValueForProperty("DataResilience",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).DataResilience, global::System.Convert.ToString);
            }
            if (content.Contains("FailoverSpeed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).FailoverSpeed = (string) content.GetValueForProperty("FailoverSpeed",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).FailoverSpeed, global::System.Convert.ToString);
            }
            if (content.Contains("Limitation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Limitation = (System.Collections.Generic.List<string>) content.GetValueForProperty("Limitation",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Limitation, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Performance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Performance = (string) content.GetValueForProperty("Performance",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Performance, global::System.Convert.ToString);
            }
            if (content.Contains("Priority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Priority = (long?) content.GetValueForProperty("Priority",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Priority, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TypePropertyDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyDomain = (string) content.GetValueForProperty("TypePropertyDomain",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyDomain, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyBackingStorageClassName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyBackingStorageClassName = (string) content.GetValueForProperty("TypePropertyBackingStorageClassName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyBackingStorageClassName, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyAzureStorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyAzureStorageAccountName = (string) content.GetValueForProperty("TypePropertyAzureStorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyAzureStorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyAzureStorageAccountKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyAzureStorageAccountKey = (System.Security.SecureString) content.GetValueForProperty("TypePropertyAzureStorageAccountKey",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyAzureStorageAccountKey, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("TypePropertyServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyServer = (string) content.GetValueForProperty("TypePropertyServer",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyServer, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyShare"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyShare = (string) content.GetValueForProperty("TypePropertyShare",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyShare, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertySubDir"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertySubDir = (string) content.GetValueForProperty("TypePropertySubDir",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertySubDir, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyMountPermission"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyMountPermission = (string) content.GetValueForProperty("TypePropertyMountPermission",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyMountPermission, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyOnDelete"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyOnDelete = (string) content.GetValueForProperty("TypePropertyOnDelete",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyOnDelete, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertySource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertySource = (string) content.GetValueForProperty("TypePropertySource",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertySource, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyUsername = (string) content.GetValueForProperty("TypePropertyUsername",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyUsername, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyPassword = (System.Security.SecureString) content.GetValueForProperty("TypePropertyPassword",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyPassword, (object ss) => (System.Security.SecureString)ss);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StorageClassPropertiesUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TypeProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypeProperty = (Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassTypePropertiesUpdate) content.GetValueForProperty("TypeProperty",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypeProperty, Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.StorageClassTypePropertiesUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("AllowVolumeExpansion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).AllowVolumeExpansion = (string) content.GetValueForProperty("AllowVolumeExpansion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).AllowVolumeExpansion, global::System.Convert.ToString);
            }
            if (content.Contains("MountOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).MountOption = (System.Collections.Generic.List<string>) content.GetValueForProperty("MountOption",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).MountOption, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AccessMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).AccessMode = (System.Collections.Generic.List<string>) content.GetValueForProperty("AccessMode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).AccessMode, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DataResilience"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).DataResilience = (string) content.GetValueForProperty("DataResilience",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).DataResilience, global::System.Convert.ToString);
            }
            if (content.Contains("FailoverSpeed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).FailoverSpeed = (string) content.GetValueForProperty("FailoverSpeed",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).FailoverSpeed, global::System.Convert.ToString);
            }
            if (content.Contains("Limitation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Limitation = (System.Collections.Generic.List<string>) content.GetValueForProperty("Limitation",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Limitation, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Performance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Performance = (string) content.GetValueForProperty("Performance",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Performance, global::System.Convert.ToString);
            }
            if (content.Contains("Priority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Priority = (long?) content.GetValueForProperty("Priority",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).Priority, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TypePropertyDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyDomain = (string) content.GetValueForProperty("TypePropertyDomain",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyDomain, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyBackingStorageClassName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyBackingStorageClassName = (string) content.GetValueForProperty("TypePropertyBackingStorageClassName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyBackingStorageClassName, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyAzureStorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyAzureStorageAccountName = (string) content.GetValueForProperty("TypePropertyAzureStorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyAzureStorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyAzureStorageAccountKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyAzureStorageAccountKey = (System.Security.SecureString) content.GetValueForProperty("TypePropertyAzureStorageAccountKey",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyAzureStorageAccountKey, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("TypePropertyServer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyServer = (string) content.GetValueForProperty("TypePropertyServer",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyServer, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyShare"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyShare = (string) content.GetValueForProperty("TypePropertyShare",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyShare, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertySubDir"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertySubDir = (string) content.GetValueForProperty("TypePropertySubDir",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertySubDir, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyMountPermission"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyMountPermission = (string) content.GetValueForProperty("TypePropertyMountPermission",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyMountPermission, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyOnDelete"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyOnDelete = (string) content.GetValueForProperty("TypePropertyOnDelete",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyOnDelete, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertySource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertySource = (string) content.GetValueForProperty("TypePropertySource",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertySource, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyUsername = (string) content.GetValueForProperty("TypePropertyUsername",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyUsername, global::System.Convert.ToString);
            }
            if (content.Contains("TypePropertyPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyPassword = (System.Security.SecureString) content.GetValueForProperty("TypePropertyPassword",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IStorageClassPropertiesUpdateInternal)this).TypePropertyPassword, (object ss) => (System.Security.SecureString)ss);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The model for updating storageClass properties
    [System.ComponentModel.TypeConverter(typeof(StorageClassPropertiesUpdateTypeConverter))]
    public partial interface IStorageClassPropertiesUpdate

    {

    }
}