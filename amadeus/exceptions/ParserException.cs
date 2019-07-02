using System;
namespace amadeus.exceptions
{
    /// <summary>
    /// Parser exception.
    /// </summary>
    public class ParserException : ResponseException
    {
        /// <summary>
        /// Initializes a new instance of the ParserException class.
        /// </summary>
        /// <param name="response">Response.</param>
        public ParserException(Response response) : base(response)
        {

        }
    }
}
