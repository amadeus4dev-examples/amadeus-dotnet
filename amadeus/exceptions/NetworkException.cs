using System;
using amadeus;
using amadeus.exceptions;

namespace resources.exceptions
{
    /// <summary>
    /// Network exception.
    /// </summary>
    public class NetworkException : ResponseException
    {
        /// <summary>
        /// Initializes a new instance of the NetworkException class.
        /// </summary>
        /// <param name="response">Response.</param>
        public NetworkException(Response response) : base(response)
        {

        }
    }
}
