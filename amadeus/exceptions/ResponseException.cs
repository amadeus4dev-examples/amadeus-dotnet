using System;
using System.Diagnostics;

namespace amadeus.exceptions
{
    /// <summary>
    /// Response exception.
    /// </summary>
    public class ResponseException : Exception
    {

        private string code { get; set; }
        private Response response { get; set; }
        private string description { get; set; }

        /// <summary>
        /// Initializes a new instance of the ResponseException class.
        /// </summary>
        /// <param name="response">Response.</param>
        public ResponseException(Response response) : base(determineDescription(response))
        {
            this.response = response;
            this.description = determineDescription(response);
            determineCode();
        }

        /// <summary>
        /// Log the specified configuration.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        public void log(Configuration configuration)
        {
            if (configuration.logLevel == "debug")
            {
                string warning = "Amadeus " + code + " " + description;
                configuration.Logger.TraceEvent(TraceEventType.Warning, 0, warning);
            }
        }

        private void determineCode()
        {
            this.code = this.GetType().Name;
        }

        private static string determineDescription(Response response)
        {
            string description = determineShortDescription(response);
            description += determineLongDescription(response);
            return description;
        }

        private static string determineShortDescription(Response response)
        {
            string message = "";
            if (response == null || response.statusCode == 0)
            {
                message += "[---]";
            }
            else
            {
                message += "["+ response.statusCode + "]";
            }
            return message;
        }

        private static string determineLongDescription(Response response)
        {
            string description = "";
            if (response != null && response.parsed)
            {
                if (response.result.ContainsKey("error_description") && response.result.error_description != null)
                {
                    description += getErrorDescription(response);
                }
                if (response.result.ContainsKey("errors") && response.result.errors != null)
                {
                    description += getErrorsDescription(response);
                }
            }
            return description;
        }

        private static string getErrorDescription(Response response)
        {
            string message = "";
            if (response.result.ContainsKey("error") && response.result.error!=null)
            {
                message += "\n" + response.result.error;
            }
            message += "\n" + response.result.error_description;
            return message;
        }

        private static string getErrorsDescription(Response response)
        {
            string message = "";
            if (response.result.ContainsKey("errors") && response.result.errors != null)
            {
                dynamic[] errors = response.result.errors.ToObject<dynamic[]>();
                foreach (dynamic error in errors)
                {
                    message += "\n";
                    if (error.ContainsKey("source") && error.source.ContainsKey("parameter"))
                    {
                        message += "[" + error.source.parameter + "]";
                    }
                    if (error.ContainsKey("detail"))
                    {
                        message += error.detail;
                    }
                }
            }
            return message;
        }
    }
}
