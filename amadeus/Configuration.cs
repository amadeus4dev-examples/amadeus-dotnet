using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace amadeus
{

    /// <summary>
    /// <para>
    /// The configuration for the Amadeus API client. To initialize, use the builder as follows:
    /// </para>
    /// 
    /// <code>
    /// Amadeus amadeus =
    ///     Amadeus.builder("REPLACE_BY_YOUR_API_KEY", "REPLACE_BY_YOUR_API_SECRET").build();
    /// </code>
    /// 
    /// <para>
    /// Or pass in environment variables directly:
    /// </para>
    /// 
    /// <code>
    /// System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_ID", "REPLACE_BY_YOUR_API_KEY");
    /// System.Environment.SetEnvironmentVariable("AMADEUS_CLIENT_SECRET", "REPLACE_BY_YOUR_API_SECRET");
    /// Amadeus.builder().build();
    /// </code>
    /// </summary>
    public class Configuration
    {
        internal Params HOSTS = Params.with("production", "api.amadeus.com").and("test", "test.api.amadeus.com");

        /// <summary>
        /// The client ID used to authenticate the API calls.
        /// </summary>
        /// <value>The client ID.</value>
        public string clientId { get; }

        /// <summary>
        /// The client secret used to authenticate the API calls.
        /// </summary>
        /// <value>The client secret.</value>
        public string clientSecret { get; }

        /// <summary>
        /// The logger that will be used to debug or warn to.
        /// </summary>
        /// <value>The logger that will be used to debug or warn to.</value>
        public TraceSource Logger { get; set; } = new TraceSource("Amadeus");

        /// <summary>
        /// The log level. Can be 'silent', 'warn', or 'debug'. Defaults to 'silent'.
        /// </summary>
        /// <value>The log level for the logger.</value>
        public string logLevel { get; set; } = "silent";

        /// <summary>
        /// The the name of the server API calls are made to, 'production' or 'test'. Defaults to 'test'
        /// </summary>
        /// <value>The name of the server API calls are made to</value>
        public string hostname { get; set; } = "test";

        /// <summary>
        /// The optional custom host domain to use for API calls. Defaults to internal value for
        /// 'hostname'
        /// </summary>
        /// <value>The optional custom host domain to use for API calls.</value>
        public string host { get; set; } = "test.api.amadeus.com";

        /// <summary>
        /// Wether to use SSL. Defaults to True
        /// </summary>
        /// <value>A boolean specifying if the connection should use SSL</value>
        public bool ssl { get; set; } = true;

        /// <summary>
        /// The port to use. Defaults to 443 for an SSL connection, and 80 for a non SSL connection.
        /// </summary>
        /// <value>The port to use for the connection</value>
        public int port { get; set; } = 443;

        /// <summary>
        /// An optional custom App ID to be passed in the User Agent to the server (Defaults to null).
        /// </summary>
        /// <value>The optional custom App ID</value>
        public string customAppId { get; set; }

        /// <summary>
        /// An optional custom App version to be passed in the User Agent to the server (Defaults to null).
        /// </summary>
        /// <value>The optional custom App version.</value>
        public string customAppVersion { get; set; }

        /// <summary>
        /// Initializes a new instance of the Configuration class.
        /// </summary>
        /// <param name="clientId">Client identifier.</param>
        /// <param name="clientSecret">Client secret.</param>
        public Configuration(String clientId, String clientSecret)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }

        /// <summary>
        /// Builds an Amadeus client with the provided credentials.
        /// </summary>
        /// <returns>an Amadeus client.</returns>
        public Amadeus build()
        {
            return new Amadeus(this.parseEnvironment());
        }

        /// <summary>
        /// The the name of the server API calls are made to, 'production' or 'test'. Defaults to 'test'.
        /// </summary>
        /// <returns>The name of the server API calls are made to.</returns>
        /// <param name="hostname">The name of the server API calls are made to.</param>
        public Configuration setHostname(string hostname)
        {
            if (!HOSTS.ContainsKey(hostname))
            {
                throw new ArgumentException("Hostname " + hostname + " not found in " + HOSTS.toString());
            }
            this.hostname = hostname;
            this.host = HOSTS[hostname];
            return this;
        }

        /// <summary>
        /// Whether to use SSL. Defaults to True.
        /// </summary>
        /// <returns>A boolean specifying if the connection should use SSL</returns>
        /// <param name="ssl">A boolean specifying if the connection should use SSL</param>
        public Configuration setSsl(Boolean ssl)
        {
            this.ssl = ssl;
            if (!ssl && port == 443)
            {
                port = 80;
            }
            return this;
        }

        /// <summary>
        /// Set loglevel. Defaults to silent
        /// </summary>
        /// <returns>A configuration.</returns>
        /// <param name="level">A string specifying level options: silent, debug, info, warm, error</param>
        public Configuration setLoglevel(String level)
        {
            this.logLevel = level;
            return this;
        }

        // Parses environment variables and initializes the values.
        internal Configuration parseEnvironment()
        {
            setHostname(getOrDefault("HOSTNAME", hostname));
            host = (getOrDefault("HOST", host));
            logLevel = (getOrDefault("LOG_LEVEL", logLevel));
            setSsl(Boolean.Parse(getOrDefault("SSL", ssl.ToString())));
            port = Int32.Parse(getOrDefault("PORT", port.ToString()));
            customAppId = getOrDefault("CUSTOM_APP_ID", customAppId);
            customAppVersion = getOrDefault("CUSTOM_APP_VERSION", customAppVersion);
            return this;
        }

        // Helper method as it's missing the getOrDefault method for Maps
        internal string getOrDefault(string key, string defaultValue)
        {
            string value = Environment.GetEnvironmentVariable("AMADEUS_" + key);
            return (value == null) ? defaultValue : value;
        }

    }
}
