using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An IssueSource object.
    /// </summary>
    public class IssueSource
    {
        internal IssueSource() { }

        /// <summary>
        /// Gets or sets the type of the pointer.
        /// </summary>
        /// <value>The type of the pointer.</value>
        public string pointer { get; set; }

        /// <summary>
        /// Gets or sets the type of the parameter.
        /// </summary>
        /// <value>The type of the parameter.</value>
        public string parameter { get; set; }

        /// <summary>
        /// Gets or sets the type of the example.
        /// </summary>
        /// <value>The type of the example.</value>
        public string example { get; set; }
    }
}
