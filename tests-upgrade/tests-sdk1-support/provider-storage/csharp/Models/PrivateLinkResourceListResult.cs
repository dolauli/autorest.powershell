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
    /// A list of private link resources
    /// </summary>
    public partial class PrivateLinkResourceListResult
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkResourceListResult
        /// class.
        /// </summary>
        public PrivateLinkResourceListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkResourceListResult
        /// class.
        /// </summary>
        /// <param name="value">Array of private link resources</param>
        public PrivateLinkResourceListResult(System.Collections.Generic.IList<PrivateLinkResource> value = default(System.Collections.Generic.IList<PrivateLinkResource>))
        {
            this.Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of private link resources
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<PrivateLinkResource> Value { get; set; }

    }
}