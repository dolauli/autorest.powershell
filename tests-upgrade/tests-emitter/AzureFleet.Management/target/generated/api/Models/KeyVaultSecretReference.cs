// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a reference to Key Vault Secret</summary>
    public partial class KeyVaultSecretReference :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReference,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReferenceInternal
    {

        /// <summary>Internal Acessors for SourceVault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReferenceInternal.SourceVault { get => (this._sourceVault = this._sourceVault ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResource()); set { {_sourceVault = value;} } }

        /// <summary>Backing field for <see cref="SecretUrl" /> property.</summary>
        private string _secretUrl;

        /// <summary>The URL referencing a secret in a Key Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string SecretUrl { get => this._secretUrl; set => this._secretUrl = value; }

        /// <summary>Backing field for <see cref="SourceVault" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource _sourceVault;

        /// <summary>The relative URL of the Key Vault containing the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource SourceVault { get => (this._sourceVault = this._sourceVault ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResource()); set => this._sourceVault = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SourceVaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResourceInternal)SourceVault).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResourceInternal)SourceVault).Id = value ?? null; }

        /// <summary>Creates an new <see cref="KeyVaultSecretReference" /> instance.</summary>
        public KeyVaultSecretReference()
        {

        }
    }
    /// Describes a reference to Key Vault Secret
    public partial interface IKeyVaultSecretReference :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The URL referencing a secret in a Key Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL referencing a secret in a Key Vault.",
        SerializedName = @"secretUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SecretUrl { get; set; }
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SourceVaultId { get; set; }

    }
    /// Describes a reference to Key Vault Secret
    internal partial interface IKeyVaultSecretReferenceInternal

    {
        /// <summary>The URL referencing a secret in a Key Vault.</summary>
        string SecretUrl { get; set; }
        /// <summary>The relative URL of the Key Vault containing the secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource SourceVault { get; set; }
        /// <summary>Resource Id</summary>
        string SourceVaultId { get; set; }

    }
}