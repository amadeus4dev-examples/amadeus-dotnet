using System;
namespace amadeus.exceptions
{
    /// <summary>
    /// Not found exception.
    /// </summary>
    public class NotFoundException : ResponseException
    {
        /// <summary>
        /// Initializes a new instance of the NotFoundException class.
        /// </summary>
        /// <param name="response">Response.</param>
        public NotFoundException(Response response) : base(response)
        {

        }
    }
}
