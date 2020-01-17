using System;
using Newtonsoft.Json;

namespace Zebra.Savanna.Models
{
    /// <summary>
    /// Converts a Savanna enum to and from JSON.
    /// </summary>
    public class APIEnumConverter : JsonConverter
    {
        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serialzer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var name = Enum.GetName(value.GetType(), value);
            if (name == "Ongoing")
            {
                name = "On-Going";
            }
            else if (name.StartsWith("ClassI"))
            {
                name = name.Insert(5, " ");
            }
            else if (name.StartsWith("Class"))
            {
                name = name.Substring(5);
            }
            writer.WriteValue(name);
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="JsonWriter"/> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            if (int.TryParse(enumString, out _))
            {
                enumString = "Class" + enumString;
            }
            return Enum.Parse(objectType, enumString.Remove('-').Remove(' '), true);
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns><c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}