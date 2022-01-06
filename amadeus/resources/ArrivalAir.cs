namespace amadeus.resources
{
    /// <summary>
    /// An ArrivalAir object.
    /// </summary>
    public class ArrivalAir
    {
        internal ArrivalAir() { }

        /// <summary>
        /// Gets or sets the type of the iataCode.
        /// </summary>
        /// <value>The type of the iataCode.</value>
        public string iataCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the terminal.
        /// </summary>
        /// <value>The type of the terminal.</value>
        public string terminal { get; set; }

        /// <summary>
        /// Gets or sets the type of the localDateTime.
        /// </summary>
        /// <value>The type of the localDateTime.</value>
        public string localDateTime { get; set; }
    }
}
