using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Border object.
    /// </summary>
    public class Border
    {
        internal Border() { }

        /// <summary>
        /// Gets or sets the type of the borderType.
        /// </summary>
        /// <value>The type of the borderType.</value>
        public string borderType { get; set; }

        /// <summary>
        /// Gets or sets the type of the status.
        /// </summary>
        /// <value>The type of the status.</value>
        public string status { get; set; }
    }
}
