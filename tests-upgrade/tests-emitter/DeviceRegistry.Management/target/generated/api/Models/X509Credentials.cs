// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>The x509 certificate for authentication mode Certificate.</summary>
    public partial class X509Credentials :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509CredentialsInternal
    {

        /// <summary>Backing field for <see cref="CertificateSecretName" /> property.</summary>
        private string _certificateSecretName;

        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string CertificateSecretName { get => this._certificateSecretName; set => this._certificateSecretName = value; }

        /// <summary>Creates an new <see cref="X509Credentials" /> instance.</summary>
        public X509Credentials()
        {

        }
    }
    /// The x509 certificate for authentication mode Certificate.
    public partial interface IX509Credentials :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).",
        SerializedName = @"certificateSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateSecretName { get; set; }

    }
    /// The x509 certificate for authentication mode Certificate.
    internal partial interface IX509CredentialsInternal

    {
        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        string CertificateSecretName { get; set; }

    }
}