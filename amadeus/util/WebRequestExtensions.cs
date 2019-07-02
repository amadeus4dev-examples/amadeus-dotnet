using System;
using System.Net;

namespace amadeus.util
{
    /// <summary>
    /// Web request extensions.
    /// </summary>
    public static class WebRequestExtensions
    {
        /// <summary>
        /// Gets the response without exception.
        /// </summary>
        /// <returns>The response without exception.</returns>
        /// <param name="request">Request.</param>
        public static WebResponse GetResponseWithoutException(this WebRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            try
            {
                return request.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Response == null)
                {
                    throw;
                }

                return e.Response;
            }
        }
    }
}
