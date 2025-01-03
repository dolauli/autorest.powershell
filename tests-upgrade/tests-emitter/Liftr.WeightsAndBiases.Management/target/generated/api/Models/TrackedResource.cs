// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Extensions;

    /// <summary>
    /// The resource model definition for an Azure Resource Manager tracked top level resource which has 'tags' and a 'location'
    /// </summary>
    public partial class TrackedResource :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResource,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITrackedResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.Resource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).Name; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.Tags()); set => this._tag = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="TrackedResource" /> instance.</summary>
        public TrackedResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The resource model definition for an Azure Resource Manager tracked top level resource which has 'tags' and a 'location'
    public partial interface ITrackedResource :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResource
    {
        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags Tag { get; set; }

    }
    /// The resource model definition for an Azure Resource Manager tracked top level resource which has 'tags' and a 'location'
    internal partial interface ITrackedResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IResourceInternal
    {
        /// <summary>The geo-location where the resource lives</summary>
        string Location { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.ITags Tag { get; set; }

    }
}