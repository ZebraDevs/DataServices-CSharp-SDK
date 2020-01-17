using Newtonsoft.Json;
using System;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Includes a disclaimer, a link to the openFDA data license, and information about the results.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Important details notes about openFDA data and limitations of the dataset.
        /// </summary>
        public string Disclaimer { get; set; }

        /// <summary>
        /// Link to a web page with license terms that govern data within openFDA.
        /// </summary>
        public Uri Terms { get; set; }

        /// <summary>
        /// Link to a web page with the license that governs data within openFDA.
        /// </summary>
        public Uri License { get; set; }

        /// <summary>
        /// The last date when this openFDA endpoint was updated. Note that this does not correspond to the most recent
        /// record for the endpoint or dataset. Rather, it is the last time the openFDA API was itself updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_updated")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Information about the results.
        /// </summary>
        public MetaResults Results { get; set; }
    }
}