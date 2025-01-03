// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>
    /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
    /// configuration
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetPublicIPAddressConfigurationTypeConverter))]
    public partial class VirtualMachineScaleSetPublicIPAddressConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineScaleSetPublicIPAddressConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfiguration"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineScaleSetPublicIPAddressConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfiguration" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="VirtualMachineScaleSetPublicIPAddressConfiguration" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineScaleSetPublicIPAddressConfiguration(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfigurationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPublicIPAddressSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.PublicIPAddressSkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("IPTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).IPTag = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag>) content.GetValueForProperty("IPTag",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).IPTag, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetIPTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("DnsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings) content.GetValueForProperty("DnsSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PublicIPPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPPrefix = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource) content.GetValueForProperty("PublicIPPrefix",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPPrefix, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdleTimeoutInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).IdleTimeoutInMinute = (int?) content.GetValueForProperty("IdleTimeoutInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).IdleTimeoutInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PublicIPAddressVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPAddressVersion = (string) content.GetValueForProperty("PublicIPAddressVersion",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPAddressVersion, global::System.Convert.ToString);
            }
            if (content.Contains("DeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DeleteOption = (string) content.GetValueForProperty("DeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DeleteOption, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPPrefixId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPPrefixId = (string) content.GetValueForProperty("PublicIPPrefixId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPPrefixId, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).SkuTier, global::System.Convert.ToString);
            }
            if (content.Contains("DnsSettingDomainNameLabel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSettingDomainNameLabel = (string) content.GetValueForProperty("DnsSettingDomainNameLabel",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSettingDomainNameLabel, global::System.Convert.ToString);
            }
            if (content.Contains("DnsSettingDomainNameLabelScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSettingDomainNameLabelScope = (string) content.GetValueForProperty("DnsSettingDomainNameLabelScope",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSettingDomainNameLabelScope, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineScaleSetPublicIPAddressConfiguration(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfigurationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPublicIPAddressSku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.PublicIPAddressSkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("IPTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).IPTag = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag>) content.GetValueForProperty("IPTag",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).IPTag, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetIPTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("DnsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings) content.GetValueForProperty("DnsSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PublicIPPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPPrefix = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource) content.GetValueForProperty("PublicIPPrefix",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPPrefix, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdleTimeoutInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).IdleTimeoutInMinute = (int?) content.GetValueForProperty("IdleTimeoutInMinute",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).IdleTimeoutInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PublicIPAddressVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPAddressVersion = (string) content.GetValueForProperty("PublicIPAddressVersion",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPAddressVersion, global::System.Convert.ToString);
            }
            if (content.Contains("DeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DeleteOption = (string) content.GetValueForProperty("DeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DeleteOption, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPPrefixId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPPrefixId = (string) content.GetValueForProperty("PublicIPPrefixId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).PublicIPPrefixId, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).SkuTier, global::System.Convert.ToString);
            }
            if (content.Contains("DnsSettingDomainNameLabel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSettingDomainNameLabel = (string) content.GetValueForProperty("DnsSettingDomainNameLabel",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSettingDomainNameLabel, global::System.Convert.ToString);
            }
            if (content.Contains("DnsSettingDomainNameLabelScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSettingDomainNameLabelScope = (string) content.GetValueForProperty("DnsSettingDomainNameLabelScope",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)this).DnsSettingDomainNameLabelScope, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
    /// configuration
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetPublicIPAddressConfigurationTypeConverter))]
    public partial interface IVirtualMachineScaleSetPublicIPAddressConfiguration

    {

    }
}