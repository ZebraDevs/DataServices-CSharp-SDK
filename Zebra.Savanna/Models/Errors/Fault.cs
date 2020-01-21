namespace Zebra.Savanna.Models.Errors
{
    /// <summary>
    /// Describes issues encountered while invoking an API.
    /// </summary>
    public class Fault
    {
        /// <summary>
        /// The fault that occurred.
        /// </summary>
        public string FaultString { get; set; }

        /// <summary>
        /// Provides details about the results of the API call.
        /// </summary>
        public Detail Detail { get; set; }
    }
}