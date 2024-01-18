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
    /// Describes the credential parameters for accessing the source registry.
    /// </summary>
    public partial class SourceRegistryCredentials
    {
        /// <summary>
        /// Initializes a new instance of the SourceRegistryCredentials class.
        /// </summary>
        public SourceRegistryCredentials()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceRegistryCredentials class.
        /// </summary>
        /// <param name="loginMode">The authentication mode which determines
        /// the source registry login scope. The credentials for the source
        /// registry
        /// will be generated using the given scope. These credentials will be
        /// used to login to
        /// the source registry during the run. Possible values include:
        /// 'None', 'Default'</param>
        public SourceRegistryCredentials(string loginMode = default(string))
        {
            this.LoginMode = loginMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the authentication mode which determines the source
        /// registry login scope. The credentials for the source registry
        /// will be generated using the given scope. These credentials will be
        /// used to login to
        /// the source registry during the run. Possible values include:
        /// 'None', 'Default'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "loginMode")]
        public string LoginMode { get; set; }

    }
}