// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// The storage account.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class StorageAccount : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">Gets the SKU.</param>
        /// <param name="kind">Gets the Kind. Possible values include:
        /// 'Storage', 'StorageV2', 'BlobStorage', 'FileStorage',
        /// 'BlockBlobStorage'</param>
        /// <param name="identity">The identity of the resource.</param>
        /// <param name="extendedLocation">The extendedLocation of the
        /// resource.</param>
        /// <param name="provisioningState">Gets the status of the storage
        /// account at the time the operation was called. Possible values
        /// include: 'Creating', 'ResolvingDNS', 'Succeeded'</param>
        /// <param name="primaryEndpoints">Gets the URLs that are used to
        /// perform a retrieval of a public blob, queue, or table object. Note
        /// that Standard_ZRS and Premium_LRS accounts only return the blob
        /// endpoint.</param>
        /// <param name="primaryLocation">Gets the location of the primary data
        /// center for the storage account.</param>
        /// <param name="statusOfPrimary">Gets the status indicating whether
        /// the primary location of the storage account is available or
        /// unavailable. Possible values include: 'available',
        /// 'unavailable'</param>
        /// <param name="lastGeoFailoverTime">Gets the timestamp of the most
        /// recent instance of a failover to the secondary location. Only the
        /// most recent timestamp is retained. This element is not returned if
        /// there has never been a failover instance. Only available if the
        /// accountType is Standard_GRS or Standard_RAGRS.</param>
        /// <param name="secondaryLocation">Gets the location of the
        /// geo-replicated secondary for the storage account. Only available if
        /// the accountType is Standard_GRS or Standard_RAGRS.</param>
        /// <param name="statusOfSecondary">Gets the status indicating whether
        /// the secondary location of the storage account is available or
        /// unavailable. Only available if the SKU name is Standard_GRS or
        /// Standard_RAGRS. Possible values include: 'available',
        /// 'unavailable'</param>
        /// <param name="creationTime">Gets the creation date and time of the
        /// storage account in UTC.</param>
        /// <param name="customDomain">Gets the custom domain the user assigned
        /// to this storage account.</param>
        /// <param name="sasPolicy">SasPolicy assigned to the storage
        /// account.</param>
        /// <param name="keyPolicy">KeyPolicy assigned to the storage
        /// account.</param>
        /// <param name="keyCreationTime">Storage account keys creation
        /// time.</param>
        /// <param name="secondaryEndpoints">Gets the URLs that are used to
        /// perform a retrieval of a public blob, queue, or table object from
        /// the secondary location of the storage account. Only available if
        /// the SKU name is Standard_RAGRS.</param>
        /// <param name="encryption">Encryption settings to be used for
        /// server-side encryption for the storage account.</param>
        /// <param name="accessTier">Required for storage accounts where kind =
        /// BlobStorage. The access tier is used for billing. The 'Premium'
        /// access tier is the default value for premium block blobs storage
        /// account type and it cannot be changed for the premium block blobs
        /// storage account type. Possible values include: 'Hot', 'Cool',
        /// 'Premium'</param>
        /// <param name="azureFilesIdentityBasedAuthentication">Provides the
        /// identity based authentication settings for Azure Files.</param>
        /// <param name="enableHttpsTrafficOnly">Allows https traffic only to
        /// storage service if sets to true.</param>
        /// <param name="networkRuleSet">Network rule set</param>
        /// <param name="isSftpEnabled">Enables Secure File Transfer Protocol,
        /// if set to true</param>
        /// <param name="isLocalUserEnabled">Enables local users feature, if
        /// set to true</param>
        /// <param name="isHnsEnabled">Account HierarchicalNamespace enabled if
        /// sets to true.</param>
        /// <param name="geoReplicationStats">Geo Replication Stats</param>
        /// <param name="failoverInProgress">If the failover is in progress,
        /// the value will be true, otherwise, it will be null.</param>
        /// <param name="largeFileSharesState">Allow large file shares if sets
        /// to Enabled. It cannot be disabled once it is enabled. Possible
        /// values include: 'Disabled', 'Enabled'</param>
        /// <param name="privateEndpointConnections">List of private endpoint
        /// connection associated with the specified storage account</param>
        /// <param name="routingPreference">Maintains information about the
        /// network routing choice opted by the user for data transfer</param>
        /// <param name="blobRestoreStatus">Blob restore status</param>
        /// <param name="allowBlobPublicAccess">Allow or disallow public access
        /// to all blobs or containers in the storage account. The default
        /// interpretation is true for this property.</param>
        /// <param name="minimumTlsVersion">Set the minimum TLS version to be
        /// permitted on requests to storage. The default interpretation is TLS
        /// 1.0 for this property. Possible values include: 'TLS1_0', 'TLS1_1',
        /// 'TLS1_2'</param>
        /// <param name="allowSharedKeyAccess">Indicates whether the storage
        /// account permits requests to be authorized with the account access
        /// key via Shared Key. If false, then all requests, including shared
        /// access signatures, must be authorized with Azure Active Directory
        /// (Azure AD). The default value is null, which is equivalent to
        /// true.</param>
        /// <param name="enableNfsV3">NFS 3.0 protocol support enabled if set
        /// to true.</param>
        /// <param name="allowCrossTenantReplication">Allow or disallow cross
        /// AAD tenant object replication. The default interpretation is true
        /// for this property.</param>
        /// <param name="defaultToOAuthAuthentication">A boolean flag which
        /// indicates whether the default authentication is OAuth or not. The
        /// default interpretation is false for this property.</param>
        /// <param name="publicNetworkAccess">Allow or disallow public network
        /// access to Storage Account. Value is optional but if passed in, must
        /// be 'Enabled' or 'Disabled'. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="immutableStorageWithVersioning">The property is
        /// immutable and can only be set to true at the account creation time.
        /// When set to true, it enables object level immutability for all the
        /// containers in the account by default.</param>
        /// <param name="allowedCopyScope">Restrict copy to and from Storage
        /// Accounts within an AAD tenant or with Private Links to the same
        /// VNet. Possible values include: 'PrivateLink', 'AAD'</param>
        /// <param name="storageAccountSkuConversionStatus">This property is
        /// readOnly and is set by server during asynchronous storage account
        /// sku conversion operations.</param>
        /// <param name="dnsEndpointType">Allows you to specify the type of
        /// endpoint. Set this to AzureDNSZone to create a large number of
        /// accounts in a single subscription, which creates accounts in an
        /// Azure DNS Zone and the endpoint URL will have an alphanumeric DNS
        /// Zone identifier. Possible values include: 'Standard',
        /// 'AzureDnsZone'</param>
        public StorageAccount(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), Sku sku = default(Sku), string kind = default(string), Identity identity = default(Identity), ExtendedLocation extendedLocation = default(ExtendedLocation), ProvisioningState? provisioningState = default(ProvisioningState?), Endpoints primaryEndpoints = default(Endpoints), string primaryLocation = default(string), AccountStatus? statusOfPrimary = default(AccountStatus?), System.DateTime? lastGeoFailoverTime = default(System.DateTime?), string secondaryLocation = default(string), AccountStatus? statusOfSecondary = default(AccountStatus?), System.DateTime? creationTime = default(System.DateTime?), CustomDomain customDomain = default(CustomDomain), SasPolicy sasPolicy = default(SasPolicy), KeyPolicy keyPolicy = default(KeyPolicy), KeyCreationTime keyCreationTime = default(KeyCreationTime), Endpoints secondaryEndpoints = default(Endpoints), Encryption encryption = default(Encryption), AccessTier? accessTier = default(AccessTier?), AzureFilesIdentityBasedAuthentication azureFilesIdentityBasedAuthentication = default(AzureFilesIdentityBasedAuthentication), bool? enableHttpsTrafficOnly = default(bool?), NetworkRuleSet networkRuleSet = default(NetworkRuleSet), bool? isSftpEnabled = default(bool?), bool? isLocalUserEnabled = default(bool?), bool? isHnsEnabled = default(bool?), GeoReplicationStats geoReplicationStats = default(GeoReplicationStats), bool? failoverInProgress = default(bool?), string largeFileSharesState = default(string), System.Collections.Generic.IList<PrivateEndpointConnection> privateEndpointConnections = default(System.Collections.Generic.IList<PrivateEndpointConnection>), RoutingPreference routingPreference = default(RoutingPreference), BlobRestoreStatus blobRestoreStatus = default(BlobRestoreStatus), bool? allowBlobPublicAccess = default(bool?), string minimumTlsVersion = default(string), bool? allowSharedKeyAccess = default(bool?), bool? enableNfsV3 = default(bool?), bool? allowCrossTenantReplication = default(bool?), bool? defaultToOAuthAuthentication = default(bool?), string publicNetworkAccess = default(string), ImmutableStorageAccount immutableStorageWithVersioning = default(ImmutableStorageAccount), string allowedCopyScope = default(string), StorageAccountSkuConversionStatus storageAccountSkuConversionStatus = default(StorageAccountSkuConversionStatus), string dnsEndpointType = default(string))
            : base(location, id, name, type, tags)
        {
            this.Sku = sku;
            this.Kind = kind;
            this.Identity = identity;
            this.ExtendedLocation = extendedLocation;
            this.ProvisioningState = provisioningState;
            this.PrimaryEndpoints = primaryEndpoints;
            this.PrimaryLocation = primaryLocation;
            this.StatusOfPrimary = statusOfPrimary;
            this.LastGeoFailoverTime = lastGeoFailoverTime;
            this.SecondaryLocation = secondaryLocation;
            this.StatusOfSecondary = statusOfSecondary;
            this.CreationTime = creationTime;
            this.CustomDomain = customDomain;
            this.SasPolicy = sasPolicy;
            this.KeyPolicy = keyPolicy;
            this.KeyCreationTime = keyCreationTime;
            this.SecondaryEndpoints = secondaryEndpoints;
            this.Encryption = encryption;
            this.AccessTier = accessTier;
            this.AzureFilesIdentityBasedAuthentication = azureFilesIdentityBasedAuthentication;
            this.EnableHttpsTrafficOnly = enableHttpsTrafficOnly;
            this.NetworkRuleSet = networkRuleSet;
            this.IsSftpEnabled = isSftpEnabled;
            this.IsLocalUserEnabled = isLocalUserEnabled;
            this.IsHnsEnabled = isHnsEnabled;
            this.GeoReplicationStats = geoReplicationStats;
            this.FailoverInProgress = failoverInProgress;
            this.LargeFileSharesState = largeFileSharesState;
            this.PrivateEndpointConnections = privateEndpointConnections;
            this.RoutingPreference = routingPreference;
            this.BlobRestoreStatus = blobRestoreStatus;
            this.AllowBlobPublicAccess = allowBlobPublicAccess;
            this.MinimumTlsVersion = minimumTlsVersion;
            this.AllowSharedKeyAccess = allowSharedKeyAccess;
            this.EnableNfsV3 = enableNfsV3;
            this.AllowCrossTenantReplication = allowCrossTenantReplication;
            this.DefaultToOAuthAuthentication = defaultToOAuthAuthentication;
            this.PublicNetworkAccess = publicNetworkAccess;
            this.ImmutableStorageWithVersioning = immutableStorageWithVersioning;
            this.AllowedCopyScope = allowedCopyScope;
            this.StorageAccountSkuConversionStatus = storageAccountSkuConversionStatus;
            this.DnsEndpointType = dnsEndpointType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; private set; }

        /// <summary>
        /// Gets the Kind. Possible values include: 'Storage', 'StorageV2',
        /// 'BlobStorage', 'FileStorage', 'BlockBlobStorage'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets or sets the extendedLocation of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Gets the status of the storage account at the time the operation
        /// was called. Possible values include: 'Creating', 'ResolvingDNS',
        /// 'Succeeded'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public
        /// blob, queue, or table object. Note that Standard_ZRS and
        /// Premium_LRS accounts only return the blob endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.primaryEndpoints")]
        public Endpoints PrimaryEndpoints { get; private set; }

        /// <summary>
        /// Gets the location of the primary data center for the storage
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.primaryLocation")]
        public string PrimaryLocation { get; private set; }

        /// <summary>
        /// Gets the status indicating whether the primary location of the
        /// storage account is available or unavailable. Possible values
        /// include: 'available', 'unavailable'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.statusOfPrimary")]
        public AccountStatus? StatusOfPrimary { get; private set; }

        /// <summary>
        /// Gets the timestamp of the most recent instance of a failover to the
        /// secondary location. Only the most recent timestamp is retained.
        /// This element is not returned if there has never been a failover
        /// instance. Only available if the accountType is Standard_GRS or
        /// Standard_RAGRS.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lastGeoFailoverTime")]
        public System.DateTime? LastGeoFailoverTime { get; private set; }

        /// <summary>
        /// Gets the location of the geo-replicated secondary for the storage
        /// account. Only available if the accountType is Standard_GRS or
        /// Standard_RAGRS.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.secondaryLocation")]
        public string SecondaryLocation { get; private set; }

        /// <summary>
        /// Gets the status indicating whether the secondary location of the
        /// storage account is available or unavailable. Only available if the
        /// SKU name is Standard_GRS or Standard_RAGRS. Possible values
        /// include: 'available', 'unavailable'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.statusOfSecondary")]
        public AccountStatus? StatusOfSecondary { get; private set; }

        /// <summary>
        /// Gets the creation date and time of the storage account in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the custom domain the user assigned to this storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; private set; }

        /// <summary>
        /// Gets sasPolicy assigned to the storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sasPolicy")]
        public SasPolicy SasPolicy { get; private set; }

        /// <summary>
        /// Gets keyPolicy assigned to the storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.keyPolicy")]
        public KeyPolicy KeyPolicy { get; private set; }

        /// <summary>
        /// Gets storage account keys creation time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.keyCreationTime")]
        public KeyCreationTime KeyCreationTime { get; private set; }

        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public
        /// blob, queue, or table object from the secondary location of the
        /// storage account. Only available if the SKU name is Standard_RAGRS.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.secondaryEndpoints")]
        public Endpoints SecondaryEndpoints { get; private set; }

        /// <summary>
        /// Gets encryption settings to be used for server-side encryption for
        /// the storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; private set; }

        /// <summary>
        /// Gets required for storage accounts where kind = BlobStorage. The
        /// access tier is used for billing. The 'Premium' access tier is the
        /// default value for premium block blobs storage account type and it
        /// cannot be changed for the premium block blobs storage account type.
        /// Possible values include: 'Hot', 'Cool', 'Premium'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.accessTier")]
        public AccessTier? AccessTier { get; private set; }

        /// <summary>
        /// Gets or sets provides the identity based authentication settings
        /// for Azure Files.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.azureFilesIdentityBasedAuthentication")]
        public AzureFilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthentication { get; set; }

        /// <summary>
        /// Gets or sets allows https traffic only to storage service if sets
        /// to true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.supportsHttpsTrafficOnly")]
        public bool? EnableHttpsTrafficOnly { get; set; }

        /// <summary>
        /// Gets network rule set
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.networkAcls")]
        public NetworkRuleSet NetworkRuleSet { get; private set; }

        /// <summary>
        /// Gets or sets enables Secure File Transfer Protocol, if set to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isSftpEnabled")]
        public bool? IsSftpEnabled { get; set; }

        /// <summary>
        /// Gets or sets enables local users feature, if set to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isLocalUserEnabled")]
        public bool? IsLocalUserEnabled { get; set; }

        /// <summary>
        /// Gets or sets account HierarchicalNamespace enabled if sets to true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isHnsEnabled")]
        public bool? IsHnsEnabled { get; set; }

        /// <summary>
        /// Gets geo Replication Stats
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.geoReplicationStats")]
        public GeoReplicationStats GeoReplicationStats { get; private set; }

        /// <summary>
        /// Gets if the failover is in progress, the value will be true,
        /// otherwise, it will be null.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.failoverInProgress")]
        public bool? FailoverInProgress { get; private set; }

        /// <summary>
        /// Gets or sets allow large file shares if sets to Enabled. It cannot
        /// be disabled once it is enabled. Possible values include:
        /// 'Disabled', 'Enabled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.largeFileSharesState")]
        public string LargeFileSharesState { get; set; }

        /// <summary>
        /// Gets list of private endpoint connection associated with the
        /// specified storage account
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public System.Collections.Generic.IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets or sets maintains information about the network routing choice
        /// opted by the user for data transfer
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.routingPreference")]
        public RoutingPreference RoutingPreference { get; set; }

        /// <summary>
        /// Gets blob restore status
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.blobRestoreStatus")]
        public BlobRestoreStatus BlobRestoreStatus { get; private set; }

        /// <summary>
        /// Gets or sets allow or disallow public access to all blobs or
        /// containers in the storage account. The default interpretation is
        /// true for this property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.allowBlobPublicAccess")]
        public bool? AllowBlobPublicAccess { get; set; }

        /// <summary>
        /// Gets or sets set the minimum TLS version to be permitted on
        /// requests to storage. The default interpretation is TLS 1.0 for this
        /// property. Possible values include: 'TLS1_0', 'TLS1_1', 'TLS1_2'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.minimumTlsVersion")]
        public string MinimumTlsVersion { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the storage account permits requests
        /// to be authorized with the account access key via Shared Key. If
        /// false, then all requests, including shared access signatures, must
        /// be authorized with Azure Active Directory (Azure AD). The default
        /// value is null, which is equivalent to true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.allowSharedKeyAccess")]
        public bool? AllowSharedKeyAccess { get; set; }

        /// <summary>
        /// Gets or sets NFS 3.0 protocol support enabled if set to true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isNfsV3Enabled")]
        public bool? EnableNfsV3 { get; set; }

        /// <summary>
        /// Gets or sets allow or disallow cross AAD tenant object replication.
        /// The default interpretation is true for this property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.allowCrossTenantReplication")]
        public bool? AllowCrossTenantReplication { get; set; }

        /// <summary>
        /// Gets or sets a boolean flag which indicates whether the default
        /// authentication is OAuth or not. The default interpretation is false
        /// for this property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.defaultToOAuthAuthentication")]
        public bool? DefaultToOAuthAuthentication { get; set; }

        /// <summary>
        /// Gets or sets allow or disallow public network access to Storage
        /// Account. Value is optional but if passed in, must be 'Enabled' or
        /// 'Disabled'. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets the property is immutable and can only be set to true
        /// at the account creation time. When set to true, it enables object
        /// level immutability for all the containers in the account by
        /// default.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.immutableStorageWithVersioning")]
        public ImmutableStorageAccount ImmutableStorageWithVersioning { get; set; }

        /// <summary>
        /// Gets or sets restrict copy to and from Storage Accounts within an
        /// AAD tenant or with Private Links to the same VNet. Possible values
        /// include: 'PrivateLink', 'AAD'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.allowedCopyScope")]
        public string AllowedCopyScope { get; set; }

        /// <summary>
        /// Gets or sets this property is readOnly and is set by server during
        /// asynchronous storage account sku conversion operations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccountSkuConversionStatus")]
        public StorageAccountSkuConversionStatus StorageAccountSkuConversionStatus { get; set; }

        /// <summary>
        /// Gets or sets allows you to specify the type of endpoint. Set this
        /// to AzureDNSZone to create a large number of accounts in a single
        /// subscription, which creates accounts in an Azure DNS Zone and the
        /// endpoint URL will have an alphanumeric DNS Zone identifier.
        /// Possible values include: 'Standard', 'AzureDnsZone'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dnsEndpointType")]
        public string DnsEndpointType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
            if (this.Identity != null)
            {
                this.Identity.Validate();
            }
            if (this.CustomDomain != null)
            {
                this.CustomDomain.Validate();
            }
            if (this.SasPolicy != null)
            {
                this.SasPolicy.Validate();
            }
            if (this.KeyPolicy != null)
            {
                this.KeyPolicy.Validate();
            }
            if (this.AzureFilesIdentityBasedAuthentication != null)
            {
                this.AzureFilesIdentityBasedAuthentication.Validate();
            }
            if (this.NetworkRuleSet != null)
            {
                this.NetworkRuleSet.Validate();
            }
            if (this.PrivateEndpointConnections != null)
            {
                foreach (var element in this.PrivateEndpointConnections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.BlobRestoreStatus != null)
            {
                this.BlobRestoreStatus.Validate();
            }
            if (this.ImmutableStorageWithVersioning != null)
            {
                this.ImmutableStorageWithVersioning.Validate();
            }
        }
    }
}