namespace amadeus.resources
{
    /// <summary>
    /// An FlightDesignator object.
    /// </summary>
    public class FlightDesignator
    {
        internal FlightDesignator() { }

        /// <summary>
        /// Gets or sets the type of the carrierCode.
        /// </summary>
        /// <value>The type of the carrierCode.</value>
        public string carrierCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightNumber.
        /// </summary>
        /// <value>The type of the flightNumber.</value>
        public string flightNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the operationalSuffix.
        /// </summary>
        /// <value>The type of the operationalSuffix.</value>
        public string operationalSuffix { get; set; }
    }
}
