// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.PowerShell;

    /// <summary>Properties specific to the Qumulo File System resource</summary>
    [System.ComponentModel.TypeConverter(typeof(FileSystemResourcePropertiesTypeConverter))]
    public partial class FileSystemResourceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FileSystemResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FileSystemResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FileSystemResourceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StorageSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).StorageSku = (string) content.GetValueForProperty("StorageSku",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).StorageSku, global::System.Convert.ToString);
            }
            if (content.Contains("DelegatedSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).DelegatedSubnetId = (string) content.GetValueForProperty("DelegatedSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).DelegatedSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterLoginUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).ClusterLoginUrl = (string) content.GetValueForProperty("ClusterLoginUrl",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).ClusterLoginUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).PrivateIP = (System.Collections.Generic.List<string>) content.GetValueForProperty("PrivateIP",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).PrivateIP, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).AdminPassword = (string) content.GetValueForProperty("AdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).AdminPassword, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).AvailabilityZone = (string) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).AvailabilityZone, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailPlanId = (string) content.GetValueForProperty("MarketplaceDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailOfferId = (string) content.GetValueForProperty("MarketplaceDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailPublisherId = (string) content.GetValueForProperty("MarketplaceDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailTermUnit = (string) content.GetValueForProperty("MarketplaceDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).UserDetailEmail = (string) content.GetValueForProperty("UserDetailEmail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).UserDetailEmail, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FileSystemResourceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StorageSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).StorageSku = (string) content.GetValueForProperty("StorageSku",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).StorageSku, global::System.Convert.ToString);
            }
            if (content.Contains("DelegatedSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).DelegatedSubnetId = (string) content.GetValueForProperty("DelegatedSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).DelegatedSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterLoginUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).ClusterLoginUrl = (string) content.GetValueForProperty("ClusterLoginUrl",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).ClusterLoginUrl, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).PrivateIP = (System.Collections.Generic.List<string>) content.GetValueForProperty("PrivateIP",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).PrivateIP, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).AdminPassword = (string) content.GetValueForProperty("AdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).AdminPassword, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).AvailabilityZone = (string) content.GetValueForProperty("AvailabilityZone",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).AvailabilityZone, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailPlanId = (string) content.GetValueForProperty("MarketplaceDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailOfferId = (string) content.GetValueForProperty("MarketplaceDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailPublisherId = (string) content.GetValueForProperty("MarketplaceDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailTermUnit = (string) content.GetValueForProperty("MarketplaceDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).UserDetailEmail = (string) content.GetValueForProperty("UserDetailEmail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourcePropertiesInternal)this).UserDetailEmail, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FileSystemResourceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FileSystemResourceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties specific to the Qumulo File System resource
    [System.ComponentModel.TypeConverter(typeof(FileSystemResourcePropertiesTypeConverter))]
    public partial interface IFileSystemResourceProperties

    {

    }
}