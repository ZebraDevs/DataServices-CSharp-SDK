namespace Zebra.Savanna.Models
{
    /// <summary>
    /// The result of an API call.
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// The status code returned by the API.
        /// </summary>
        string Code { get; set; }
    }
}