namespace amadeus.resources
{
    /// <summary>
    /// An Stakeholder object.
    /// </summary>
    public class Stakeholder
    {
        internal Stakeholder() { }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the nationality.
        /// </summary>
        /// <value>The nationality.</value>
        public string nationality { get; set; }

        /// <summary>
        /// Gets or sets the passangerTypeCode.
        /// </summary>
        /// <value>The passangerTypeCode.</value>
        public string passangerTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the dateOfBirth.
        /// </summary>
        /// <value>The dateOfBirth.</value>
        public string dateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>The age.</value>
        public int age { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public Name name { get; set; }
    }
}
