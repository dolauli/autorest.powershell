// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>The type used for update operations of the StandbyVirtualMachinePoolResource.</summary>
    public partial class StandbyVirtualMachinePoolResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdateInternal
    {

        /// <summary>
        /// Specifies the fully qualified resource ID of a virtual machine scale set the pool is attached to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string AttachedVirtualMachineScaleSetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).AttachedVirtualMachineScaleSetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).AttachedVirtualMachineScaleSetId = value ?? null; }

        /// <summary>
        /// Specifies the maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public long? ElasticityProfileMaxReadyCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).ElasticityProfileMaxReadyCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).ElasticityProfileMaxReadyCapacity = value ?? default(long); }

        /// <summary>
        /// Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot
        /// exceed MaxReadyCapacity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public long? ElasticityProfileMinReadyCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).ElasticityProfileMinReadyCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).ElasticityProfileMinReadyCapacity = value ?? default(long); }

        /// <summary>Internal Acessors for ElasticityProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdateInternal.ElasticityProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).ElasticityProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).ElasticityProfile = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolResourceUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolResourceUpdateProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.Tags()); set => this._tag = value; }

        /// <summary>Specifies the desired state of virtual machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string VirtualMachineState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).VirtualMachineState; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal)Property).VirtualMachineState = value ?? null; }

        /// <summary>Creates an new <see cref="StandbyVirtualMachinePoolResourceUpdate" /> instance.</summary>
        public StandbyVirtualMachinePoolResourceUpdate()
        {

        }
    }
    /// The type used for update operations of the StandbyVirtualMachinePoolResource.
    public partial interface IStandbyVirtualMachinePoolResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the fully qualified resource ID of a virtual machine scale set the pool is attached to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the fully qualified resource ID of a virtual machine scale set the pool is attached to.",
        SerializedName = @"attachedVirtualMachineScaleSetId",
        PossibleTypes = new [] { typeof(string) })]
        string AttachedVirtualMachineScaleSetId { get; set; }
        /// <summary>
        /// Specifies the maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the maximum number of virtual machines in the standby virtual machine pool.",
        SerializedName = @"maxReadyCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? ElasticityProfileMaxReadyCapacity { get; set; }
        /// <summary>
        /// Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot
        /// exceed MaxReadyCapacity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot exceed MaxReadyCapacity.",
        SerializedName = @"minReadyCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? ElasticityProfileMinReadyCapacity { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags Tag { get; set; }
        /// <summary>Specifies the desired state of virtual machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the desired state of virtual machines in the pool.",
        SerializedName = @"virtualMachineState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Running", "Deallocated")]
        string VirtualMachineState { get; set; }

    }
    /// The type used for update operations of the StandbyVirtualMachinePoolResource.
    internal partial interface IStandbyVirtualMachinePoolResourceUpdateInternal

    {
        /// <summary>
        /// Specifies the fully qualified resource ID of a virtual machine scale set the pool is attached to.
        /// </summary>
        string AttachedVirtualMachineScaleSetId { get; set; }
        /// <summary>Specifies the elasticity profile of the standby virtual machine pools.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile ElasticityProfile { get; set; }
        /// <summary>
        /// Specifies the maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        long? ElasticityProfileMaxReadyCapacity { get; set; }
        /// <summary>
        /// Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot
        /// exceed MaxReadyCapacity.
        /// </summary>
        long? ElasticityProfileMinReadyCapacity { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdateProperties Property { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags Tag { get; set; }
        /// <summary>Specifies the desired state of virtual machines in the pool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Running", "Deallocated")]
        string VirtualMachineState { get; set; }

    }
}