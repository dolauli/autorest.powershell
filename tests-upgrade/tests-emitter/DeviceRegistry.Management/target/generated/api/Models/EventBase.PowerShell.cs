// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.PowerShell;

    /// <summary>Defines the event properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(EventBaseTypeConverter))]
    public partial class EventBase
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.EventBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EventBase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.EventBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBase DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EventBase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.EventBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EventBase(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Topic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Topic = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic) content.GetValueForProperty("Topic",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Topic, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.TopicTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Notifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Notifier = (string) content.GetValueForProperty("Notifier",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Notifier, global::System.Convert.ToString);
            }
            if (content.Contains("Configuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Configuration = (string) content.GetValueForProperty("Configuration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Configuration, global::System.Convert.ToString);
            }
            if (content.Contains("TopicPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).TopicPath = (string) content.GetValueForProperty("TopicPath",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).TopicPath, global::System.Convert.ToString);
            }
            if (content.Contains("TopicRetain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).TopicRetain = (string) content.GetValueForProperty("TopicRetain",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).TopicRetain, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.EventBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EventBase(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Topic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Topic = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic) content.GetValueForProperty("Topic",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Topic, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.TopicTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Notifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Notifier = (string) content.GetValueForProperty("Notifier",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Notifier, global::System.Convert.ToString);
            }
            if (content.Contains("Configuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Configuration = (string) content.GetValueForProperty("Configuration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).Configuration, global::System.Convert.ToString);
            }
            if (content.Contains("TopicPath"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).TopicPath = (string) content.GetValueForProperty("TopicPath",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).TopicPath, global::System.Convert.ToString);
            }
            if (content.Contains("TopicRetain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).TopicRetain = (string) content.GetValueForProperty("TopicRetain",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal)this).TopicRetain, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EventBase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EventBase" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBase FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Defines the event properties.
    [System.ComponentModel.TypeConverter(typeof(EventBaseTypeConverter))]
    public partial interface IEventBase

    {

    }
}