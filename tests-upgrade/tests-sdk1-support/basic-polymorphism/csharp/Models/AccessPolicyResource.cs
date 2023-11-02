// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample.Models
{
    using System.Linq;

    /// <summary>
    /// An access policy is used to grant users and applications access to the
    /// environment. Roles are assigned to service principals in Azure Active
    /// Directory. These roles define the actions the principal can perform
    /// through the Time Series Insights data plane APIs.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class AccessPolicyResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AccessPolicyResource class.
        /// </summary>
        public AccessPolicyResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessPolicyResource class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="principalObjectId">The objectId of the principal in
        /// Azure Active Directory.</param>
        /// <param name="description">An description of the access
        /// policy.</param>
        /// <param name="roles">The list of roles the principal is assigned on
        /// the environment.</param>
        public AccessPolicyResource(string id = default(string), string name = default(string), string type = default(string), string principalObjectId = default(string), string description = default(string), System.Collections.Generic.IList<AccessPolicyRole?> roles = default(System.Collections.Generic.IList<AccessPolicyRole?>))
            : base(id, name, type)
        {
            this.PrincipalObjectId = principalObjectId;
            this.Description = description;
            this.Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the objectId of the principal in Azure Active
        /// Directory.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.principalObjectId")]
        public string PrincipalObjectId { get; set; }

        /// <summary>
        /// Gets or sets an description of the access policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the list of roles the principal is assigned on the
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.roles")]
        public System.Collections.Generic.IList<AccessPolicyRole?> Roles { get; set; }

    }
}