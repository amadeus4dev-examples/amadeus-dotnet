using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus
{
    /// <summary>
    /// A convenient helper class for building data to pass into a request.
    /// <code>
    /// amadeus.get("/foo/bar", Params.with("first_name", "John").and("last_name", "Smith"));
    /// </code>
    /// </summary>
    public class Params : Dictionary<string, string>
    {

        /// <summary>
        /// Initializes a new instance of the Params class.
        /// </summary>
        public Params()
        {
        }

        /// <summary>
        /// Initializes a new Param map with an initial key/value pair.
        /// </summary>
        /// <returns>the Param object, allowing for convenient chaining</returns>
        /// <param name="key">key the key for the parameter to send to the API</param>
        /// <param name="value">the value for the given key</param>
        public static Params with(string key, string value)
        {
            return new Params().and(key, value);
        }

        /// <summary>
        /// Adds another key/value pair to the Params map. Automatically
        /// converts all values to strings.
        /// <code>
        /// amadeus.get("/foo/bar", Params.with("first_name", "John").and("last_name", "Smith"));
        /// </code>
        /// </summary>
        /// <returns>the Param object, allowing for convenient chaining</returns>
        /// <param name="key">the key for the parameter to send to the API</param>
        /// <param name="value">the value for the given key</param>
        public Params and(string key, string value)
        {
            this[key] = value;
            return this;
        }

        /// <summary>
        /// Converts params into a HTTP query string.
        /// </summary>
        /// <returns>The query string.</returns>
        public string toQueryString()
        {
            StringBuilder query = new StringBuilder();
            bool first = true;
            foreach (KeyValuePair<string,string> entry in this)
            {
                if (!first)
                {
                    query.Append("&");
                }
                first = false;
                try
                {
                    query.Append(System.Web.HttpUtility.UrlEncode(entry.Key, Encoding.UTF8));
                    query.Append("=");
                    query.Append(System.Web.HttpUtility.UrlEncode(entry.Value, Encoding.UTF8));
                } catch {}
            }

            return query.ToString();
        }

        /// <summary>
        /// Converts params into a HTTP query string.
        /// </summary>
        /// <returns>The string.</returns>
        public string toString()
        {
            return toQueryString();
        }

        /// <summary>
        /// Clone this instance.
        /// </summary>
        /// <returns>The clone.</returns>
        public Params clone()
        {
            Params _params = new Params();
            foreach (var newelem in this)
                _params.Add(newelem.Key.ToString(), newelem.Value.ToString());
            return _params;
        }

        /// <summary>
        /// Returns a String that represents the current Params.
        /// </summary>
        /// <returns>A String that represents the current Params.</returns>
        public override string ToString()
        {
            return toString();
        }

    }

}
