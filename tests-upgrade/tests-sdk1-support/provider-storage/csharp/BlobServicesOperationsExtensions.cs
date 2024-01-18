// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for BlobServicesOperations.
    /// </summary>
    public static partial class BlobServicesOperationsExtensions
    {
            /// <summary>
            /// List blob services of storage account. It returns a collection of one
            /// object named default.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            public static System.Collections.Generic.IEnumerable<BlobServiceProperties> List(this IBlobServicesOperations operations, string resourceGroupName, string accountName)
            {
                return ((IBlobServicesOperations)operations).ListAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List blob services of storage account. It returns a collection of one
            /// object named default.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<BlobServiceProperties>> ListAsync(this IBlobServicesOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets the properties of a storage account’s Blob service, including
            /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
            /// rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The properties of a storage account’s Blob service, including properties
            /// for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules.
            /// </param>
            public static BlobServiceProperties SetServiceProperties(this IBlobServicesOperations operations, string resourceGroupName, string accountName, BlobServiceProperties parameters)
            {
                return ((IBlobServicesOperations)operations).SetServicePropertiesAsync(resourceGroupName, accountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the properties of a storage account’s Blob service, including
            /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
            /// rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='parameters'>
            /// The properties of a storage account’s Blob service, including properties
            /// for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<BlobServiceProperties> SetServicePropertiesAsync(this IBlobServicesOperations operations, string resourceGroupName, string accountName, BlobServiceProperties parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.SetServicePropertiesWithHttpMessagesAsync(resourceGroupName, accountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the properties of a storage account’s Blob service, including
            /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
            /// rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            public static BlobServiceProperties GetServiceProperties(this IBlobServicesOperations operations, string resourceGroupName, string accountName)
            {
                return ((IBlobServicesOperations)operations).GetServicePropertiesAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of a storage account’s Blob service, including
            /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
            /// rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<BlobServiceProperties> GetServicePropertiesAsync(this IBlobServicesOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetServicePropertiesWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}