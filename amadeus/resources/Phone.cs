namespace amadeus.resources
{
    /// <summary>
    /// An Phone object.
    /// </summary>
    public class Phone
    {
        internal Phone() { }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public string category { get; set; }

        /// <summary>
        /// Gets or sets the countryCode.
        /// </summary>
        /// <value>The countryCode.</value>
        public string countryCode { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        public string number { get; set; }
    }
}
