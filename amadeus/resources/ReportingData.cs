using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An ReportingData object.
    /// </summary>
    public class ReportingData
    {
        internal ReportingData() { }

        /// <summary>
        /// Gets or sets the type of the name.
        /// </summary>
        /// <value>The type of the name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the type of the value.
        /// </summary>
        /// <value>The type of the value.</value>
        public string value { get; set; }
    }
}
