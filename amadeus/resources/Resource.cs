using System;
using System.Linq;
using amadeus;
using amadeus.resources;
using Newtonsoft.Json;

namespace amadeus.resources
{
    /// <summary>
    /// Internal Resource class
    /// </summary>
    public class Resource
    {
        internal Resource()
        {
        }

        /// <summary>
        /// The original response that this object is populated from.
        /// </summary>
        /// <value>The response.</value>
        public Response response { get; set; }

        /// <summary>
        /// The class used for deserialization.
        /// </summary>
        /// <value>The de serialization class.</value>
        internal Type deSerializationClass { get; set; }

        /// <summary>
        /// Turns a response into a Gson deserialized array of resources,
        /// attaching the response to each resource.
        /// </summary>
        /// <returns>The array.</returns>
        /// <param name="response">Response.</param>
        /// <param name="type">Type.</param>
        internal static Resource[] fromArray(Response response, Type type)
        {
            Console.WriteLine(response.dataString);
            Resource[] resources = JsonConvert.DeserializeObject(response.dataString, type);
            foreach (Resource resource in resources)
            {
                resource.response = response;
                resource.deSerializationClass = type;
            }
            return resources;
        }

        /*
         * Turns a response into a Gson deserialized resource,
         * attaching the response to the resource.
         * @hide as only used internally
         */
        internal static Resource fromObject(Response response, Type type)
        {
            Resource resource = JsonConvert.DeserializeObject(response.dataString, type);
            resource.response = response;
            resource.deSerializationClass = type;
            return resource;
        }

        /*
         * Turns a response into a JSON serialized string,
         * attaching the response to each resource.
         * @hide as only used internally
         */
        internal static string toStringResult(Response response)
        {
            return response.dataString;
        }

        /// <summary>
        /// Returns a String that represents the current Resource.
        /// </summary>
        /// <returns>A String that represents the current Resource.</returns>
        public override string ToString()
        {
            var result = GetType().ToString() + "[";
            var propertyStrings = from prop in GetType().GetProperties()
                                  select $"{prop.Name}={prop.GetValue(this)}";
            result += string.Join(", ", propertyStrings);
            result += "]";
            return result;
        }
    }
}
