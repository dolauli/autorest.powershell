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
    /// The image update trigger that caused a build.
    /// </summary>
    public partial class ImageUpdateTrigger
    {
        /// <summary>
        /// Initializes a new instance of the ImageUpdateTrigger class.
        /// </summary>
        public ImageUpdateTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageUpdateTrigger class.
        /// </summary>
        /// <param name="id">The unique ID of the trigger.</param>
        /// <param name="timestamp">The timestamp when the image update
        /// happened.</param>
        /// <param name="images">The list of image updates that caused the
        /// build.</param>
        public ImageUpdateTrigger(string id = default(string), System.DateTime? timestamp = default(System.DateTime?), System.Collections.Generic.IList<ImageDescriptor> images = default(System.Collections.Generic.IList<ImageDescriptor>))
        {
            this.Id = id;
            this.Timestamp = timestamp;
            this.Images = images;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique ID of the trigger.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the image update happened.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the list of image updates that caused the build.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "images")]
        public System.Collections.Generic.IList<ImageDescriptor> Images { get; set; }

    }
}