// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Extensions;

    /// <summary>Properties specific to Single Sign On Resource</summary>
    public partial class SingleSignOnPropertiesV2 :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.ISingleSignOnPropertiesV2,
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.ISingleSignOnPropertiesV2Internal
    {

        /// <summary>Backing field for <see cref="AadDomain" /> property.</summary>
        private System.Collections.Generic.List<string> _aadDomain;

        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AadDomain { get => this._aadDomain; set => this._aadDomain = value; }

        /// <summary>Backing field for <see cref="EnterpriseAppId" /> property.</summary>
        private string _enterpriseAppId;

        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string EnterpriseAppId { get => this._enterpriseAppId; set => this._enterpriseAppId = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>State of the Single Sign On for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of Single Sign-On mechanism being used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string Url { get => this._url; set => this._url = value; }

        /// <summary>Creates an new <see cref="SingleSignOnPropertiesV2" /> instance.</summary>
        public SingleSignOnPropertiesV2()
        {

        }
    }
    /// Properties specific to Single Sign On Resource
    public partial interface ISingleSignOnPropertiesV2 :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.IJsonSerializable
    {
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of AAD domains fetched from Microsoft Graph for user.",
        SerializedName = @"aadDomains",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AadDomain { get; set; }
        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"AAD enterprise application Id used to setup SSO",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        string EnterpriseAppId { get; set; }
        /// <summary>State of the Single Sign On for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of the Single Sign On for the resource",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string State { get; set; }
        /// <summary>Type of Single Sign-On mechanism being used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of Single Sign-On mechanism being used",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PSArgumentCompleterAttribute("Saml", "OpenId")]
        string Type { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"URL for SSO to be used by the partner to redirect the user to their system",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }

    }
    /// Properties specific to Single Sign On Resource
    internal partial interface ISingleSignOnPropertiesV2Internal

    {
        /// <summary>List of AAD domains fetched from Microsoft Graph for user.</summary>
        System.Collections.Generic.List<string> AadDomain { get; set; }
        /// <summary>AAD enterprise application Id used to setup SSO</summary>
        string EnterpriseAppId { get; set; }
        /// <summary>State of the Single Sign On for the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PSArgumentCompleterAttribute("Initial", "Enable", "Disable")]
        string State { get; set; }
        /// <summary>Type of Single Sign-On mechanism being used</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PSArgumentCompleterAttribute("Saml", "OpenId")]
        string Type { get; set; }
        /// <summary>URL for SSO to be used by the partner to redirect the user to their system</summary>
        string Url { get; set; }

    }
}