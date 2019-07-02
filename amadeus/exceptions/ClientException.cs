using System;
namespace amadeus.exceptions
{
    /// <summary>
    /// Client exception.
    /// </summary>
    public class ClientException : ResponseException
    {
        /// <summary>
        /// Initializes a new instance of the ClientException class.
        /// </summary>
        /// <param name="response">Response.</param>
        public ClientException(Response response) : base(response)
        {

        }
    }
}
