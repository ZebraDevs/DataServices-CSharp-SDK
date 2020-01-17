namespace Zebra.Savanna.Models
{
    /// <summary>
    /// A risk based classification system for all medical devices ((Federal Food, Drug, and Cosmetic Act, section 513)
    /// </summary>
    public enum DeviceClass
    {
        /// <summary>
        /// Class I (low to moderate risk): general controls
        /// </summary>
        Class1,
        /// <summary>
        /// Class II (moderate to high risk): general controls and special controls
        /// </summary>
        Class2,
        /// <summary>
        /// Class III (high risk): general controls and Premarket Approval (PMA)
        /// </summary>
        Class3,
        /// <summary>
        /// Unclassified
        /// </summary>
        U,
        /// <summary>
        /// Not classified
        /// </summary>
        N,
        /// <summary>
        /// HDE
        /// </summary>
        F,
    }
}