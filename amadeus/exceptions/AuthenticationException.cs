using System;
namespace amadeus.exceptions
{
    /// <summary>
    /// Authentication exception.
    /// </summary>
    public class AuthenticationException : ResponseException
    {
        /// <summary>
        /// Initializes a new instance of the AuthenticationException class.
        /// </summary>
        /// <param name="response">Response.</param>
        public AuthenticationException(Response response) : base(response)
        {

        }
    }
}
