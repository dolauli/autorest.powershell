// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Extensions;

    /// <summary>Partner's specific Properties</summary>
    public partial class PartnerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IPartnerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IPartnerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private string _region;

        /// <summary>The region of the instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string Region { get => this._region; set => this._region = value; }

        /// <summary>Backing field for <see cref="Subdomain" /> property.</summary>
        private string _subdomain;

        /// <summary>The subdomain of the instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string Subdomain { get => this._subdomain; set => this._subdomain = value; }

        /// <summary>Creates an new <see cref="PartnerProperties" /> instance.</summary>
        public PartnerProperties()
        {

        }
    }
    /// Partner's specific Properties
    public partial interface IPartnerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IJsonSerializable
    {
        /// <summary>The region of the instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The region of the instance",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("eastus", "centralus", "westus", "westeurope", "japaneast", "koreacentral")]
        string Region { get; set; }
        /// <summary>The subdomain of the instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The subdomain of the instance",
        SerializedName = @"subdomain",
        PossibleTypes = new [] { typeof(string) })]
        string Subdomain { get; set; }

    }
    /// Partner's specific Properties
    internal partial interface IPartnerPropertiesInternal

    {
        /// <summary>The region of the instance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PSArgumentCompleterAttribute("eastus", "centralus", "westus", "westeurope", "japaneast", "koreacentral")]
        string Region { get; set; }
        /// <summary>The subdomain of the instance</summary>
        string Subdomain { get; set; }

    }
}