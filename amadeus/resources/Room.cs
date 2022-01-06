using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Room object.
    /// </summary>
    public class Room
    {
        internal Room() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the typeEstimated.
        /// </summary>
        /// <value>The typeEstimated.</value>
        public TypeEstimated typeEstimated { get; set; }
    }
}
