using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DiseaseInfection object.
    /// </summary>
    public class DiseaseInfection
    {
        internal DiseaseInfection() { }

        /// <summary>
        /// Gets or sets the type of the date.
        /// </summary>
        /// <value>The type of the date.</value>
        public string date { get; set; }

        /// <summary>
        /// Gets or sets the type of the level.
        /// </summary>
        /// <value>The type of the level.</value>
        public string level { get; set; }

        /// <summary>
        /// Gets or sets the type of the rate.
        /// </summary>
        /// <value>The type of the rate.</value>
        public double rate { get; set; }

        /// <summary>
        /// Gets or sets the type of the infectionMapLink.
        /// </summary>
        /// <value>The type of the infectionMapLink.</value>
        public string infectionMapLink { get; set; }
    }
}
