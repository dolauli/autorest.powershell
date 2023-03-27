// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using System.Linq;

    /// <summary>
    /// The retention policy for a container registry.
    /// </summary>
    public partial class RetentionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the RetentionPolicy class.
        /// </summary>
        public RetentionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RetentionPolicy class.
        /// </summary>
        /// <param name="days">The number of days to retain manifest before it
        /// expires.</param>
        /// <param name="lastUpdatedTime">The timestamp when the policy was
        /// last updated.</param>
        /// <param name="status">The value that indicates whether the policy is
        /// enabled or not. Possible values include: 'enabled',
        /// 'disabled'</param>
        public RetentionPolicy(int? days = default(int?), System.DateTime? lastUpdatedTime = default(System.DateTime?), string status = default(string))
        {
            this.Days = days;
            this.LastUpdatedTime = lastUpdatedTime;
            this.Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of days to retain manifest before it
        /// expires.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "days")]
        public int? Days { get; set; }

        /// <summary>
        /// Gets the timestamp when the policy was last updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastUpdatedTime")]
        public System.DateTime? LastUpdatedTime { get; private set; }

        /// <summary>
        /// Gets or sets the value that indicates whether the policy is enabled
        /// or not. Possible values include: 'enabled', 'disabled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}