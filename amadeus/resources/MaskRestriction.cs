using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An MaskRestriction object.
    /// </summary>
    public class MaskRestriction
    {
        internal MaskRestriction() { }

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
        /// Gets or sets the type of the isRequired.
        /// </summary>
        /// <value>The type of the isRequired.</value>
        public string isRequired { get; set; }
    }
}
