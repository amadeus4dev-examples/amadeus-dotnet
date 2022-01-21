using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DetailedFareRules object.
    /// </summary>
    public class DetailedFareRules
    {
        internal DetailedFareRules() { }

        /// <summary>
        /// Gets or sets the type of the fareBasis.
        /// </summary>
        /// <value>The type of the fareBasis.</value>
        public string fareBasis { get; set; }

        /// <summary>
        /// Gets or sets the type of the name.
        /// </summary>
        /// <value>The type of the name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the type of the fareNotes.
        /// </summary>
        /// <value>The type of the fareNotes.</value>
        public TermAndCondition fareNotes { get; set; }

        /// <summary>
        /// Gets or sets the type of the segmentId.
        /// </summary>
        /// <value>The type of the segmentId.</value>
        public int segmentId { get; set; }
    }
}
