using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Transportation object.
    /// </summary>
    public class Transportation
    {
        internal Transportation() { }

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
        /// Gets or sets the type of the transportationType.
        /// </summary>
        /// <value>The type of the transportationType.</value>
        public string transportationType { get; set; }

        /// <summary>
        /// Gets or sets the type of the isBanned.
        /// </summary>
        /// <value>The type of the isBanned.</value>
        public string isBanned { get; set; }

        /// <summary>
        /// Gets or sets the type of the throughDate.
        /// </summary>
        /// <value>The type of the throughDate.</value>
        public string throughDate { get; set; }
    }
}
