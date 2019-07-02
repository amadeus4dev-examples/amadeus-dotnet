using System;
namespace amadeus.exceptions
{
    /// <summary>
    /// Server exception.
    /// </summary>
    public class ServerException : ResponseException
    {
        /// <summary>
        /// Initializes a new instance of the ServerException class.
        /// </summary>
        /// <param name="response">Response.</param>
        public ServerException(Response response) : base(response)
        {

        }
    }
}
