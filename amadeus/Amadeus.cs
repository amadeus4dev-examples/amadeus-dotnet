using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using resources.exceptions;

namespace amadeus
{

    /// <summary>
    /// The Amadeus API client. To initialize, use the builder as follows:
    /// <para>To initialize, use the builder as follows:</para>
    /// <code>
    /// Amadeus amadeus = Amadeus.builder("REPLACE_BY_YOUR_API_KEY", "REPLACE_BY_YOUR_API_SECRET").build();
    /// </code>
    /// <para>Or pass in environment variables directly:</para>
    /// <code>
    /// System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_ID", "REPLACE_BY_YOUR_API_KEY");
    /// System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_SECRET", "REPLACE_BY_YOUR_API_SECRET");
    /// Amadeus.builder().build();
    /// </code>
    /// </summary>
    public class Amadeus : HTTPClient
    {

        /// <summary>
        /// The API version.
        /// </summary>
        public const string VERSION = "1.0.0";

        /// <summary>
        /// A namespaced client for the <code>/v2/reference-data</code> endpoints.
        /// </summary>
        public ReferenceData referenceData;

        /// <summary>
        /// A namespaced client for the <code>/v1/travel</code> endpoints.
        /// </summary>
        public Travel travel;

        /// <summary>
        /// A namespaced client for the <code>/v1/shopping</code> endpoints.
        /// </summary>
        public Shopping shopping;

        /// <summary>
        /// Initializes a new instance of the Amadeus class.
        /// </summary>
        public Amadeus() : base(null)
        {

        }

        /// <summary>
        /// Initializes a new instance of the Amadeus class.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        public Amadeus(Configuration configuration) : base(configuration)
        {
            this.referenceData = new ReferenceData(this);
            this.travel = new Travel(this);
            this.shopping = new Shopping(this);
        }

        /// <summary>
        /// Creates a builder object that can be used to build an Amadeus API client.
        /// </summary>
        /// <returns>A configuration object</returns>
        /// <param name="clientId">Your API client ID</param>
        /// <param name="clientSecret">Your API client Secret</param>
        public static Configuration builder(string clientId, string clientSecret)
        {
            return new Configuration(clientId, clientSecret);
        }

        /// <summary>
        /// Creates a builder object initialized with the environment variables that can be used to build an Amadeus API client
        /// </summary>
        /// <returns>A configuration object</returns>
        public static Configuration builder()
        {
            string clientId = Environment.GetEnvironmentVariable("AMADEUS_CLIENT_ID");
            string clientSecret = Environment.GetEnvironmentVariable("AMADEUS_CLIENT_SECRET");

            if ((clientId == null) || (clientSecret == null))
            {
                Console.Write("client_id and client_secret not set!");
            }

            Configuration configuration = Amadeus.builder(clientId, clientSecret);
            return configuration;
        }

    }

}
