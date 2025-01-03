// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>This is the response from a cancel operations request</summary>
    public partial class CancelOperationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ICancelOperationsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ICancelOperationsResponseInternal
    {

        /// <summary>Backing field for <see cref="Result" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation> _result;

        /// <summary>An array of resource operations that were successfully cancelled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation> Result { get => this._result; set => this._result = value; }

        /// <summary>Creates an new <see cref="CancelOperationsResponse" /> instance.</summary>
        public CancelOperationsResponse()
        {

        }
    }
    /// This is the response from a cancel operations request
    public partial interface ICancelOperationsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>An array of resource operations that were successfully cancelled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An array of resource operations that were successfully cancelled",
        SerializedName = @"results",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation> Result { get; set; }

    }
    /// This is the response from a cancel operations request
    internal partial interface ICancelOperationsResponseInternal

    {
        /// <summary>An array of resource operations that were successfully cancelled</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation> Result { get; set; }

    }
}