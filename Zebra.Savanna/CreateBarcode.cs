using System.Threading.Tasks;

namespace Zebra.Savanna
{
    /// <summary>
    /// Provides access to the Savanna barcode creation APIs.
    /// </summary>
    public class CreateBarcode : SavannaAPI
    {
        /// <summary>
        /// Generates a barcode from the text provided and returns a PNG image
        /// </summary>
        /// <param name="symbology">The barcode symbology.</param>
        /// <param name="text">
        /// The data or text to include in the generated barcode. Usually an error will occur when the barcode
        /// symbology cannot support the text provided. Different symbology allow for numbers only, or alpha-numeric,
        /// or uppercase alphabets, and some restrict characters. For example: code39 only accepts numbers and
        /// uppercase letters.
        /// </param>
        /// <param name="scale">
        /// Sets both the x-axis and the y-axis scaling factors. Must be an integer &gt; 0. Use if you want default X
        /// &amp; Y, just different size.
        /// short.
        /// </param>
        /// <param name="rotate">Rotates the barcode in 90 degree increments.</param>
        /// <param name="includeText">
        /// Allows for the data included in the barcode to be printed in human readable form with the barcode (usually
        /// printed text under the linear barcode, this setting is ignored for many 2D symbologies such as qrcode).
        /// </param>
        /// <returns>A <see cref="T:byte[]"/> containing the png-encoded image</returns>
        public static async Task<byte[]> CreateAsync(Symbology symbology, string text, int scale = 1, Rotation rotate = Rotation.Normal, bool includeText = false)
        {
            var bytes = await CallServiceBytes(string.Format("barcode/generate?symbology={0}&text={1}&scale={2}&rotate={3}&includeText={4}",
                    symbology.ToString().Replace('_', '-'), text, scale, (char)rotate, includeText));
            return bytes;
        }

        /// <summary>
        /// Generates a barcode from the text provided and returns a PNG image
        /// </summary>
        /// <param name="symbology">The barcode symbology.</param>
        /// <param name="text">
        /// The data or text to include in the generated barcode. Usually an error will occur when the barcode
        /// symbology cannot support the text provided. Different symbology allow for numbers only, or alpha-numeric,
        /// or uppercase alphabets, and some restrict characters. For example: code39 only accepts numbers and
        /// uppercase letters.
        /// </param>
        /// <param name="scaleX">
        /// Sets the x-axis. Must be an integer &gt; 0. Use with scaleY, if using scale only, leave scaleX &amp; scaleY
        /// blank. Allows proportional changes to the resulting barcode, helpful with linear barcodes to make tall or
        /// short.
        /// </param>
        /// <param name="scaleY">Sets the y-axis scaling factors. Must be an integer &gt; 0. Use with scaleX.</param>
        /// <param name="rotate">Rotates the barcode in 90 degree increments.</param>
        /// <param name="includeText">
        /// Allows for the data included in the barcode to be printed in human readable form with the barcode (usually
        /// printed text under the linear barcode, this setting is ignored for many 2D symbologies such as qrcode).
        /// </param>
        /// <returns>A <see cref="T:byte[]"/> containing the png-encoded image</returns>
        public static async Task<byte[]> CreateAsync(Symbology symbology, string text, int scaleX, int scaleY, Rotation rotate = Rotation.Normal, bool includeText = false)
        {
            var bytes = await CallServiceBytes(
                    string.Format("barcode/generate?symbology={0}&text={1}&scaleX={2}&scaleY={3}&rotate={4}&includeText={5}",
                            symbology.ToString().Replace('_', '-'), text, scaleX, scaleY, (char)rotate, includeText));
            return bytes;
        }
    }
}