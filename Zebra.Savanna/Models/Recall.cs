using System.Collections.Generic;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Provides public FDA data about nouns like drugs, devices, and foods.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Recall<T>
    {
        /// <summary>
        /// Includes a disclaimer, a link to the openFDA data license, and information about the results that follow.
        /// </summary>
        public Meta Meta { get; set; }

        /// <summary>
        /// A <see cref="List{T}" /> of matching records.
        /// </summary>
        public List<T> Results { get; set; }
    }
}