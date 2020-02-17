using Newtonsoft.Json;
using Zebra.Savanna.Models;
using System.Threading.Tasks;
using System.Web;

namespace Zebra.Savanna
{
    /// <summary>
    /// Provides access to the Savanna FDA Recall APIs.
    /// </summary>
    public class FDARecall : SavannaAPI
    {
        /// <summary>
        /// Returns medical device recall notices for a given description
        /// </summary>
        /// <param name="search">A simple one word search string</param>
        /// <param name="limit"> Maximum number of records to return</param>
        /// <returns> A <see cref="string"/> containing results from the device recall search, if any</returns>
        public static async Task<string> DeviceSearchAsync(string search, int limit = 1)
        {
            return await CallService(string.Format("recalls/device/description?val={0}&limit={1}", HttpUtility.UrlEncode(search), limit));
        }

        /// <summary>
        /// Returns drug recall notices for a given description
        /// </summary>
        /// <param name="search"> A simple one word search string</param>
        /// <param name="limit">Maximum number of records to return</param>
        /// <returns>A <see cref="string"/> containing results from the drug recall search, if any</returns>
        public static async Task<string> DrugSearchAsync(string search, int limit = 1)
        {
            return await CallService(string.Format("recalls/drug/description?val={0}&limit={1}", HttpUtility.UrlEncode(search), limit));
        }

        /// <summary>
        /// Returns food recall notices for a given UPC code
        /// </summary>
        /// <param name="upc">A valid UPC code for a food item</param>
        /// <param name="limit">Maximum number of records to return (maximum 99)</param>
        /// <returns>A <see cref="string"/> containing results from the food recall lookup, if any</returns>
        public static async Task<string> FoodUpcAsync(string upc, int limit = 1)
        {
            return await CallService(string.Format("recalls/food/upc?val={0}&limit={1}", upc, limit));
        }

        /// <summary>
        /// Returns FDA drug recall notices for a UPC code
        /// </summary>
        /// <param name="upc">Value</param>
        /// <param name="limit">Maximum number of records to return</param>
        /// <returns>A <see cref="string"/> containing results from the drug recall lookup, if any</returns>
        public static async Task<string> DrugUpcAsync(string upc, int limit = 1)
        {
            return await CallService(string.Format("recalls/drug/upc?val={0}&limit={1}", upc, limit));
        }

        /// <summary>
        /// Returns medical device recall notices for a given description
        /// </summary>
        /// <param name="search">A simple one word search string</param>
        /// <param name="limit"> Maximum number of records to return</param>
        /// <returns> A <see cref="Recall{T}"/> containing results from the device recall search, if any</returns>
        public static async Task<Recall<Device>> DeserializeDeviceSearchAsync(string search, int limit = 1)
        {
            string json = await DeviceSearchAsync(search, limit);
            return JsonConvert.DeserializeObject<Recall<Device>>(json);
        }

        /// <summary>
        /// Returns drug recall notices for a given description
        /// </summary>
        /// <param name="search"> A simple one word search string</param>
        /// <param name="limit">Maximum number of records to return</param>
        /// <returns>A <see cref="Recall{T}"/> containing results from the drug recall search, if any</returns>
        public static async Task<Recall<Product>> DeserializeDrugSearchAsync(string search, int limit = 1)
        {
            string json = await DrugSearchAsync(search, limit);
            return JsonConvert.DeserializeObject<Recall<Product>>(json);
        }

        /// <summary>
        /// Returns food recall notices for a given UPC code
        /// </summary>
        /// <param name="upc">A valid UPC code for a food item</param>
        /// <param name="limit">Maximum number of records to return (maximum 99)</param>
        /// <returns>A <see cref="Recall{T}"/> containing results from the food recall lookup, if any</returns>
        public static async Task<Recall<Product>> DeserializeFoodUpcAsync(string upc, int limit = 1)
        {
            string json = await FoodUpcAsync(upc, limit);
            return JsonConvert.DeserializeObject<Recall<Product>>(json);
        }

        /// <summary>
        /// Returns FDA drug recall notices for a UPC code
        /// </summary>
        /// <param name="upc">Value</param>
        /// <param name="limit">Maximum number of records to return</param>
        /// <returns>A <see cref="Recall{T}"/> containing results from the drug recall lookup, if any</returns>
        public static async Task<Recall<Product>> DeserializeDrugUpcAsync(string upc, int limit = 1)
        {
            string json = await DrugUpcAsync(upc, limit);
            return JsonConvert.DeserializeObject<Recall<Product>>(json);
        }
    }
}