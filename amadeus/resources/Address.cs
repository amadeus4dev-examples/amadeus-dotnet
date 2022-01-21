using System.Collections.Generic;

namespace amadeus.resources
{
    /// <summary>
    /// An Address object.
    /// </summary>
    public class Address
    {
        internal Address() { }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public string category { get; set; }

        /// <summary>
        /// Gets or sets the lines.
        /// </summary>
        /// <value>The lines.</value>
        public List<string> lines { get; set; }

        /// <summary>
        /// Gets or sets the postalCode.
        /// </summary>
        /// <value>The postalCode.</value>
        public string postalCode { get; set; }

        /// <summary>
        /// Gets or sets the countryCode.
        /// </summary>
        /// <value>The countryCode.</value>
        public string countryCode { get; set; }

        /// <summary>
        /// Gets or sets the cityName.
        /// </summary>
        /// <value>The cityName.</value>
        public string cityName { get; set; }

        /// <summary>
        /// Gets or sets the stateCode.
        /// </summary>
        /// <value>The stateCode.</value>
        public string stateCode { get; set; }

        /// <summary>
        /// Gets or sets the postalBox.
        /// </summary>
        /// <value>The postalBox.</value>
        public string postalBox { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string state { get; set; }

        /// <summary>
        /// Gets or sets the stateName.
        /// </summary>
        /// <value>The stateName.</value>
        public string stateName { get; set; }
    }
}
