// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the control record synchronized from app compliance.</summary>
    public partial class ControlSyncRecord :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecord,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IControlSyncRecordInternal
    {

        /// <summary>Backing field for <see cref="ControlId" /> property.</summary>
        private string _controlId;

        /// <summary>The Id of the control. e.g. "Operational_Security_10"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ControlId { get => this._controlId; set => this._controlId = value; }

        /// <summary>Backing field for <see cref="ControlStatus" /> property.</summary>
        private string _controlStatus;

        /// <summary>Control status synchronized from app compliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ControlStatus { get => this._controlStatus; set => this._controlStatus = value; }

        /// <summary>Creates an new <see cref="ControlSyncRecord" /> instance.</summary>
        public ControlSyncRecord()
        {

        }
    }
    /// A class represent the control record synchronized from app compliance.
    public partial interface IControlSyncRecord :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The Id of the control. e.g. "Operational_Security_10"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Id of the control. e.g. ""Operational_Security_10""",
        SerializedName = @"controlId",
        PossibleTypes = new [] { typeof(string) })]
        string ControlId { get; set; }
        /// <summary>Control status synchronized from app compliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Control status synchronized from app compliance.",
        SerializedName = @"controlStatus",
        PossibleTypes = new [] { typeof(string) })]
        string ControlStatus { get; set; }

    }
    /// A class represent the control record synchronized from app compliance.
    internal partial interface IControlSyncRecordInternal

    {
        /// <summary>The Id of the control. e.g. "Operational_Security_10"</summary>
        string ControlId { get; set; }
        /// <summary>Control status synchronized from app compliance.</summary>
        string ControlStatus { get; set; }

    }
}