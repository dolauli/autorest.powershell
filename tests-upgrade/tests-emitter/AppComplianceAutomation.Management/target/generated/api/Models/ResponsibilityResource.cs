// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent the resource.</summary>
    public partial class ResponsibilityResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResource,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal
    {

        /// <summary>Backing field for <see cref="AccountId" /> property.</summary>
        private string _accountId;

        /// <summary>Account Id. For example - AWS account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string AccountId { get => this._accountId; }

        /// <summary>Internal Acessors for AccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal.AccountId { get => this._accountId; set { {_accountId = value;} } }

        /// <summary>Internal Acessors for ResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal.ResourceId { get => this._resourceId; set { {_resourceId = value;} } }

        /// <summary>Internal Acessors for ResourceOrigin</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal.ResourceOrigin { get => this._resourceOrigin; set { {_resourceOrigin = value;} } }

        /// <summary>Internal Acessors for ResourceStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal.ResourceStatus { get => this._resourceStatus; set { {_resourceStatus = value;} } }

        /// <summary>Internal Acessors for ResourceStatusChangeDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal.ResourceStatusChangeDate { get => this._resourceStatusChangeDate; set { {_resourceStatusChangeDate = value;} } }

        /// <summary>Internal Acessors for ResourceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResponsibilityResourceInternal.ResourceType { get => this._resourceType; set { {_resourceType = value;} } }

        /// <summary>Backing field for <see cref="RecommendationId" /> property.</summary>
        private System.Collections.Generic.List<string> _recommendationId;

        /// <summary>List of recommendation id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> RecommendationId { get => this._recommendationId; set => this._recommendationId = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The Id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; }

        /// <summary>Backing field for <see cref="ResourceOrigin" /> property.</summary>
        private string _resourceOrigin;

        /// <summary>Resource origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceOrigin { get => this._resourceOrigin; }

        /// <summary>Backing field for <see cref="ResourceStatus" /> property.</summary>
        private string _resourceStatus;

        /// <summary>Resource status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceStatus { get => this._resourceStatus; }

        /// <summary>Backing field for <see cref="ResourceStatusChangeDate" /> property.</summary>
        private global::System.DateTime? _resourceStatusChangeDate;

        /// <summary>The status change date for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public global::System.DateTime? ResourceStatusChangeDate { get => this._resourceStatusChangeDate; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The type of the resource. e.g. "Microsoft.SignalRService/SignalR"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; }

        /// <summary>Creates an new <see cref="ResponsibilityResource" /> instance.</summary>
        public ResponsibilityResource()
        {

        }
    }
    /// A class represent the resource.
    public partial interface IResponsibilityResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>Account Id. For example - AWS account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Account Id. For example - AWS account Id.",
        SerializedName = @"accountId",
        PossibleTypes = new [] { typeof(string) })]
        string AccountId { get;  }
        /// <summary>List of recommendation id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of recommendation id.",
        SerializedName = @"recommendationIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RecommendationId { get; set; }
        /// <summary>The Id of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Id of the resource.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get;  }
        /// <summary>Resource origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource origin.",
        SerializedName = @"resourceOrigin",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Azure", "AWS", "GCP")]
        string ResourceOrigin { get;  }
        /// <summary>Resource status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource status.",
        SerializedName = @"resourceStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Healthy", "Unhealthy")]
        string ResourceStatus { get;  }
        /// <summary>The status change date for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status change date for the resource.",
        SerializedName = @"resourceStatusChangeDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ResourceStatusChangeDate { get;  }
        /// <summary>The type of the resource. e.g. "Microsoft.SignalRService/SignalR"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of the resource. e.g. ""Microsoft.SignalRService/SignalR""",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get;  }

    }
    /// A class represent the resource.
    internal partial interface IResponsibilityResourceInternal

    {
        /// <summary>Account Id. For example - AWS account Id.</summary>
        string AccountId { get; set; }
        /// <summary>List of recommendation id.</summary>
        System.Collections.Generic.List<string> RecommendationId { get; set; }
        /// <summary>The Id of the resource.</summary>
        string ResourceId { get; set; }
        /// <summary>Resource origin.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Azure", "AWS", "GCP")]
        string ResourceOrigin { get; set; }
        /// <summary>Resource status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Healthy", "Unhealthy")]
        string ResourceStatus { get; set; }
        /// <summary>The status change date for the resource.</summary>
        global::System.DateTime? ResourceStatusChangeDate { get; set; }
        /// <summary>The type of the resource. e.g. "Microsoft.SignalRService/SignalR"</summary>
        string ResourceType { get; set; }

    }
}