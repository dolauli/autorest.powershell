// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Extensions;

    /// <summary>The check availability result.</summary>
    public partial class CheckNameAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ICheckNameAvailabilityResponse,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ICheckNameAvailabilityResponseInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Detailed reason why the given name is not available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>Indicates if the resource name is available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public bool? NameAvailable { get => this._nameAvailable; set => this._nameAvailable = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>The reason why the given name is not available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityResponse" /> instance.</summary>
        public CheckNameAvailabilityResponse()
        {

        }
    }
    /// The check availability result.
    public partial interface ICheckNameAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IJsonSerializable
    {
        /// <summary>Detailed reason why the given name is not available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Detailed reason why the given name is not available.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>Indicates if the resource name is available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if the resource name is available.",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NameAvailable { get; set; }
        /// <summary>The reason why the given name is not available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The reason why the given name is not available.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Invalid", "AlreadyExists")]
        string Reason { get; set; }

    }
    /// The check availability result.
    internal partial interface ICheckNameAvailabilityResponseInternal

    {
        /// <summary>Detailed reason why the given name is not available.</summary>
        string Message { get; set; }
        /// <summary>Indicates if the resource name is available.</summary>
        bool? NameAvailable { get; set; }
        /// <summary>The reason why the given name is not available.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Invalid", "AlreadyExists")]
        string Reason { get; set; }

    }
}