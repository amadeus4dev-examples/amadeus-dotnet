using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An QualifiedFreeText object.
    /// </summary>
    public class QualifiedFreeText
    {
        internal QualifiedFreeText() { }

        /// <summary>
        /// Gets or sets the type of the text.
        /// </summary>
        /// <value>The type of the text.</value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the type of the lang.
        /// </summary>
        /// <value>The type of the lang.</value>
        public string lang { get; set; }
    }
}
