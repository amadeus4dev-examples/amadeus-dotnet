using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AreaRestriction object.
    /// </summary>
    public class AreaRestriction
    {
        internal AreaRestriction() { }

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
        /// Gets or sets the type of the restrictionType.
        /// </summary>
        /// <value>The type of the restrictionType.</value>
        public string restrictionType { get; set; }

        /// <summary>
        /// Gets or sets the type of the title.
        /// </summary>
        /// <value>The type of the title.</value>
        public string title { get; set; }
    }
}
