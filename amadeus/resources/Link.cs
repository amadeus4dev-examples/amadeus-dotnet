using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Link object.
    /// </summary>
    public class Link
    {
        internal Link() { }

        /// <summary>
        /// Gets or sets the type of the href.
        /// </summary>
        /// <value>The type of the href.</value>
        public string href { get; set; }

        /// <summary>
        /// Gets or sets the type of the methods.
        /// </summary>
        /// <value>The type of the methods.</value>
        public List<string> methods { get; set; }

        /// <summary>
        /// Gets or sets the type of the rel.
        /// </summary>
        /// <value>The type of the rel.</value>
        public string rel { get; set; }
    }
}
