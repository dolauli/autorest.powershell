namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
    public partial class SystemData :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemData,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemDataInternal
    {

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private global::System.DateTime? _createdAt;

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedAt { get => this._createdAt; set => this._createdAt = value; }

        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private string _createdBy;

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string CreatedBy { get => this._createdBy; set => this._createdBy = value; }

        /// <summary>Backing field for <see cref="CreatedByType" /> property.</summary>
        private string _createdByType;

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string CreatedByType { get => this._createdByType; set => this._createdByType = value; }

        /// <summary>Backing field for <see cref="LastModifiedAt" /> property.</summary>
        private global::System.DateTime? _lastModifiedAt;

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModifiedAt { get => this._lastModifiedAt; set => this._lastModifiedAt = value; }

        /// <summary>Backing field for <see cref="LastModifiedBy" /> property.</summary>
        private string _lastModifiedBy;

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string LastModifiedBy { get => this._lastModifiedBy; set => this._lastModifiedBy = value; }

        /// <summary>Backing field for <see cref="LastModifiedByType" /> property.</summary>
        private string _lastModifiedByType;

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string LastModifiedByType { get => this._lastModifiedByType; set => this._lastModifiedByType = value; }

        /// <summary>Creates an new <see cref="SystemData" /> instance.</summary>
        public SystemData()
        {

        }
    }
    /// Metadata pertaining to creation and last modification of the resource.
    public partial interface ISystemData :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string CreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string LastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string LastModifiedByType { get; set; }

    }
    /// Metadata pertaining to creation and last modification of the resource.
    internal partial interface ISystemDataInternal

    {
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string CreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string CreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? LastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string LastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string LastModifiedByType { get; set; }

    }
}