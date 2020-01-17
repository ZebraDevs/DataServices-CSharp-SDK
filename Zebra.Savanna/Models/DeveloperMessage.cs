namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Provides information about the results of an API call.
    /// </summary>
    public class DeveloperMessage
    {
        /// <summary>
        /// Describes issues encountered while invoking the API.
        /// </summary>
        public Fault Fault { get; set; }
    }
}