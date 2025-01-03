// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Scoping answer.</summary>
    public partial class ScopingAnswer :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingAnswer,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingAnswerInternal
    {

        /// <summary>Backing field for <see cref="Answer" /> property.</summary>
        private System.Collections.Generic.List<string> _answer;

        /// <summary>Question answer value list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Answer { get => this._answer; set => this._answer = value; }

        /// <summary>Backing field for <see cref="QuestionId" /> property.</summary>
        private string _questionId;

        /// <summary>Question id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string QuestionId { get => this._questionId; set => this._questionId = value; }

        /// <summary>Creates an new <see cref="ScopingAnswer" /> instance.</summary>
        public ScopingAnswer()
        {

        }
    }
    /// Scoping answer.
    public partial interface IScopingAnswer :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>Question answer value list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Question answer value list.",
        SerializedName = @"answers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Answer { get; set; }
        /// <summary>Question id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Question id.",
        SerializedName = @"questionId",
        PossibleTypes = new [] { typeof(string) })]
        string QuestionId { get; set; }

    }
    /// Scoping answer.
    internal partial interface IScopingAnswerInternal

    {
        /// <summary>Question answer value list.</summary>
        System.Collections.Generic.List<string> Answer { get; set; }
        /// <summary>Question id.</summary>
        string QuestionId { get; set; }

    }
}