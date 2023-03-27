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

    /// <summary>
    /// Defines values for ResourceIdentityType.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResourceIdentityType
    {
        /// <summary>
        /// Use an implicitly created system assigned managed identity to
        /// manage cluster resources. Master components in the control plane
        /// such as kube-controller-manager will use the system assigned
        /// managed identity to manipulate Azure resources.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "SystemAssigned")]
        SystemAssigned,
        /// <summary>
        /// Use a user-specified identity to manage cluster resources. Master
        /// components in the control plane such as kube-controller-manager
        /// will use the specified user assigned managed identity to manipulate
        /// Azure resources.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "UserAssigned")]
        UserAssigned,
        /// <summary>
        /// Do not use a managed identity for the Managed Cluster, service
        /// principal will be used instead.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "None")]
        None
    }
    internal static class ResourceIdentityTypeEnumExtension
    {
        internal static string ToSerializedValue(this ResourceIdentityType? value)
        {
            return value == null ? null : ((ResourceIdentityType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ResourceIdentityType value)
        {
            switch( value )
            {
                case ResourceIdentityType.SystemAssigned:
                    return "SystemAssigned";
                case ResourceIdentityType.UserAssigned:
                    return "UserAssigned";
                case ResourceIdentityType.None:
                    return "None";
            }
            return null;
        }

        internal static ResourceIdentityType? ParseResourceIdentityType(this string value)
        {
            switch( value )
            {
                case "SystemAssigned":
                    return ResourceIdentityType.SystemAssigned;
                case "UserAssigned":
                    return ResourceIdentityType.UserAssigned;
                case "None":
                    return ResourceIdentityType.None;
            }
            return null;
        }
    }
}