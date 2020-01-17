using Newtonsoft.Json;
using System;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Offer for an item provided by a merchant.
    /// </summary>
    public class Offer
    {
        /// <summary>
        /// Online store name.
        /// </summary>
        public string Merchant { get; set; }

        /// <summary>
        /// Online store domain.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Item name marketed by the merchant.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Currency of <see cref="ListPrice"/> &amp; <see cref="Price"/>. Can be "USD", "CAD", "EUR", "GBP", "SEK".
        /// Default "" means "USD".
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Original price from the store.
        /// </summary>
        [JsonProperty(PropertyName = "list_price")]
        public string ListPrice { get; set; }

        /// <summary>
        /// Sale price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// "Free Shipping" or other shipping information if not free.
        /// </summary>
        public string Shipping { get; set; }

        /// <summary>
        /// "New" or "Used"
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Default "" means available or "Out of Stock"
        /// </summary>
        public string Availability { get; set; }

        /// <summary>
        /// Shop link of the item.
        /// </summary>
        public Uri Link { get; set; }

        /// <summary>
        /// Unix timestamp of when the offer was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "updated_t")]
        public long UpdatedTimestamp { get; set; }
    }
}