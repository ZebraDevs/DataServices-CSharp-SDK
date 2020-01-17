namespace Zebra.Savanna.Models
{
    /// <summary>
    /// The type of product being recalled (drug, device, or food).
    /// </summary>
    public enum ProductType
    {
        /// <summary>
        /// The recalled product is a drug product.
        /// </summary>
        Drugs,

        /// <summary>
        /// The recalled product is a device product.
        /// </summary>
        Devices,

        /// <summary>
        /// The recalled product is a food product.
        /// </summary>
        Food,
    }
}