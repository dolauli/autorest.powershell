// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>The updatable properties of the StandbyContainerGroupPoolResource.</summary>
    public partial class StandbyContainerGroupPoolResourceUpdateProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json ? new StandbyContainerGroupPoolResourceUpdateProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject into a new instance of <see cref="StandbyContainerGroupPoolResourceUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal StandbyContainerGroupPoolResourceUpdateProperties(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_elasticityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject>("elasticityProfile"), out var __jsonElasticityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolElasticityProfile.FromJson(__jsonElasticityProfile) : _elasticityProfile;}
            {_containerGroupProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject>("containerGroupProperties"), out var __jsonContainerGroupProperties) ? Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupProperties.FromJson(__jsonContainerGroupProperties) : _containerGroupProperty;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="StandbyContainerGroupPoolResourceUpdateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="StandbyContainerGroupPoolResourceUpdateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._elasticityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) this._elasticityProfile.ToJson(null,serializationMode) : null, "elasticityProfile" ,container.Add );
            AddIf( null != this._containerGroupProperty ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) this._containerGroupProperty.ToJson(null,serializationMode) : null, "containerGroupProperties" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}