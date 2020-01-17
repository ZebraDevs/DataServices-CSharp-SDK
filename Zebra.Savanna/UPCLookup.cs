using Newtonsoft.Json;
using Zebra.Savanna.Models;
using System.Threading.Tasks;

namespace Zebra.Savanna
{
    /// <summary>
    /// Provides access to the Savanna UPC Lookup API.
    /// </summary>
    public class UPCLookup : SavannaAPI
    {
        /// <summary>
        /// Retrieves product information in JSON format for a provided UPC code
        /// </summary>
        /// <param name="upc">UPC Code</param>
        /// <returns>A <see cref="string"/> containing product information for the provided UPC</returns>
        public static async Task<string> LookupAsync(string upc)
        {
            return await CallService("barcode/lookup?upc=" + upc);
        }

        /// <summary>
        /// Retrieves product information in JSON format for a provided UPC code
        /// </summary>
        /// <param name="upc">UPC Code</param>
        /// <returns>A <see cref="BarcodeData"/> containing product information for the provided UPC</returns>
        public static async Task<BarcodeData> DeserializeLookupAsync(string upc)
        {
            string json = await LookupAsync(upc);
            return JsonConvert.DeserializeObject<BarcodeData>(json);
        }
    }
}