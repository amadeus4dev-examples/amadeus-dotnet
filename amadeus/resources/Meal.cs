using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Meal object.
    /// </summary>
    public class Meal
    {
        internal Meal() { }

        /// <summary>
        /// Gets or sets the type of the code.
        /// </summary>
        /// <value>The type of the code.</value>
        public string code { get; set; }

        /// <summary>
        /// Gets or sets the type of the description.
        /// </summary>
        /// <value>The type of the description.</value>
        public string description { get; set; }
    }
}
