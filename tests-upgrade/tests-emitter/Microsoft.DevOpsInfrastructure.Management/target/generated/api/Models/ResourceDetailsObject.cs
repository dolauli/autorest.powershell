// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>A ResourceDetailsObject</summary>
    public partial class ResourceDetailsObject :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObject,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ProxyResource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>The image name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string Image { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectPropertiesInternal)Property).Image; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectPropertiesInternal)Property).Image = value ?? null; }

        /// <summary>The version of the image running on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string ImageVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectPropertiesInternal)Property).ImageVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectPropertiesInternal)Property).ImageVersion = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectProperties Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceDetailsObjectProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceDetailsObjectProperties()); set => this._property = value; }

        /// <summary>The status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectPropertiesInternal)Property).Status = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="ResourceDetailsObject" /> instance.</summary>
        public ResourceDetailsObject()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// A ResourceDetailsObject
    public partial interface IResourceDetailsObject :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IProxyResource
    {
        /// <summary>The image name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image name of the resource.",
        SerializedName = @"image",
        PossibleTypes = new [] { typeof(string) })]
        string Image { get; set; }
        /// <summary>The version of the image running on the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The version of the image running on the resource.",
        SerializedName = @"imageVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ImageVersion { get; set; }
        /// <summary>The status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status of the resource.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Ready", "NotReady", "Allocated", "PendingReturn", "Returned", "Leased", "Provisioning", "Updating", "Starting", "PendingReimage", "Reimaging")]
        string Status { get; set; }

    }
    /// A ResourceDetailsObject
    internal partial interface IResourceDetailsObjectInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IProxyResourceInternal
    {
        /// <summary>The image name of the resource.</summary>
        string Image { get; set; }
        /// <summary>The version of the image running on the resource.</summary>
        string ImageVersion { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectProperties Property { get; set; }
        /// <summary>The status of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Ready", "NotReady", "Allocated", "PendingReturn", "Returned", "Leased", "Provisioning", "Updating", "Starting", "PendingReimage", "Reimaging")]
        string Status { get; set; }

    }
}