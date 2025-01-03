// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Extensions;

    /// <summary>
    /// A collection of information about the state of the connection between service consumer and provider.
    /// </summary>
    public partial class PrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionState,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkServiceConnectionStateInternal
    {

        /// <summary>Backing field for <see cref="ActionsRequired" /> property.</summary>
        private string _actionsRequired;

        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public string ActionsRequired { get => this._actionsRequired; set => this._actionsRequired = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="PrivateLinkServiceConnectionState" /> instance.</summary>
        public PrivateLinkServiceConnectionState()
        {

        }
    }
    /// A collection of information about the state of the connection between service consumer and provider.
    public partial interface IPrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A message indicating if changes on the service provider require any updates on the consumer.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string ActionsRequired { get; set; }
        /// <summary>The reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The reason for approval/rejection of the connection.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected")]
        string Status { get; set; }

    }
    /// A collection of information about the state of the connection between service consumer and provider.
    internal partial interface IPrivateLinkServiceConnectionStateInternal

    {
        /// <summary>
        /// A message indicating if changes on the service provider require any updates on the consumer.
        /// </summary>
        string ActionsRequired { get; set; }
        /// <summary>The reason for approval/rejection of the connection.</summary>
        string Description { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected")]
        string Status { get; set; }

    }
}