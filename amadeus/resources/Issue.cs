using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Issue object.
    /// </summary>
    public class Issue
    {
        internal Issue() { }

        /// <summary>
        /// Gets or sets the type of the status.
        /// </summary>
        /// <value>The type of the status.</value>
        public int status { get; set; }

        /// <summary>
        /// Gets or sets the type of the code.
        /// </summary>
        /// <value>The type of the code.</value>
        public int code { get; set; }

        /// <summary>
        /// Gets or sets the type of the title.
        /// </summary>
        /// <value>The type of the title.</value>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the type of the doors.
        /// </summary>
        /// <value>The type of the doors.</value>
        public string detail { get; set; }

        /// <summary>
        /// Gets or sets the type of the doors.
        /// </summary>
        /// <value>The type of the doors.</value>
        public IssueSource source { get; set; }
    }
}
