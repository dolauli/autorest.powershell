// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.PowerShell;

    /// <summary>Properties specific to Organization</summary>
    [System.ComponentModel.TypeConverter(typeof(OrganizationPropertiesTypeConverter))]
    public partial class OrganizationProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new OrganizationProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new OrganizationProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="OrganizationProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="OrganizationProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal OrganizationProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerProperties) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.PartnerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyLicensesSubscribed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).PartnerPropertyLicensesSubscribed = (int) content.GetValueForProperty("PartnerPropertyLicensesSubscribed",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).PartnerPropertyLicensesSubscribed, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OrganizationProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal OrganizationProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Marketplace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).Marketplace = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IMarketplaceDetails) content.GetValueForProperty("Marketplace",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).Marketplace, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("User"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).User = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetails) content.GetValueForProperty("User",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).User, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).PartnerProperty = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerProperties) content.GetValueForProperty("PartnerProperty",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).PartnerProperty, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.PartnerPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceOfferDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceOfferDetail = (Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOfferDetails) content.GetValueForProperty("MarketplaceOfferDetail",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceOfferDetail, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.OfferDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserEmailAddress = (string) content.GetValueForProperty("UserEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerPropertyLicensesSubscribed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).PartnerPropertyLicensesSubscribed = (int) content.GetValueForProperty("PartnerPropertyLicensesSubscribed",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).PartnerPropertyLicensesSubscribed, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("UserFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserFirstName = (string) content.GetValueForProperty("UserFirstName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserLastName = (string) content.GetValueForProperty("UserLastName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserUpn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserUpn = (string) content.GetValueForProperty("UserUpn",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserUpn, global::System.Convert.ToString);
            }
            if (content.Contains("UserPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserPhoneNumber = (string) content.GetValueForProperty("UserPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).UserPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPublisherId = (string) content.GetValueForProperty("OfferDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailOfferId = (string) content.GetValueForProperty("OfferDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanId = (string) content.GetValueForProperty("OfferDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailPlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanName = (string) content.GetValueForProperty("OfferDetailPlanName",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailPlanName, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailTermUnit = (string) content.GetValueForProperty("OfferDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("OfferDetailTermId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailTermId = (string) content.GetValueForProperty("OfferDetailTermId",((Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IOrganizationPropertiesInternal)this).OfferDetailTermId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties specific to Organization
    [System.ComponentModel.TypeConverter(typeof(OrganizationPropertiesTypeConverter))]
    public partial interface IOrganizationProperties

    {

    }
}