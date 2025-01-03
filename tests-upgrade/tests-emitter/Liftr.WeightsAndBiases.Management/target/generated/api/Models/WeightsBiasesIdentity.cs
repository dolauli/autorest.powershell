// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Extensions;

    public partial class WeightsBiasesIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IWeightsBiasesIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Models.IWeightsBiasesIdentityInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Instancename" /> property.</summary>
        private string _instancename;

        /// <summary>Name of the Instance resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string Instancename { get => this._instancename; set => this._instancename = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Origin(Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="WeightsBiasesIdentity" /> instance.</summary>
        public WeightsBiasesIdentity()
        {

        }
    }
    public partial interface IWeightsBiasesIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.IJsonSerializable
    {
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Name of the Instance resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the Instance resource",
        SerializedName = @"instancename",
        PossibleTypes = new [] { typeof(string) })]
        string Instancename { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WeightsBiases.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IWeightsBiasesIdentityInternal

    {
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>Name of the Instance resource</summary>
        string Instancename { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }

    }
}