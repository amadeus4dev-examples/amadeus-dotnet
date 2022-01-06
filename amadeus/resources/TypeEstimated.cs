using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An TypeEstimated object.
    /// </summary>
    public class TypeEstimated
    {
        internal TypeEstimated() { }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        public string category { get; set; }

        /// <summary>
        /// Gets or sets the beds.
        /// </summary>
        /// <value>The beds.</value>
        public string beds { get; set; }

        /// <summary>
        /// Gets or sets the bedType.
        /// </summary>
        /// <value>The bedType.</value>
        public string bedType { get; set; }
    }
}
