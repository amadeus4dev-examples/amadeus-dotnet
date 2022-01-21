using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Tax object.
    /// </summary>
    public class Tax
    {
        internal Tax() { }

        /// <summary>
        /// Gets or sets the type of the amount.
        /// </summary>
        /// <value>The type of the amount.</value>
        public string amount { get; set; }

        /// <summary>
        /// Gets or sets the type of the code.
        /// </summary>
        /// <value>The type of the code.</value>
        public string code { get; set; }

    }
}
