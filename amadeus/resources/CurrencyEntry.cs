using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An CurrencyEntry object.
    /// </summary>
    public class CurrencyEntry
    {
        internal CurrencyEntry() { }

        /// <summary>
        /// Gets or sets the type of the key.
        /// </summary>
        /// <value>The type of the key.</value>
        public string key { get; set; }

        /// <summary>
        /// Gets or sets the type of the code.
        /// </summary>
        /// <value>The type of the code.</value>
        public string code { get; set; }

    }
}
