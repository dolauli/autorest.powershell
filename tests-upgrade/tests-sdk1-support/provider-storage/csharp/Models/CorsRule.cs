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
    /// Specifies a CORS rule for the Blob service.
    /// </summary>
    public partial class CorsRule
    {
        /// <summary>
        /// Initializes a new instance of the CorsRule class.
        /// </summary>
        public CorsRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CorsRule class.
        /// </summary>
        /// <param name="allowedOrigins">Required if CorsRule element is
        /// present. A list of origin domains that will be allowed via CORS, or
        /// "*" to allow all domains</param>
        /// <param name="allowedMethods">Required if CorsRule element is
        /// present. A list of HTTP methods that are allowed to be executed by
        /// the origin.</param>
        /// <param name="maxAgeInSeconds">Required if CorsRule element is
        /// present. The number of seconds that the client/browser should cache
        /// a preflight response.</param>
        /// <param name="exposedHeaders">Required if CorsRule element is
        /// present. A list of response headers to expose to CORS
        /// clients.</param>
        /// <param name="allowedHeaders">Required if CorsRule element is
        /// present. A list of headers allowed to be part of the cross-origin
        /// request.</param>
        public CorsRule(System.Collections.Generic.IList<string> allowedOrigins, System.Collections.Generic.IList<string> allowedMethods, int maxAgeInSeconds, System.Collections.Generic.IList<string> exposedHeaders, System.Collections.Generic.IList<string> allowedHeaders)
        {
            this.AllowedOrigins = allowedOrigins;
            this.AllowedMethods = allowedMethods;
            this.MaxAgeInSeconds = maxAgeInSeconds;
            this.ExposedHeaders = exposedHeaders;
            this.AllowedHeaders = allowedHeaders;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required if CorsRule element is present. A list of
        /// origin domains that will be allowed via CORS, or "*" to allow all
        /// domains
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allowedOrigins")]
        public System.Collections.Generic.IList<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Gets or sets required if CorsRule element is present. A list of
        /// HTTP methods that are allowed to be executed by the origin.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allowedMethods")]
        public System.Collections.Generic.IList<string> AllowedMethods { get; set; }

        /// <summary>
        /// Gets or sets required if CorsRule element is present. The number of
        /// seconds that the client/browser should cache a preflight response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxAgeInSeconds")]
        public int MaxAgeInSeconds { get; set; }

        /// <summary>
        /// Gets or sets required if CorsRule element is present. A list of
        /// response headers to expose to CORS clients.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exposedHeaders")]
        public System.Collections.Generic.IList<string> ExposedHeaders { get; set; }

        /// <summary>
        /// Gets or sets required if CorsRule element is present. A list of
        /// headers allowed to be part of the cross-origin request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allowedHeaders")]
        public System.Collections.Generic.IList<string> AllowedHeaders { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.AllowedOrigins == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AllowedOrigins");
            }
            if (this.AllowedMethods == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AllowedMethods");
            }
            if (this.ExposedHeaders == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ExposedHeaders");
            }
            if (this.AllowedHeaders == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AllowedHeaders");
            }
        }
    }
}