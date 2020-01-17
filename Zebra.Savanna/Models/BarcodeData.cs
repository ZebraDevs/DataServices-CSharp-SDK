using System.Collections.Generic;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Response object for UPC lookup
    /// </summary>
    public class BarcodeData : IResponse
    {
        /// <summary>
        /// The status code returned by the API.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Total number of records matching the search criteria.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Offset (page) of results.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Collection of items matching the UPC lookup query.
        /// </summary>
        public List<Data> Items { get; set; }
    }
}