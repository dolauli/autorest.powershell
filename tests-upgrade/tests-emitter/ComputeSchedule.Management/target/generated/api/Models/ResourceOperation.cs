// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>High level response from an operation on a resource</summary>
    public partial class ResourceOperation :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperation,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal
    {

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private string _errorCode;

        /// <summary>Resource level error code if it exists</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string ErrorCode { get => this._errorCode; set => this._errorCode = value; }

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private string _errorDetail;

        /// <summary>Resource level error details if they exist</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string ErrorDetail { get => this._errorDetail; set => this._errorDetail = value; }

        /// <summary>Internal Acessors for Operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal.Operation { get => (this._operation = this._operation ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationDetails()); set { {_operation = value;} } }

        /// <summary>Internal Acessors for OperationResourceOperationError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal.OperationResourceOperationError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).ResourceOperationError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).ResourceOperationError = value; }

        /// <summary>Internal Acessors for OperationRetryPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationInternal.OperationRetryPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).RetryPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).RetryPolicy = value; }

        /// <summary>Backing field for <see cref="Operation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails _operation;

        /// <summary>Details of the operation performed on a resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails Operation { get => (this._operation = this._operation ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ResourceOperationDetails()); set => this._operation = value; }

        /// <summary>Time the operation was complete if errors are null</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public global::System.DateTime? OperationCompletedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).CompletedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).CompletedAt = value ?? default(global::System.DateTime); }

        /// <summary>Deadline for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public global::System.DateTime? OperationDeadline { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).Deadline; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).Deadline = value ?? default(global::System.DateTime); }

        /// <summary>Type of deadline of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string OperationDeadlineType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).DeadlineType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).DeadlineType = value ?? null; }

        /// <summary>Operation identifier for the unique operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string OperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).OperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).OperationId = value ?? null; }

        /// <summary>Type of operation performed on the resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string OperationOpType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).OpType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).OpType = value ?? null; }

        /// <summary>Unique identifier for the resource involved in the operation, eg ArmId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string OperationResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).ResourceId = value ?? null; }

        /// <summary>Current state of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string OperationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).State = value ?? null; }

        /// <summary>Subscription id attached to the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string OperationSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).SubscriptionId = value ?? null; }

        /// <summary>Timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string OperationTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).TimeZone = value ?? null; }

        /// <summary>Timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string OperationTimezone { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).Timezone; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).Timezone = value ?? null; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>Unique identifier for the resource involved in the operation, eg ArmId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Code for the error eg 404, 500</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string ResourceOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).ResourceOperationErrorCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).ResourceOperationErrorCode = value ?? null; }

        /// <summary>Detailed message about the error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public string ResourceOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).ResourceOperationErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).ResourceOperationErrorDetail = value ?? null; }

        /// <summary>Retry count for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public int? RetryPolicyRetryCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).RetryPolicyRetryCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).RetryPolicyRetryCount = value ?? default(int); }

        /// <summary>Retry window in minutes for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Inlined)]
        public int? RetryPolicyRetryWindowInMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).RetryPolicyRetryWindowInMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetailsInternal)Operation).RetryPolicyRetryWindowInMinute = value ?? default(int); }

        /// <summary>Creates an new <see cref="ResourceOperation" /> instance.</summary>
        public ResourceOperation()
        {

        }
    }
    /// High level response from an operation on a resource
    public partial interface IResourceOperation :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>Resource level error code if it exists</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource level error code if it exists",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorCode { get; set; }
        /// <summary>Resource level error details if they exist</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource level error details if they exist",
        SerializedName = @"errorDetails",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetail { get; set; }
        /// <summary>Time the operation was complete if errors are null</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Time the operation was complete if errors are null",
        SerializedName = @"completedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? OperationCompletedAt { get; set; }
        /// <summary>Deadline for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Deadline for the operation",
        SerializedName = @"deadline",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? OperationDeadline { get; set; }
        /// <summary>Type of deadline of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of deadline of the operation",
        SerializedName = @"deadlineType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "InitiateAt", "CompleteBy")]
        string OperationDeadlineType { get; set; }
        /// <summary>Operation identifier for the unique operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Operation identifier for the unique operation",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }
        /// <summary>Type of operation performed on the resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of operation performed on the resources",
        SerializedName = @"opType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "Start", "Deallocate", "Hibernate")]
        string OperationOpType { get; set; }
        /// <summary>Unique identifier for the resource involved in the operation, eg ArmId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique identifier for the resource involved in the operation, eg ArmId",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationResourceId { get; set; }
        /// <summary>Current state of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Current state of the operation",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "PendingScheduling", "Scheduled", "PendingExecution", "Executing", "Succeeded", "Failed", "Cancelled", "Blocked")]
        string OperationState { get; set; }
        /// <summary>Subscription id attached to the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subscription id attached to the request",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationSubscriptionId { get; set; }
        /// <summary>Timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Timezone for the operation",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string OperationTimeZone { get; set; }
        /// <summary>Timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Timezone for the operation",
        SerializedName = @"timezone",
        PossibleTypes = new [] { typeof(string) })]
        string OperationTimezone { get; set; }
        /// <summary>Unique identifier for the resource involved in the operation, eg ArmId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique identifier for the resource involved in the operation, eg ArmId",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>Code for the error eg 404, 500</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Code for the error eg 404, 500",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceOperationErrorCode { get; set; }
        /// <summary>Detailed message about the error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Detailed message about the error",
        SerializedName = @"errorDetails",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceOperationErrorDetail { get; set; }
        /// <summary>Retry count for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retry count for user request",
        SerializedName = @"retryCount",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryPolicyRetryCount { get; set; }
        /// <summary>Retry window in minutes for user request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retry window in minutes for user request",
        SerializedName = @"retryWindowInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryPolicyRetryWindowInMinute { get; set; }

    }
    /// High level response from an operation on a resource
    internal partial interface IResourceOperationInternal

    {
        /// <summary>Resource level error code if it exists</summary>
        string ErrorCode { get; set; }
        /// <summary>Resource level error details if they exist</summary>
        string ErrorDetail { get; set; }
        /// <summary>Details of the operation performed on a resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationDetails Operation { get; set; }
        /// <summary>Time the operation was complete if errors are null</summary>
        global::System.DateTime? OperationCompletedAt { get; set; }
        /// <summary>Deadline for the operation</summary>
        global::System.DateTime? OperationDeadline { get; set; }
        /// <summary>Type of deadline of the operation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "InitiateAt", "CompleteBy")]
        string OperationDeadlineType { get; set; }
        /// <summary>Operation identifier for the unique operation</summary>
        string OperationId { get; set; }
        /// <summary>Type of operation performed on the resources</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "Start", "Deallocate", "Hibernate")]
        string OperationOpType { get; set; }
        /// <summary>Unique identifier for the resource involved in the operation, eg ArmId</summary>
        string OperationResourceId { get; set; }
        /// <summary>Operation level errors if they exist</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourceOperationError OperationResourceOperationError { get; set; }
        /// <summary>Retry policy the user can pass</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IRetryPolicy OperationRetryPolicy { get; set; }
        /// <summary>Current state of the operation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "PendingScheduling", "Scheduled", "PendingExecution", "Executing", "Succeeded", "Failed", "Cancelled", "Blocked")]
        string OperationState { get; set; }
        /// <summary>Subscription id attached to the request</summary>
        string OperationSubscriptionId { get; set; }
        /// <summary>Timezone for the operation</summary>
        string OperationTimeZone { get; set; }
        /// <summary>Timezone for the operation</summary>
        string OperationTimezone { get; set; }
        /// <summary>Unique identifier for the resource involved in the operation, eg ArmId</summary>
        string ResourceId { get; set; }
        /// <summary>Code for the error eg 404, 500</summary>
        string ResourceOperationErrorCode { get; set; }
        /// <summary>Detailed message about the error</summary>
        string ResourceOperationErrorDetail { get; set; }
        /// <summary>Retry count for user request</summary>
        int? RetryPolicyRetryCount { get; set; }
        /// <summary>Retry window in minutes for user request</summary>
        int? RetryPolicyRetryWindowInMinute { get; set; }

    }
}