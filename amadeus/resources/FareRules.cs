using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FareRules object.
    /// </summary>
    public class FareRules
    {
        internal FareRules() { }

        /// <summary>
        /// Gets or sets the type of the currency.
        /// </summary>
        /// <value>The type of the currency.</value>
        public string currency { get; set; }

        /// <summary>
        /// Gets or sets the type of the rules.
        /// </summary>
        /// <value>The type of the rules.</value>
        public List<TermAndCondition> rules { get; set; }
    }
}
