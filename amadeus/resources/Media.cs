using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Media object.
    /// </summary>
    public class Media
    {
        internal Media() { }

        /// <summary>
        /// Gets or sets the type of the title.
        /// </summary>
        /// <value>The type of the title.</value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the type of the href.
        /// </summary>
        /// <value>The type of the href.</value>
        public string href { get; set; }

        /// <summary>
        /// Gets or sets the type of the description.
        /// </summary>
        /// <value>The type of the description.</value>
        public QualifiedFreeText description { get; set; }

        /// <summary>
        /// Gets or sets the type of the mediaType.
        /// </summary>
        /// <value>The type of the mediaType.</value>
        public int mediaType { get; set; }
    }
}
