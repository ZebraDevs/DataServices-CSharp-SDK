using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Item matching a UPC lookup query
    /// </summary>
    public class Data
    {
        /// <summary>
        /// EAN-13, 13-digit European Article Number (aka. GTIN-13). This is the unique number we used to identify each
        /// item in our database. If it starts with 0, the rest 12-digit is the UPC (aka. UPC-A, GTIN-12), ex.
        /// 0885909456017.
        /// </summary>
        public string EAN { get; set; }

        /// <summary>
        /// Item title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Item description with length &lt; 515.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Collection of image urls.
        /// </summary>
        public List<Uri> Images { get; set; }

        /// <summary>
        /// Offers for item provided by merchants.
        /// </summary>
        public List<Offer> Offers { get; set; }

        /// <summary>
        /// Amazon Standard Identification Number (ASIN) is a 10-character alphanumeric unique identifier assigned by
        /// Amazon.com and its partners for product identification within the Amazon organization.
        /// </summary>
        public string ASIN { get; set; }

        /// <summary>
        /// International Standard Book Numbers (ISBN) are numeric commercial book identifiers which are intended to be
        /// unique. An ISBN is assigned to each separate edition and variation (except reprintings) of a publication.
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Publisher name
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// UPC-A, 12-digit Universal Product Code (aka. GTIN-12). If item’s EAN does not start with 0, there is no
        /// corresponding UPC-A code, ex. 6009705662678.
        /// </summary>
        public string UPC { get; set; }

        /// <summary>
        /// Brand name or manufacturer name with length &lt; 64.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Item model number with length &lt; 32.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Item color with length &lt; 32, ex. for clothing, shoes.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Item size with length &lt; 32, ex. for clothing, shoes.
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Item dimension measurements.
        /// </summary>
        public string Dimension { get; set; }

        /// <summary>
        /// Item weight with length &lt; 16.
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// Currency of the <see cref="LowestRecordedPrice"/>. Can be "USD", "CAD", "EUR", "GBP", "SEK". Default ""
        /// means "USD".
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Lowest historical price of the item since tracked by our system. Not available for books.
        /// </summary>
        [JsonProperty(PropertyName = "lowest_recorded_price")]
        public string LowestRecordedPrice { get; set; }

        /// <summary>
        /// Highest historical price of the item since tracked by our system. Not available for books.
        /// </summary>
        [JsonProperty(PropertyName = "highest_recorded_price")]
        public string HighestRecordedPrice { get; set; }

        /// <summary>
        /// eBay Listing ID, aka. item ID or item number. Item ID is 9 to 12 digits in length. If item is found on
        /// eBay.com, you can simply locate the item by http://www.ebay.com/itm/[eLID].
        /// </summary>
        public string ELID { get; set; }
    }
}