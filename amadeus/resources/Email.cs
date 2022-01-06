namespace amadeus.resources
{
    /// <summary>
    /// An Email object.
    /// </summary>
    public class Email
    {
        internal Email() { }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public string category { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string address { get; set; }
    }
}
