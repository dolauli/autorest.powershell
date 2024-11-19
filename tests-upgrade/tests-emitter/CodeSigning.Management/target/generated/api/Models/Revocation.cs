// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Revocation details of the certificate.</summary>
    public partial class Revocation :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocation,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevocationInternal
    {

        /// <summary>Backing field for <see cref="EffectiveAt" /> property.</summary>
        private global::System.DateTime? _effectiveAt;

        /// <summary>The timestamp when the revocation is effective.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public global::System.DateTime? EffectiveAt { get => this._effectiveAt; set => this._effectiveAt = value; }

        /// <summary>Backing field for <see cref="FailureReason" /> property.</summary>
        private string _failureReason;

        /// <summary>Reason for the revocation failure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string FailureReason { get => this._failureReason; set => this._failureReason = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>Reason for revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Backing field for <see cref="Remark" /> property.</summary>
        private string _remark;

        /// <summary>Remarks for the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Remark { get => this._remark; set => this._remark = value; }

        /// <summary>Backing field for <see cref="RequestedAt" /> property.</summary>
        private global::System.DateTime? _requestedAt;

        /// <summary>The timestamp when the revocation is requested.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public global::System.DateTime? RequestedAt { get => this._requestedAt; set => this._requestedAt = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="Revocation" /> instance.</summary>
        public Revocation()
        {

        }
    }
    /// Revocation details of the certificate.
    public partial interface IRevocation :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable
    {
        /// <summary>The timestamp when the revocation is effective.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp when the revocation is effective.",
        SerializedName = @"effectiveAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EffectiveAt { get; set; }
        /// <summary>Reason for the revocation failure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reason for the revocation failure.",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string FailureReason { get; set; }
        /// <summary>Reason for revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reason for revocation.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        string Reason { get; set; }
        /// <summary>Remarks for the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Remarks for the revocation.",
        SerializedName = @"remarks",
        PossibleTypes = new [] { typeof(string) })]
        string Remark { get; set; }
        /// <summary>The timestamp when the revocation is requested.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp when the revocation is requested.",
        SerializedName = @"requestedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RequestedAt { get; set; }
        /// <summary>Status of the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of the revocation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "InProgress", "Failed")]
        string Status { get; set; }

    }
    /// Revocation details of the certificate.
    internal partial interface IRevocationInternal

    {
        /// <summary>The timestamp when the revocation is effective.</summary>
        global::System.DateTime? EffectiveAt { get; set; }
        /// <summary>Reason for the revocation failure.</summary>
        string FailureReason { get; set; }
        /// <summary>Reason for revocation.</summary>
        string Reason { get; set; }
        /// <summary>Remarks for the revocation.</summary>
        string Remark { get; set; }
        /// <summary>The timestamp when the revocation is requested.</summary>
        global::System.DateTime? RequestedAt { get; set; }
        /// <summary>Status of the revocation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "InProgress", "Failed")]
        string Status { get; set; }

    }
}