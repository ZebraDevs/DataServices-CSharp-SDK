namespace Zebra.Savanna.Models.Errors
{
    /// <summary>
    /// Provides details about the results of an API call.
    /// </summary>
    public class Detail
    {
        /// <summary>
        /// The error code encountered while invoking the API.
        /// </summary>
        public string ErrorCode { get; set; }
    }
}