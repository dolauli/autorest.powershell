// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies the security profile settings for the managed disk. **Note:** It can
    /// only be set for Confidential VMs.
    /// </summary>
    public partial class VMDiskSecurityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfileInternal
    {

        /// <summary>Backing field for <see cref="DiskEncryptionSet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters _diskEncryptionSet;

        /// <summary>
        /// Specifies the customer managed disk encryption set resource id for the managed
        /// disk that is used for Customer Managed Key encrypted ConfidentialVM OS Disk and
        /// VMGuest blob.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters DiskEncryptionSet { get => (this._diskEncryptionSet = this._diskEncryptionSet ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParameters()); set => this._diskEncryptionSet = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string DiskEncryptionSetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParametersInternal)DiskEncryptionSet).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParametersInternal)DiskEncryptionSet).Id = value ?? null; }

        /// <summary>Internal Acessors for DiskEncryptionSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfileInternal.DiskEncryptionSet { get => (this._diskEncryptionSet = this._diskEncryptionSet ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParameters()); set { {_diskEncryptionSet = value;} } }

        /// <summary>Backing field for <see cref="SecurityEncryptionType" /> property.</summary>
        private string _securityEncryptionType;

        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to
        /// DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        /// blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        /// NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        /// **Note:** It can be set for only Confidential VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string SecurityEncryptionType { get => this._securityEncryptionType; set => this._securityEncryptionType = value; }

        /// <summary>Creates an new <see cref="VMDiskSecurityProfile" /> instance.</summary>
        public VMDiskSecurityProfile()
        {

        }
    }
    /// Specifies the security profile settings for the managed disk. **Note:** It can
    /// only be set for Confidential VMs.
    public partial interface IVMDiskSecurityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
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
        string DiskEncryptionSetId { get; set; }
        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to
        /// DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        /// blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        /// NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        /// **Note:** It can be set for only Confidential VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the EncryptionType of the managed disk. It is set to
        DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        **Note:** It can be set for only Confidential VMs.",
        SerializedName = @"securityEncryptionType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("VMGuestStateOnly", "DiskWithVMGuestState", "NonPersistedTPM")]
        string SecurityEncryptionType { get; set; }

    }
    /// Specifies the security profile settings for the managed disk. **Note:** It can
    /// only be set for Confidential VMs.
    internal partial interface IVMDiskSecurityProfileInternal

    {
        /// <summary>
        /// Specifies the customer managed disk encryption set resource id for the managed
        /// disk that is used for Customer Managed Key encrypted ConfidentialVM OS Disk and
        /// VMGuest blob.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters DiskEncryptionSet { get; set; }
        /// <summary>Resource Id</summary>
        string DiskEncryptionSetId { get; set; }
        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to
        /// DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        /// blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        /// NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        /// **Note:** It can be set for only Confidential VMs.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("VMGuestStateOnly", "DiskWithVMGuestState", "NonPersistedTPM")]
        string SecurityEncryptionType { get; set; }

    }
}