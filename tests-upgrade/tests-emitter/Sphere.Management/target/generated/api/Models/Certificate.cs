namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>An certificate resource belonging to a catalog resource.</summary>
    public partial class Certificate :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificate,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ProxyResource();

        /// <summary>The certificate expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExpiryUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).ExpiryUtc; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for ExpiryUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateInternal.ExpiryUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).ExpiryUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).ExpiryUtc = value; }

        /// <summary>Internal Acessors for NotBeforeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateInternal.NotBeforeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).NotBeforeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).NotBeforeUtc = value; }

        /// <summary>Internal Acessors for PropertiesCertificate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateInternal.PropertiesCertificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Certificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Certificate = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.CertificateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for Subject</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateInternal.Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Subject; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Subject = value; }

        /// <summary>Internal Acessors for Thumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateInternal.Thumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Thumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Thumbprint = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>The certificate not before date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public global::System.DateTime? NotBeforeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).NotBeforeUtc; }

        /// <summary>The certificate as a UTF-8 encoded base 64 string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string PropertiesCertificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Certificate; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.CertificateProperties()); set => this._property = value; }

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The certificate status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Status; }

        /// <summary>The certificate subject.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Subject; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>The certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inlined)]
        public string Thumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal)Property).Thumbprint; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="Certificate" /> instance.</summary>
        public Certificate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// An certificate resource belonging to a catalog resource.
    public partial interface ICertificate :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResource
    {
        /// <summary>The certificate expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate expiry date.",
        SerializedName = @"expiryUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExpiryUtc { get;  }
        /// <summary>The certificate not before date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate not before date.",
        SerializedName = @"notBeforeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? NotBeforeUtc { get;  }
        /// <summary>The certificate as a UTF-8 encoded base 64 string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate as a UTF-8 encoded base 64 string.",
        SerializedName = @"certificate",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesCertificate { get;  }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>The certificate status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Active", "Inactive", "Expired", "Revoked")]
        string Status { get;  }
        /// <summary>The certificate subject.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate subject.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get;  }
        /// <summary>The certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate thumbprint.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string Thumbprint { get;  }

    }
    /// An certificate resource belonging to a catalog resource.
    internal partial interface ICertificateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IProxyResourceInternal
    {
        /// <summary>The certificate expiry date.</summary>
        global::System.DateTime? ExpiryUtc { get; set; }
        /// <summary>The certificate not before date.</summary>
        global::System.DateTime? NotBeforeUtc { get; set; }
        /// <summary>The certificate as a UTF-8 encoded base 64 string.</summary>
        string PropertiesCertificate { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties Property { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>The certificate status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Active", "Inactive", "Expired", "Revoked")]
        string Status { get; set; }
        /// <summary>The certificate subject.</summary>
        string Subject { get; set; }
        /// <summary>The certificate thumbprint.</summary>
        string Thumbprint { get; set; }

    }
}