using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An ValidityPeriod object.
    /// </summary>
    public class ValidityPeriod
    {
        internal ValidityPeriod() { }

        /// <summary>
        /// Gets or sets the type of the delay .
        /// </summary>
        /// <value>The type of the delay .</value>
        public string delay { get; set; }

        /// <summary>
        /// Gets or sets the type of the referenceDateType.
        /// </summary>
        /// <value>The type of the referenceDateType.</value>
        public string referenceDateType { get; set; }
    }
}
