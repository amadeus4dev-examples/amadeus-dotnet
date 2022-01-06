namespace amadeus.resources
{
    /// <summary>
    /// An Name object.
    /// </summary>
    public class Name
    {
        internal Name() { }

        /// <summary>
        /// Gets or sets the firstName.
        /// </summary>
        /// <value>The firstName.</value>
        public string firstName { get; set; }

        /// <summary>
        /// Gets or sets the lastName.
        /// </summary>
        /// <value>The lastName.</value>
        public string lastName { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the middleName.
        /// </summary>
        /// <value>The middleName.</value>
        public string middleName { get; set; }

        /// <summary>
        /// Gets or sets the prefix.
        /// </summary>
        /// <value>The prefix.</value>
        public string prefix { get; set; }

        /// <summary>
        /// Gets or sets the suffix.
        /// </summary>
        /// <value>The suffix.</value>
        public string suffix { get; set; }
    }
}
