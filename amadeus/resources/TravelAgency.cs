namespace amadeus.resources
{
    /// <summary>
    /// An TravelAgency object.
    /// </summary>
    public class TravelAgency
    {
        internal TravelAgency() { }

        /// <summary>
        /// Gets or sets the officeName.
        /// </summary>
        /// <value>The officeName.</value>
        public string officeName { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public Address address { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>The phone.</value>
        public Phone phone { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>The email.</value>
        public Email email { get; set; }
    }
}
