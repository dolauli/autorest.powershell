// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The VM image of the machines in the pool.</summary>
    public partial class PoolImage :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImage,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolImageInternal
    {

        /// <summary>Backing field for <see cref="Alias" /> property.</summary>
        private System.Collections.Generic.List<string> _alias;

        /// <summary>List of aliases to reference the image by.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Alias { get => this._alias; set => this._alias = value; }

        /// <summary>Backing field for <see cref="Buffer" /> property.</summary>
        private string _buffer;

        /// <summary>The percentage of the buffer to be allocated to this image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Buffer { get => this._buffer; set => this._buffer = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The resource id of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="WellKnownImageName" /> property.</summary>
        private string _wellKnownImageName;

        /// <summary>The image to use from a well-known set of images made available to customers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string WellKnownImageName { get => this._wellKnownImageName; set => this._wellKnownImageName = value; }

        /// <summary>Creates an new <see cref="PoolImage" /> instance.</summary>
        public PoolImage()
        {

        }
    }
    /// The VM image of the machines in the pool.
    public partial interface IPoolImage :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>List of aliases to reference the image by.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of aliases to reference the image by.",
        SerializedName = @"aliases",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Alias { get; set; }
        /// <summary>The percentage of the buffer to be allocated to this image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The percentage of the buffer to be allocated to this image.",
        SerializedName = @"buffer",
        PossibleTypes = new [] { typeof(string) })]
        string Buffer { get; set; }
        /// <summary>The resource id of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource id of the image.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>The image to use from a well-known set of images made available to customers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image to use from a well-known set of images made available to customers.",
        SerializedName = @"wellKnownImageName",
        PossibleTypes = new [] { typeof(string) })]
        string WellKnownImageName { get; set; }

    }
    /// The VM image of the machines in the pool.
    internal partial interface IPoolImageInternal

    {
        /// <summary>List of aliases to reference the image by.</summary>
        System.Collections.Generic.List<string> Alias { get; set; }
        /// <summary>The percentage of the buffer to be allocated to this image.</summary>
        string Buffer { get; set; }
        /// <summary>The resource id of the image.</summary>
        string ResourceId { get; set; }
        /// <summary>The image to use from a well-known set of images made available to customers.</summary>
        string WellKnownImageName { get; set; }

    }
}