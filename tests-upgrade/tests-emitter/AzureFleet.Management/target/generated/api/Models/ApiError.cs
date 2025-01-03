// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>ApiError for Fleet</summary>
    public partial class ApiError :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiError,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase> _detail;

        /// <summary>The API error details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase> Detail { get => this._detail; set => this._detail = value; }

        /// <summary>Backing field for <see cref="Innererror" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerError _innererror;

        /// <summary>The API inner error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerError Innererror { get => (this._innererror = this._innererror ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.InnerError()); set => this._innererror = value; }

        /// <summary>The internal error message or exception dump.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string InnererrorErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerErrorInternal)Innererror).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerErrorInternal)Innererror).ErrorDetail = value ?? null; }

        /// <summary>The exception type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string InnererrorExceptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerErrorInternal)Innererror).ExceptionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerErrorInternal)Innererror).ExceptionType = value ?? null; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Internal Acessors for Innererror</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerError Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorInternal.Innererror { get => (this._innererror = this._innererror ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.InnerError()); set { {_innererror = value;} } }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Target { get => this._target; set => this._target = value; }

        /// <summary>Creates an new <see cref="ApiError" /> instance.</summary>
        public ApiError()
        {

        }
    }
    /// ApiError for Fleet
    public partial interface IApiError :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>The API error details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The API error details",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase> Detail { get; set; }
        /// <summary>The internal error message or exception dump.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The internal error message or exception dump.",
        SerializedName = @"errorDetail",
        PossibleTypes = new [] { typeof(string) })]
        string InnererrorErrorDetail { get; set; }
        /// <summary>The exception type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The exception type.",
        SerializedName = @"exceptionType",
        PossibleTypes = new [] { typeof(string) })]
        string InnererrorExceptionType { get; set; }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The target of the particular error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The target of the particular error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get; set; }

    }
    /// ApiError for Fleet
    internal partial interface IApiErrorInternal

    {
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The API error details</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiErrorBase> Detail { get; set; }
        /// <summary>The API inner error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IInnerError Innererror { get; set; }
        /// <summary>The internal error message or exception dump.</summary>
        string InnererrorErrorDetail { get; set; }
        /// <summary>The exception type.</summary>
        string InnererrorExceptionType { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The target of the particular error.</summary>
        string Target { get; set; }

    }
}