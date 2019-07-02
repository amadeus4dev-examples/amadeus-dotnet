using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;
using resources;

namespace amadeus
{
    /// <summary>
    /// Request object to API
    /// </summary>
    public class Request
    {

        /// <summary>
        /// The HTTPClient verb to use for API calls.
        /// </summary>
        /// <value>HTTPClient verb.</value>
        public string verb { get; set; }

        /// <summary>
        /// The scheme to use for API calls. 
        /// </summary>
        /// <value>The scheme.</value>
        public string scheme { get; set; }

        /// <summary>
        /// The host domain to use for API calls.
        /// </summary>
        /// <value>The host.</value>
        public string host { get; set; }

        /// <summary>
        /// The path use for API calls.
        /// </summary>
        /// <value>The path.</value>
        public string path { get; set; }

        /// <summary>
        /// The params to send to the API endpoint.
        /// </summary>
        /// <value>The parameters.</value>
        public Params _params { get; set; }

        /// <summary>
        /// The bearer token used to authenticate the API call.
        /// </summary>
        /// <value>The bearer token.</value>
        public string bearerToken { get; set; }

        /// <summary>
        /// The version of the SDK used
        /// </summary>
        /// <value>The client version.</value>
        public string clientVersion { get; set; }

        /// <summary>
        /// The version of C# used.
        /// </summary>
        /// <value>The language version.</value>
        public string languageVersion { get; set; }

        /// <summary>
        /// The custom Application ID passed in the user agent.
        /// </summary>
        /// <value>The app identifier.</value>
        public string appId { get; set; }

        /// <summary>
        /// The custom Application Version passed in the user agent.
        /// </summary>
        /// <value>The app version.</value>
        public string appVersion { get; set; }

        /// <summary>
        /// Whether this connection uses SSL.
        /// </summary>
        /// <value><c>true</c> if ssl; otherwise, <c>false</c>.</value>
        public bool ssl { get; set; }

        /// <summary>
        /// The port to use for this request.
        /// </summary>
        /// <value>The port.</value>
        public int port { get; set; }

        /// <summary>
        /// The headers for this request.
        /// </summary>
        /// <value>The headers.</value>
        public Dictionary<string,string> headers { get; set; }

        /// <summary>
        /// The full URI for this request, based on the
        /// verb, port, path, host, etc.
        /// </summary>
        /// <value>The URI.</value>
        public string uri { get; set; }

        /// <summary>
        /// The connection used to make the API call.
        /// </summary>
        /// <value>The connection.</value>
        public HttpWebRequest connection { get; set; }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        /// <value>The response.</value>
        public HttpWebResponse response { get; set; }

        /// <summary>
        /// Initializes a new instance of the Request class.
        /// </summary>
        /// <param name="verb">Verb.</param>
        /// <param name="path">Path.</param>
        /// <param name="_params">Parameters.</param>
        /// <param name="bearerToken">Bearer token.</param>
        /// <param name="client">Client.</param>
        public Request(string verb, string path, Params _params, string bearerToken, HTTPClient client)
        {
            Configuration config = client.configuration;

            this.verb = verb;
            this.host = config.host;
            this.path = path;
            this._params = _params;
            this.bearerToken = bearerToken;
            this.languageVersion = typeof(string).Assembly.ImageRuntimeVersion;
            this.clientVersion = Amadeus.VERSION;
            this.appId = config.customAppId;
            this.appVersion = config.customAppVersion;
            this.port = config.port;
            this.ssl = config.ssl;

            determineScheme();
            prepareUrl();
            prepareHeaders();
        }


        /// <summary>
        /// Establishs the connection.
        /// </summary>
        public void establishConnection()
        {
            connection = (HttpWebRequest) WebRequest.Create(uri);
            connection.Method = verb;
            connection.ContentType = "application/x-www-form-urlencoded";
            foreach (KeyValuePair<string, string> entry in headers)
            {
                if (entry.Key == "User-Agent")
                {
                    connection.UserAgent = entry.Value;
                }
                else if (entry.Key == "Accept")
                {
                    connection.Accept = entry.Value;
                }
                else
                {
                    connection.Headers.Add(entry.Key, entry.Value);
                }
            }
        }

        /// <summary>
        /// Determines the scheme.
        /// </summary>
        public void determineScheme()
        {
            this.scheme = ssl ? Constants.HTTPS : Constants.HTTP;
        }

        /// <summary>
        /// Prepares the full URL based on the scheme, host, port and path.
        /// </summary>
        public void prepareUrl()
        {
            this.uri = scheme + "://" + host + ":" + port + path + "?" + getQueryParams();
        }

        /// <summary>
        /// Prepares the headers to be sent in the request
        /// </summary>
        public void prepareHeaders()
        {
            this.headers = new Dictionary<string, string>();
            headers[Constants.USER_AGENT] = buildUserAgent();
            headers[Constants.ACCEPT] = "application/json, application/vnd.amadeus+json";
            if (bearerToken != null)
            {
                headers[Constants.AUTHORIZATION] = bearerToken;
            }
        }

        /// <summary>
        /// Determines the User-Agent header, based on the client version, language version, and custom
        /// app information.
        /// </summary>
        /// <returns>The user agent.</returns>
        public string buildUserAgent()
        {
            string userAgent = "amadeus-csharp/" + clientVersion;
            userAgent += " csharp/" + languageVersion;
            if (appId != null)
            {
                userAgent += " " + appId + "/" + appVersion;
            }
            return userAgent;
        }

        /// <summary>
        /// Gets the serialized params, only if this is a Get call
        /// </summary>
        /// <returns>The query parameters.</returns>
        public string getQueryParams()
        {
            if (verb == Constants.GET && _params != null) {
                return _params.toQueryString();
            } else {
                return "";
            }
        }

        /// <summary>
        /// Returns a String that represents the current Request.
        /// </summary>
        /// <returns>A String that represents the current Request.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder(this.GetType() + "(");
            sb.Append("verb=" + verb + ",");
            sb.Append("host=" + host + ",");
            sb.Append("path=" + path + ",");
            sb.Append("params=" + _params + ",");
            sb.Append("bearerToken=" + bearerToken + ",");
            sb.Append("languageVersion=" + languageVersion + ",");
            sb.Append("clientVersion=" + clientVersion + ",");
            sb.Append("appId=" + appId + ",");
            sb.Append("appVersion=" + appVersion + ",");
            sb.Append("port=" + port + ",");
            sb.Append("ssl=" + ssl);
            return sb.ToString();
        }

    }
}
