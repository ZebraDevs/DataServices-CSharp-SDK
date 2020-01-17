namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Information about the results.
    /// </summary>
    public class MetaResults
    {
        /// <summary>
        /// Offset (page) of results, defined by the skip query parameter.
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// Number of records returned, defined by the limit query parameter. If there is no limit parameter, the
        /// API returns one result.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Total number of records matching the search criteria.
        /// </summary>
        public int Total { get; set; }
    }
}