// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The response of a ResourceSku list operation.</summary>
    public partial class ResourceSkuListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSku> _value;

        /// <summary>The ResourceSku items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSku> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ResourceSkuListResult" /> instance.</summary>
        public ResourceSkuListResult()
        {

        }
    }
    /// The response of a ResourceSku list operation.
    public partial interface IResourceSkuListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ResourceSku items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ResourceSku items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSku) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSku> Value { get; set; }

    }
    /// The response of a ResourceSku list operation.
    internal partial interface IResourceSkuListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ResourceSku items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSku> Value { get; set; }

    }
}