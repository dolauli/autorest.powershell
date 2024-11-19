namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Response of the count for elements.</summary>
    public partial class CountElementsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountElementsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountElementsResponseInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private int _value;

        /// <summary>Number of children resources in parent resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public int Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="CountElementsResponse" /> instance.</summary>
        public CountElementsResponse()
        {

        }
    }
    /// Response of the count for elements.
    public partial interface ICountElementsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Number of children resources in parent resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of children resources in parent resource.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(int) })]
        int Value { get; set; }

    }
    /// Response of the count for elements.
    internal partial interface ICountElementsResponseInternal

    {
        /// <summary>Number of children resources in parent resource.</summary>
        int Value { get; set; }

    }
}