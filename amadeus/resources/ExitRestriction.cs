using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An ExitRestriction object.
    /// </summary>
    public class ExitRestriction
    {
        internal ExitRestriction() { }

        /// <summary>
        /// Gets or sets the type of the date.
        /// </summary>
        /// <value>The type of the date.</value>
        public string date { get; set; }

        /// <summary>
        /// Gets or sets the type of the text.
        /// </summary>
        /// <value>The type of the text.</value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the type of the specialRequirements.
        /// </summary>
        /// <value>The type of the specialRequirements.</value>
        public string specialRequirements { get; set; }

        /// <summary>
        /// Gets or sets the type of the rulesLink.
        /// </summary>
        /// <value>The type of the rulesLink.</value>
        public string rulesLink { get; set; }

        /// <summary>
        /// Gets or sets the type of the isBanned.
        /// </summary>
        /// <value>The type of the isBanned.</value>
        public string isBanned { get; set; }
    }
}
