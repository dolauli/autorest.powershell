// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Extensions;

    /// <summary>Represents a mongo cluster firewall rule.</summary>
    public partial class FirewallRule :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRule,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRuleInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ProxyResource();

        /// <summary>The end IP address of the mongo cluster firewall rule. Must be IPv4 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string EndIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRulePropertiesInternal)Property).EndIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRulePropertiesInternal)Property).EndIPAddress = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRuleProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRuleInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.FirewallRuleProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRuleInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRulePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRulePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRuleProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRuleProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.FirewallRuleProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the firewall rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRulePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The start IP address of the mongo cluster firewall rule. Must be IPv4 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string StartIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRulePropertiesInternal)Property).StartIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRulePropertiesInternal)Property).StartIPAddress = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="FirewallRule" /> instance.</summary>
        public FirewallRule()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Represents a mongo cluster firewall rule.
    public partial interface IFirewallRule :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IProxyResource
    {
        /// <summary>The end IP address of the mongo cluster firewall rule. Must be IPv4 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The end IP address of the mongo cluster firewall rule. Must be IPv4 format.",
        SerializedName = @"endIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string EndIPAddress { get; set; }
        /// <summary>The provisioning state of the firewall rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the firewall rule.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "InProgress", "Updating", "Dropping")]
        string ProvisioningState { get;  }
        /// <summary>The start IP address of the mongo cluster firewall rule. Must be IPv4 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The start IP address of the mongo cluster firewall rule. Must be IPv4 format.",
        SerializedName = @"startIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string StartIPAddress { get; set; }

    }
    /// Represents a mongo cluster firewall rule.
    internal partial interface IFirewallRuleInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IProxyResourceInternal
    {
        /// <summary>The end IP address of the mongo cluster firewall rule. Must be IPv4 format.</summary>
        string EndIPAddress { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IFirewallRuleProperties Property { get; set; }
        /// <summary>The provisioning state of the firewall rule.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "InProgress", "Updating", "Dropping")]
        string ProvisioningState { get; set; }
        /// <summary>The start IP address of the mongo cluster firewall rule. Must be IPv4 format.</summary>
        string StartIPAddress { get; set; }

    }
}