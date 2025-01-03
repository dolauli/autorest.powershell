// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.PowerShell;

    /// <summary>A StandbyVirtualMachinePoolResource.</summary>
    [System.ComponentModel.TypeConverter(typeof(StandbyVirtualMachinePoolResourceTypeConverter))]
    public partial class StandbyVirtualMachinePoolResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StandbyVirtualMachinePoolResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StandbyVirtualMachinePoolResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StandbyVirtualMachinePoolResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="StandbyVirtualMachinePoolResource" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StandbyVirtualMachinePoolResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ElasticityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfile = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile) content.GetValueForProperty("ElasticityProfile",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfile, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolElasticityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).VirtualMachineState = (string) content.GetValueForProperty("VirtualMachineState",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).VirtualMachineState, global::System.Convert.ToString);
            }
            if (content.Contains("AttachedVirtualMachineScaleSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).AttachedVirtualMachineScaleSetId = (string) content.GetValueForProperty("AttachedVirtualMachineScaleSetId",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).AttachedVirtualMachineScaleSetId, global::System.Convert.ToString);
            }
            if (content.Contains("ElasticityProfileMaxReadyCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfileMaxReadyCapacity = (long) content.GetValueForProperty("ElasticityProfileMaxReadyCapacity",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfileMaxReadyCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ElasticityProfileMinReadyCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfileMinReadyCapacity = (long?) content.GetValueForProperty("ElasticityProfileMinReadyCapacity",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfileMinReadyCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StandbyVirtualMachinePoolResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("RetryAfter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).RetryAfter = (int?) content.GetValueForProperty("RetryAfter",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).RetryAfter, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ElasticityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfile = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile) content.GetValueForProperty("ElasticityProfile",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfile, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolElasticityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualMachineState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).VirtualMachineState = (string) content.GetValueForProperty("VirtualMachineState",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).VirtualMachineState, global::System.Convert.ToString);
            }
            if (content.Contains("AttachedVirtualMachineScaleSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).AttachedVirtualMachineScaleSetId = (string) content.GetValueForProperty("AttachedVirtualMachineScaleSetId",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).AttachedVirtualMachineScaleSetId, global::System.Convert.ToString);
            }
            if (content.Contains("ElasticityProfileMaxReadyCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfileMaxReadyCapacity = (long) content.GetValueForProperty("ElasticityProfileMaxReadyCapacity",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfileMaxReadyCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ElasticityProfileMinReadyCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfileMinReadyCapacity = (long?) content.GetValueForProperty("ElasticityProfileMinReadyCapacity",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceInternal)this).ElasticityProfileMinReadyCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// A StandbyVirtualMachinePoolResource.
    [System.ComponentModel.TypeConverter(typeof(StandbyVirtualMachinePoolResourceTypeConverter))]
    public partial interface IStandbyVirtualMachinePoolResource

    {

    }
}