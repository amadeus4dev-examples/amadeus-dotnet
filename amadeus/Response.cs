using System;
using System.IO;
using System.Net;
using System.Text;
using amadeus.exceptions;
using amadeus.util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using resources;

namespace amadeus
{

    /// <summary>
    /// The Response Object of API call.
    /// </summary>
    public class Response
    {

        /// <summary>
        /// Initializes a new instance of the Response class.
        /// </summary>
        public Response()
        {

        }

        /// <summary>
        /// The HTTP status code for the response, if any.
        /// </summary>
        /// <value>The status code.</value>
        public int statusCode { get; set; }

        /// <summary>
        /// Wether the raw body has been parsed into JSON.
        /// </summary>
        /// <value><c>true</c> if parsed; otherwise, <c>false</c>.</value>
        public virtual bool parsed { get; set; }

        /// <summary>
        /// The parsed JSON received from the API, if the result was JSON.
        /// </summary>
        /// <value>The parsed JSON received from the API</value>
        public dynamic result { get; set; }

        /// <summary>
        /// The data extracted from the JSON data - if the body contained JSON.
        /// </summary>
        /// <value>The data.</value>
        public virtual dynamic data { get; set; }

        /// <summary>
        /// Gets or sets the data string.
        /// </summary>
        /// <value>The data string.</value>
        public virtual dynamic dataString { get; set; }

        /// <summary>
        /// The raw body received from the API.
        /// </summary>
        /// <value>The body.</value>
        public string body { get; set; }

        /// <summary>
        /// The actual Request object used to make this API call.
        /// </summary>
        /// <value>The request.</value>
        internal Request request { get; set; }

        private HttpWebResponse response;

        /// <summary>
        /// Initializes a new instance of the Response class.
        /// </summary>
        /// <param name="request">Request.</param>
        public Response(Request request)
        {
            this.request = request;
        }

        // Tries to parse the raw response from the request.
        internal void parse()
        {
            load();
            parseStatusCode();
            parseData();
        }

        // Detects of any exceptions have occured and throws the appropriate exceptions.
        internal void detectError()
        {
            ResponseException exception = null;
            if (statusCode >= 500) {
              exception = new ServerException(this);
            } else if (statusCode == 404) {
              exception = new NotFoundException(this);
            } else if (statusCode == 401) {
              exception = new AuthenticationException(this);
            } else if (statusCode >= 400) {
              exception = new ClientException(this);
            } else if (!parsed) {
              exception = new ParserException(this);
            }

            if (exception != null)
            {
                throw exception;
            }
        }

        private void load()
        {
            try
            {
                response = (HttpWebResponse)request.connection.GetResponseWithoutException();
            }
            catch (Exception)
            {
            }
        }

        // Tries to parse the status code. Catches any exceptions and defaults to
        // status 0 if an error occurred.
        internal void parseStatusCode()
        {
            try
            {
                HttpStatusCode code = response.StatusCode;
                this.statusCode = (int) code;
            }
            catch (Exception)
            {
                this.statusCode = 0;
            }
        }

        // Tries to parse the data
        internal void parseData()
        {
            this.parsed = false;
            this.body = readBody();
            this.result = parseJson();

            this.parsed = this.result != null;
            if (parsed && result.ContainsKey("data")!=null && result.GetValue("data")!=null)
            {
                if (result.GetValue("data").GetType() == typeof(JArray))
                {
                    this.data = result.GetValue("data");
                    this.dataString = result.GetValue("data").ToString(Formatting.None);
                }
                if (result.GetValue("data").GetType() == typeof(JObject))
                {
                    this.data = result.GetValue("data");
                    this.dataString = result.GetValue("data").ToString(Formatting.None);
                }
            }
        }

        // Tries to read the body.
        internal string readBody()
        {
            try
            {
                var reader = new StreamReader(response.GetResponseStream());
                return reader.ReadToEnd();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Ties to parse the response body into a JSON Object
        internal dynamic parseJson()
        {
            try
            {
                dynamic jsonResponse = JsonConvert.DeserializeObject(body);
                return jsonResponse;
            } catch (Exception)
            {
            }
            return null;
        }

        // Checks if the response is likely to be JSON.
        internal bool isJson()
        {
            return hasJsonHeader() && hasBody();
        }

        // Checks if the response headers include a JSON mime-type.
        internal bool hasJsonHeader()
        {
            string contentType = response.Headers[Constants.CONTENT_TYPE];
            string[] expectedContentTypes = new string[] {
                "application/json", "application/vnd.amadeus+json"
            };
            return Array.IndexOf(expectedContentTypes, contentType) >= 0;
        }

        // Checks if the response has a body
        internal bool hasBody()
        {
            return !(string.IsNullOrEmpty(body));
        }

    }
}
