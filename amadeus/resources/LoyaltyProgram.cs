using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An LoyaltyProgram object.
    /// </summary>
    public class LoyaltyProgram
    {
        internal LoyaltyProgram() { }

        /// <summary>
        /// Gets or sets the type of the programOwner.
        /// </summary>
        /// <value>The type of the programOwner.</value>
        public string programOwner { get; set; }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }
    }
}
