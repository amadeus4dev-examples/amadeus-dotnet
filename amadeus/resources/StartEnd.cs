namespace amadeus.resources
{
    /// <summary>
    /// An StartEnd object.
    /// </summary>
    public class StartEnd
    {
        internal StartEnd() { }

        /// <summary>
        /// Gets or sets the localDateTime.
        /// </summary>
        /// <value>The localDateTime.</value>
        public string localDateTime { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the iataCode.
        /// </summary>
        /// <value>The iataCode.</value>
        public string iataCode { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public Address address { get; set; }
    }
}
