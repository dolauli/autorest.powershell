// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// A domain name that AKS agent nodes are reaching at.
    /// </summary>
    public partial class EndpointDependency
    {
        /// <summary>
        /// Initializes a new instance of the EndpointDependency class.
        /// </summary>
        public EndpointDependency()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EndpointDependency class.
        /// </summary>
        /// <param name="domainName">The domain name of the dependency.</param>
        /// <param name="endpointDetails">The Ports and Protocols used when
        /// connecting to domainName.</param>
        public EndpointDependency(string domainName = default(string), System.Collections.Generic.IList<EndpointDetail> endpointDetails = default(System.Collections.Generic.IList<EndpointDetail>))
        {
            this.DomainName = domainName;
            this.EndpointDetails = endpointDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the domain name of the dependency.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "domainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Gets or sets the Ports and Protocols used when connecting to
        /// domainName.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endpointDetails")]
        public System.Collections.Generic.IList<EndpointDetail> EndpointDetails { get; set; }

    }
}