// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>A class represent a AppComplianceAutomation snapshot resource.</summary>
    public partial class SnapshotResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotResource,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ProxyResource();

        /// <summary>List of compliance results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult> ComplianceResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ComplianceResult; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).CreatedAt; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>Internal Acessors for ComplianceResult</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult> Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotResourceInternal.ComplianceResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ComplianceResult; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ComplianceResult = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotResourceInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).CreatedAt = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotProperties Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.SnapshotProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ReportProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportProperties Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotResourceInternal.ReportProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportProperty = value; }

        /// <summary>Internal Acessors for ReportSystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotResourceInternal.ReportSystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemData = value; }

        /// <summary>Internal Acessors for SnapshotName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotResourceInternal.SnapshotName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).SnapshotName; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).SnapshotName = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotProperties _property;

        /// <summary>Snapshot's property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.SnapshotProperties()); set => this._property = value; }

        /// <summary>Azure lifecycle management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The report essential info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportProperties ReportProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportProperty; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public global::System.DateTime? ReportSystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string ReportSystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string ReportSystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public global::System.DateTime? ReportSystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string ReportSystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string ReportSystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).ReportSystemDataLastModifiedByType = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Snapshot name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public string SnapshotName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotPropertiesInternal)Property).SnapshotName; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="SnapshotResource" /> instance.</summary>
        public SnapshotResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// A class represent a AppComplianceAutomation snapshot resource.
    public partial interface ISnapshotResource :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProxyResource
    {
        /// <summary>List of compliance results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of compliance results.",
        SerializedName = @"complianceResults",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult> ComplianceResult { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }
        /// <summary>Azure lifecycle management</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure lifecycle management",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting", "Fixing", "Verifying", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>The report essential info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The report essential info.",
        SerializedName = @"reportProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportProperties ReportProperty { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ReportSystemDataCreatedAt { get;  }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string ReportSystemDataCreatedBy { get;  }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string ReportSystemDataCreatedByType { get;  }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ReportSystemDataLastModifiedAt { get;  }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string ReportSystemDataLastModifiedBy { get;  }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string ReportSystemDataLastModifiedByType { get;  }
        /// <summary>Snapshot name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Snapshot name.",
        SerializedName = @"snapshotName",
        PossibleTypes = new [] { typeof(string) })]
        string SnapshotName { get;  }

    }
    /// A class represent a AppComplianceAutomation snapshot resource.
    internal partial interface ISnapshotResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IProxyResourceInternal
    {
        /// <summary>List of compliance results.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceResult> ComplianceResult { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>Snapshot's property.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISnapshotProperties Property { get; set; }
        /// <summary>Azure lifecycle management</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Deleting", "Fixing", "Verifying", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>The report essential info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportProperties ReportProperty { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ISystemData ReportSystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? ReportSystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string ReportSystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string ReportSystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? ReportSystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string ReportSystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string ReportSystemDataLastModifiedByType { get; set; }
        /// <summary>Snapshot name.</summary>
        string SnapshotName { get; set; }

    }
}