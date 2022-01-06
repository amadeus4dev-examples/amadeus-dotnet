namespace amadeus.resources
{
    /// <summary>
    /// An Trip object.
    /// </summary>
    public class Trip
    {
        internal Trip() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the type of the reference.
        /// </summary>
        /// <value>The type of the reference.</value>
        public string reference { get; set; }

        /// <summary>
        /// Gets or sets the type of the creationDateTime.
        /// </summary>
        /// <value>The type of the creationDateTime.</value>
        public string creationDateTime { get; set; }

        /// <summary>
        /// Gets or sets the type of the bookingDate.
        /// </summary>
        /// <value>The type of the bookingDate.</value>
        public string bookingDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the bookingNumber.
        /// </summary>
        /// <value>The type of the bookingNumber.</value>
        public string bookingNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the provider.
        /// </summary>
        /// <value>The type of the provider.</value>
        public string provider { get; set; }

        /// <summary>
        /// Gets or sets the type of the title.
        /// </summary>
        /// <value>The type of the title.</value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the type of the description.
        /// </summary>
        /// <value>The type of the description.</value>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the type of the start.
        /// </summary>
        /// <value>The type of the start.</value>
        public StartEnd start { get; set; }

        /// <summary>
        /// Gets or sets the type of the end.
        /// </summary>
        /// <value>The type of the end.</value>
        public StartEnd end { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelAgency.
        /// </summary>
        /// <value>The type of the travelAgency.</value>
        public TravelAgency travelAgency { get; set; }

        /// <summary>
        /// Gets or sets the type of the stakeholders.
        /// </summary>
        /// <value>The type of the stakeholders.</value>
        public Stakeholder[] stakeholders { get; set; }

        /// <summary>
        /// Gets or sets the type of the price.
        /// </summary>
        /// <value>The type of the price.</value>
        public Price price { get; set; }

        /// <summary>
        /// Gets or sets the type of the products.
        /// </summary>
        /// <value>The type of the products.</value>
        public Product[] products { get; set; }
    }
}
