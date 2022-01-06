using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Period object as returned by the Prediction APIs.
    /// </summary>
    public class Prediction : Resource
    {
        internal Prediction() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the type of the sub.
        /// </summary>
        /// <value>The type of the sub.</value>
        public string subType { get; set; }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type of the result.
        /// </summary>
        /// <value>The type of the result.</value>
        public string result { get; set; }

        /// <summary>
        /// Gets or sets the type of the probability.
        /// </summary>
        /// <value>The type of the probability.</value>
        public string probability { get; set; }
    }
}
