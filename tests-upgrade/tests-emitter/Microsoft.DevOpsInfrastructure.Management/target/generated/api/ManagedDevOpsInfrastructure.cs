// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>
    /// Low-level API implementation for the Managed DevOps Infrastructure service.
    /// </summary>
    public partial class ManagedDevOpsInfrastructure
    {

        /// <summary>List ImageVersion resources by Image</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ImageVersionsListByImage(string subscriptionId, string resourceGroupName, string imageName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/images/"
                        + global::System.Uri.EscapeDataString(imageName)
                        + "/versions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ImageVersionsListByImage_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List ImageVersion resources by Image</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ImageVersionsListByImageViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/images/(?<imageName>[^/]+)/versions$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/images/{imageName}/versions'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var imageName = _match.Groups["imageName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/images/"
                        + imageName
                        + "/versions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ImageVersionsListByImage_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List ImageVersion resources by Image</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionListResult> ImageVersionsListByImageViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/images/(?<imageName>[^/]+)/versions$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/images/{imageName}/versions'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var imageName = _match.Groups["imageName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/images/"
                        + imageName
                        + "/versions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.ImageVersionsListByImageWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List ImageVersion resources by Image</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionListResult> ImageVersionsListByImageWithResult(string subscriptionId, string resourceGroupName, string imageName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/images/"
                        + global::System.Uri.EscapeDataString(imageName)
                        + "/versions"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.ImageVersionsListByImageWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "ImageVersionsListByImageWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionListResult> ImageVersionsListByImageWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ImageVersionListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "ImageVersionsListByImage" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ImageVersionsListByImage_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ImageVersionListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="ImageVersionsListByImage" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="imageName">Name of the image.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ImageVersionsListByImage_Validate(string subscriptionId, string resourceGroupName, string imageName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(imageName),imageName);
                await eventListener.AssertRegEx(nameof(imageName), imageName, @"^[a-zA-Z0-9][a-zA-Z0-9-.]*$");
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OperationsList(global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.DevOpsInfrastructure/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task OperationsListViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.DevOpsInfrastructure/operations$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.DevOpsInfrastructure/operations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.DevOpsInfrastructure/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsList_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOperationListResult> OperationsListViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/providers/Microsoft.DevOpsInfrastructure/operations$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/providers/Microsoft.DevOpsInfrastructure/operations'");
                }

                // replace URI parameters with values from identity
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.DevOpsInfrastructure/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.OperationsListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List the operations for the provider</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOperationListResult> OperationsListWithResult(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/providers/Microsoft.DevOpsInfrastructure/operations"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.OperationsListWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "OperationsListWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOperationListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOperationListResult> OperationsListWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OperationListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "OperationsList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OperationsList_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOperationListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.OperationListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="OperationsList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task OperationsList_Validate(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {

            }
        }

        /// <summary>update a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsCreateOrUpdate(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsCreateOrUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a Pool</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsCreateOrUpdateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools/(?<poolName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var poolName = _match.Groups["poolName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + poolName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsCreateOrUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a Pool</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsCreateOrUpdateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool body, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools/(?<poolName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var poolName = _match.Groups["poolName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + poolName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsCreateOrUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="jsonString">Json string supplied to the PoolsCreateOrUpdate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsCreateOrUpdateViaJsonString(string subscriptionId, string resourceGroupName, string poolName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsCreateOrUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>update a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="jsonString">Json string supplied to the PoolsCreateOrUpdate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsCreateOrUpdateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string poolName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsCreateOrUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>update a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsCreateOrUpdateWithResult(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool body, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsCreateOrUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsCreateOrUpdateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsCreateOrUpdateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Pool.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsCreateOrUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsCreateOrUpdate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    // declared final-state-via: azure-async-operation
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Pool.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="PoolsCreateOrUpdate" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="body">Resource create parameters.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsCreateOrUpdate_Validate(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool body, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(poolName),poolName);
                await eventListener.AssertRegEx(nameof(poolName), poolName, @"^[a-zA-Z0-9][a-zA-Z0-9-.]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>Delete a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsDelete(string subscriptionId, string resourceGroupName, string poolName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Delete a Pool</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsDeleteViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools/(?<poolName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var poolName = _match.Groups["poolName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + poolName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsDelete_Call (request, onNoContent,onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsDelete_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onNoContent, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response);
                            break;
                        }
                        case global::System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="PoolsDelete" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsDelete_Validate(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(poolName),poolName);
                await eventListener.AssertRegEx(nameof(poolName), poolName, @"^[a-zA-Z0-9][a-zA-Z0-9-.]*$");
            }
        }

        /// <summary>Get a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsGet(string subscriptionId, string resourceGroupName, string poolName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Get a Pool</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsGetViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools/(?<poolName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var poolName = _match.Groups["poolName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + poolName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsGet_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Get a Pool</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsGetViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools/(?<poolName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var poolName = _match.Groups["poolName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + poolName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Get a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsGetWithResult(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsGetWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsGetWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsGetWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Pool.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsGet_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Pool.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="PoolsGet" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsGet_Validate(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(poolName),poolName);
                await eventListener.AssertRegEx(nameof(poolName), poolName, @"^[a-zA-Z0-9][a-zA-Z0-9-.]*$");
            }
        }

        /// <summary>List Pool resources by resource group</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsListByResourceGroup(string subscriptionId, string resourceGroupName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List Pool resources by resource group</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsListByResourceGroupViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsListByResourceGroup_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List Pool resources by resource group</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult> PoolsListByResourceGroupViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List Pool resources by resource group</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult> PoolsListByResourceGroupWithResult(string subscriptionId, string resourceGroupName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsListByResourceGroupWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsListByResourceGroupWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult> PoolsListByResourceGroupWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsListByResourceGroup" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsListByResourceGroup_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="PoolsListByResourceGroup" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsListByResourceGroup_Validate(string subscriptionId, string resourceGroupName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
            }
        }

        /// <summary>List Pool resources by subscription ID</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsListBySubscription(string subscriptionId, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List Pool resources by subscription ID</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsListBySubscriptionViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/pools'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.DevOpsInfrastructure/pools"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsListBySubscription_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List Pool resources by subscription ID</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult> PoolsListBySubscriptionViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/pools'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.DevOpsInfrastructure/pools"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List Pool resources by subscription ID</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult> PoolsListBySubscriptionWithResult(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsListBySubscriptionWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsListBySubscriptionWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult> PoolsListBySubscriptionWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsListBySubscription" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsListBySubscription_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="PoolsListBySubscription" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsListBySubscription_Validate(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            }
        }

        /// <summary>Update a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsUpdate(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Update a Pool</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsUpdateViaIdentity(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate body, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools/(?<poolName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var poolName = _match.Groups["poolName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + poolName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Update a Pool</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsUpdateViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate body, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools/(?<poolName>[^/]+)$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var poolName = _match.Groups["poolName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + poolName
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Update a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="jsonString">Json string supplied to the PoolsUpdate operation</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task PoolsUpdateViaJsonString(string subscriptionId, string resourceGroupName, string poolName, global::System.String jsonString, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.PoolsUpdate_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>Update a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="jsonString">Json string supplied to the PoolsUpdate operation</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsUpdateViaJsonStringWithResult(string subscriptionId, string resourceGroupName, string poolName, global::System.String jsonString, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(jsonString, global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Update a Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsUpdateWithResult(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate body, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode serializationMode = Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeUpdate)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // set body content
                request.Content = new global::System.Net.Http.StringContent(null != body ? body.ToJson(null, serializationMode).ToString() : @"{}", global::System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BodyContentSet); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.PoolsUpdateWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsUpdateWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool> PoolsUpdateWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Pool.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers));
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "PoolsUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsUpdate_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 0); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    // declared final-state-via: location
                    var _finalUri = _response.GetFirstHeader(@"Location");
                    var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                    var location = _response.GetFirstHeader(@"Location");
                    var operationLocation = _response.GetFirstHeader(@"Operation-Location");
                    while (request.Method == System.Net.Http.HttpMethod.Put && _response.StatusCode == global::System.Net.HttpStatusCode.OK || _response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                    {
                        // delay before making the next polling request
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.DelayBeforePolling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // while we wait, let's grab the headers and get ready to poll.
                        if (!System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Azure-AsyncOperation"))) {
                            asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Location"))) {
                            location = _response.GetFirstHeader(@"Location");
                        }
                        if (!global::System.String.IsNullOrEmpty(_response.GetFirstHeader(@"Operation-Location"))) {
                            operationLocation = _response.GetFirstHeader(@"Operation-Location");
                        }
                        var _uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? global::System.String.IsNullOrEmpty(operationLocation) ? _originalUri : operationLocation : location : asyncOperation;
                        request = request.CloneAndDispose(new global::System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = await _response.Content.ReadAsStringAsync();

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                          // if we got back an OK, take a peek inside and see if it's done
                          if( _response.StatusCode == global::System.Net.HttpStatusCode.OK)
                          {
                              var error = false;
                              try {
                                  if( Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonObject json)
                                  {
                                      var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("provisioningState") ?? json.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonString>("status");
                                      if( state is null )
                                      {
                                          // the body doesn't contain any information that has the state of the LRO
                                          // we're going to just get out, and let the consumer have the result
                                          break;
                                      }

                                      switch( state?.ToString()?.ToLower() )
                                      {
                                        case "failed":
                                            error = true;
                                            break;
                                        case "succeeded":
                                        case "canceled":
                                          // we're done polling.
                                          break;

                                        default:
                                          // need to keep polling!
                                          _response.StatusCode = global::System.Net.HttpStatusCode.Created;
                                          continue;
                                      }
                                  }
                              } catch {
                                  // if we run into a problem peeking into the result,
                                  // we really don't want to do anything special.
                              }
                              if (error) {
                                  throw new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.UndeclaredResponseException(_response);
                              }
                          }

                        // check for terminal status code
                        if (_response.StatusCode == global::System.Net.HttpStatusCode.Created || _response.StatusCode == global::System.Net.HttpStatusCode.Accepted )
                        {
                            continue;
                        }
                        // we are done polling, do a request on final target?
                        // create a new request with the final uri
                        request = request.CloneAndDispose(new global::System.Uri(_finalUri), Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get);

                        // drop the old response
                        _response?.Dispose();

                        // make the final call
                        _response = await sender.SendAsync(request,  eventListener);
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Polling, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                        break;
                    }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Pool.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) .ReadHeaders(_response.Headers)));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="PoolsUpdate" /> method. Call this like the actual call, but you will get validation events
        /// back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="body">The resource properties to be updated.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task PoolsUpdate_Validate(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate body, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(poolName),poolName);
                await eventListener.AssertRegEx(nameof(poolName), poolName, @"^[a-zA-Z0-9][a-zA-Z0-9-.]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }

        /// <summary>List ResourceDetailsObject resources by Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ResourceDetailsListByPool(string subscriptionId, string resourceGroupName, string poolName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "/resources"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ResourceDetailsListByPool_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List ResourceDetailsObject resources by Pool</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task ResourceDetailsListByPoolViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools/(?<poolName>[^/]+)/resources$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}/resources'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var poolName = _match.Groups["poolName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + poolName
                        + "/resources"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ResourceDetailsListByPool_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List ResourceDetailsObject resources by Pool</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult> ResourceDetailsListByPoolViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/Microsoft.DevOpsInfrastructure/pools/(?<poolName>[^/]+)/resources$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}/resources'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var resourceGroupName = _match.Groups["resourceGroupName"].Value;
                var poolName = _match.Groups["poolName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/resourceGroups/"
                        + resourceGroupName
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + poolName
                        + "/resources"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.ResourceDetailsListByPoolWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List ResourceDetailsObject resources by Pool</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult> ResourceDetailsListByPoolWithResult(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + global::System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.DevOpsInfrastructure/pools/"
                        + global::System.Uri.EscapeDataString(poolName)
                        + "/resources"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.ResourceDetailsListByPoolWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>
        /// Actual wire call for <see cref= "ResourceDetailsListByPoolWithResult" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult> ResourceDetailsListByPoolWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceDetailsObjectListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "ResourceDetailsListByPool" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ResourceDetailsListByPool_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceDetailsObjectListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="ResourceDetailsListByPool" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="resourceGroupName">The name of the resource group. The name is case insensitive.</param>
        /// <param name="poolName">Name of the pool. It needs to be globally unique.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task ResourceDetailsListByPool_Validate(string subscriptionId, string resourceGroupName, string poolName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertMinimumLength(nameof(resourceGroupName),resourceGroupName,1);
                await eventListener.AssertMaximumLength(nameof(resourceGroupName),resourceGroupName,90);
                await eventListener.AssertRegEx(nameof(resourceGroupName), resourceGroupName, @"^[-\w\._\(\)]+$");
                await eventListener.AssertNotNull(nameof(poolName),poolName);
                await eventListener.AssertRegEx(nameof(poolName), poolName, @"^[a-zA-Z0-9][a-zA-Z0-9-.]*$");
            }
        }

        /// <summary>List ResourceSku resources by subscription ID</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="locationName">Name of the location.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SkuListByLocation(string subscriptionId, string locationName, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.DevOpsInfrastructure/locations/"
                        + global::System.Uri.EscapeDataString(locationName)
                        + "/skus"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SkuListByLocation_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List ResourceSku resources by subscription ID</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SkuListByLocationViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.DevOpsInfrastructure/locations/(?<locationName>[^/]+)/skus$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/locations/{locationName}/skus'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var locationName = _match.Groups["locationName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.DevOpsInfrastructure/locations/"
                        + locationName
                        + "/skus"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SkuListByLocation_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List ResourceSku resources by subscription ID</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult> SkuListByLocationViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.DevOpsInfrastructure/locations/(?<locationName>[^/]+)/skus$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/locations/{locationName}/skus'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var locationName = _match.Groups["locationName"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.DevOpsInfrastructure/locations/"
                        + locationName
                        + "/skus"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SkuListByLocationWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List ResourceSku resources by subscription ID</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="locationName">Name of the location.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult> SkuListByLocationWithResult(string subscriptionId, string locationName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.DevOpsInfrastructure/locations/"
                        + global::System.Uri.EscapeDataString(locationName)
                        + "/skus"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SkuListByLocationWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "SkuListByLocationWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult> SkuListByLocationWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceSkuListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "SkuListByLocation" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SkuListByLocation_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuListResult>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceSkuListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SkuListByLocation" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="locationName">Name of the location.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SkuListByLocation_Validate(string subscriptionId, string locationName, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(locationName),locationName);
                await eventListener.AssertRegEx(nameof(locationName), locationName, @"^[a-zA-Z0-9][a-zA-Z0-9-.]*$");
            }
        }

        /// <summary>List Quota resources by subscription ID</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="location">The name of the Azure region.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SubscriptionUsages(string subscriptionId, string location, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPagedQuota>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.DevOpsInfrastructure/locations/"
                        + global::System.Uri.EscapeDataString(location)
                        + "/usages"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SubscriptionUsages_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List Quota resources by subscription ID</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task SubscriptionUsagesViaIdentity(global::System.String viaIdentity, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPagedQuota>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.DevOpsInfrastructure/locations/(?<location>[^/]+)/usages$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/locations/{location}/usages'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var location = _match.Groups["location"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.DevOpsInfrastructure/locations/"
                        + location
                        + "/usages"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.SubscriptionUsages_Call (request, onOk,onDefault,eventListener,sender);
            }
        }

        /// <summary>List Quota resources by subscription ID</summary>
        /// <param name="viaIdentity"></param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPagedQuota>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPagedQuota> SubscriptionUsagesViaIdentityWithResult(global::System.String viaIdentity, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // verify that Identity format is an exact match for uri

                var _match = new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/providers/Microsoft.DevOpsInfrastructure/locations/(?<location>[^/]+)/usages$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(viaIdentity);
                if (!_match.Success)
                {
                    throw new global::System.Exception("Invalid identity for URI '/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/locations/{location}/usages'");
                }

                // replace URI parameters with values from identity
                var subscriptionId = _match.Groups["subscriptionId"].Value;
                var location = _match.Groups["location"].Value;
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + subscriptionId
                        + "/providers/Microsoft.DevOpsInfrastructure/locations/"
                        + location
                        + "/usages"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SubscriptionUsagesWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>List Quota resources by subscription ID</summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="location">The name of the Azure region.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPagedQuota>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPagedQuota> SubscriptionUsagesWithResult(string subscriptionId, string location, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            var apiVersion = @"2024-10-19";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var pathAndQuery = global::System.Text.RegularExpressions.Regex.Replace(
                        "/subscriptions/"
                        + global::System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.DevOpsInfrastructure/locations/"
                        + global::System.Uri.EscapeDataString(location)
                        + "/usages"
                        + "?"
                        + "api-version=" + global::System.Uri.EscapeDataString(apiVersion)
                        ,"\\?&*$|&*$|(\\?)&+|(&)&+","$1$2");

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.URLCreated, pathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                // generate request object
                var _url = new global::System.Uri($"https://management.azure.com{pathAndQuery}");
                var request =  new global::System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.RequestCreated, request.RequestUri.PathAndQuery); if( eventListener.Token.IsCancellationRequested ) { return null; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.HeaderParametersAdded); if( eventListener.Token.IsCancellationRequested ) { return null; }
                // make the call
                return await this.SubscriptionUsagesWithResult_Call (request, eventListener,sender);
            }
        }

        /// <summary>Actual wire call for <see cref= "SubscriptionUsagesWithResult" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPagedQuota>"
        /// /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPagedQuota> SubscriptionUsagesWithResult_Call(global::System.Net.Http.HttpRequestMessage request, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return null; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PagedQuota.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            return await _result;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return null; }
                            var _result = _response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) );
                            // Error Response : default
                            var code = (await _result)?.Code;
                            var message = (await _result)?.Message;
                            if ((null == code || null == message))
                            {
                                // Unrecognized Response. Create an error record based on what we have.
                                var ex = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>(_response, await _result);
                                throw ex;
                            }
                            else
                            {
                                throw new global::System.Exception($"[{code}] : {message}");
                            }
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>Actual wire call for <see cref= "SubscriptionUsages" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOk">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SubscriptionUsages_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPagedQuota>, global::System.Threading.Tasks.Task> onOk, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IErrorResponse>, global::System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    var sendTask = sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sendTask;
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Progress, "intentional placeholder", 100); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;

                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOk(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PagedQuota.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ErrorResponse.FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }

        /// <summary>
        /// Validation method for <see cref="SubscriptionUsages" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The ID of the target subscription. The value must be an UUID.</param>
        /// <param name="location">The name of the Azure region.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task SubscriptionUsages_Validate(string subscriptionId, string location, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(location),location);
                await eventListener.AssertMinimumLength(nameof(location),location,1);
            }
        }
    }
}