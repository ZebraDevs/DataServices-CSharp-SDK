using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zebra.Savanna.Models;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Zebra.Savanna
{
    /// <summary>
    /// Provides common functionality for access to Savanna APIs.
    /// </summary>
    public abstract class SavannaAPI
    {
        private const string baseUrl = "https://api.zebra.com/v2/tools/";

        private static HttpClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new HttpClient(new HttpClientHandler()
                    {
                        AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                    });
                    _client.DefaultRequestHeaders.Add("apikey", APIKey);
                }
                return _client;
            }
        }
        private static HttpClient _client;

        /// <summary>
        /// Your Zebra Savanna application key.
        /// </summary>
        public static string APIKey
        {
            get { return _apiKey; }
            set
            {
                _apiKey = value;
                if (_client != null)
                {
                    _client.DefaultRequestHeaders.Clear();
                    _client.DefaultRequestHeaders.Add("apikey", _apiKey);
                }
            }
        }
        private static string _apiKey;

        /// <summary>
        /// Retrieve a json string from a Barcode Intelligence Tools service.
        /// </summary>
        /// <param name="api">The API path of the tool being accessed.</param>
        /// <returns>A <see cref="string"/> containing json returned by the API call.</returns>
        protected static async Task<string> CallService(string api)
        {
            var response = await Client.GetAsync(baseUrl + api);
            string json = await response.Content.ReadAsStringAsync();
            CheckErrors(json);
            return json;
        }

        /// <summary>
        /// Retrieve raw bytes from a Barcode Intelligence Tools service.
        /// </summary>
        /// <param name="api">The API path of the tool being accessed.</param>
        /// <returns>A <see cref="T:byte[]"/> representation of the API call result.</returns>
        protected static async Task<byte[]> CallServiceBytes(string api)
        {
            var response = await Client.GetAsync(baseUrl + api);
            var json = (await response.Content.ReadAsStringAsync()).Trim();
            if (json.StartsWith("{"))
            {
                CheckErrors(json);
            }
            return await response.Content.ReadAsByteArrayAsync();
        }

        /// <summary>
        /// Throw a deserialized error message from Savanna API response.
        /// </summary>
        /// <param name="json">The json response from a Savanna service.</param>
        public static void CheckErrors(string json)
        {
            dynamic dynObj = JObject.Parse(json.Trim());
            if (dynObj.errorResponse != null)
            {
                dynObj = dynObj.errorResponse;
            }
            var message = dynObj.message ?? dynObj.Message;
            if (message != null)
            {
                if (dynObj.DeveloperMessage is JObject)
                {
                    var error = JsonConvert.DeserializeObject<Error<DeveloperMessage>>(((JObject)dynObj).ToString());
                    error = new Error<DeveloperMessage>(message.ToString()) { Code = error.Code, Info = error.Info, DeveloperMessage = error.DeveloperMessage, };
                    throw error;
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<Error<string>>(json);
                    error = new Error<string>(message.ToString()) { Code = error.Code, Info = error.Info, DeveloperMessage = error.DeveloperMessage, };
                    throw error;
                }
            }
            if (dynObj.fault != null)
            {
                var developerMessage = JsonConvert.DeserializeObject<DeveloperMessage>(((JObject)dynObj).ToString());
                var error = new Error<DeveloperMessage>(developerMessage.Fault.FaultString)
                {
                    DeveloperMessage = developerMessage,
                };
                throw error;
            }
        }
    }
}