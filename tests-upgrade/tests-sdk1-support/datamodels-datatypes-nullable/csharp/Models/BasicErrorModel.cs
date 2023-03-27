// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample.Models
{
    using System.Linq;

    public partial class BasicErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the BasicErrorModel class.
        /// </summary>
        public BasicErrorModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BasicErrorModel class.
        /// </summary>
        public BasicErrorModel(string message, int code, System.DateTime? datetime = default(System.DateTime?), string host = default(string))
        {
            this.Datetime = datetime;
            this.Host = host;
            this.Message = message;
            this.Code = code;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "datetime")]
        public System.DateTime? Datetime { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Message == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Message");
            }
            if (this.Host != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.Host, "^\\d{3}-\\d{2}-\\d{4}$"))
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.Pattern, "Host", "^\\d{3}-\\d{2}-\\d{4}$");
                }
            }
            if (this.Message != null)
            {
                if (this.Message.Length > 300)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MaxLength, "Message", 300);
                }
                if (this.Message.Length < 3)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MinLength, "Message", 3);
                }
            }
        }
    }
}