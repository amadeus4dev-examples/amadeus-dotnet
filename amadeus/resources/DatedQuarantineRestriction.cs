using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DatedQuarantineRestriction object.
    /// </summary>
    public class DatedQuarantineRestriction
    {
        internal DatedQuarantineRestriction() { }

        /// <summary>
        /// Gets or sets the type of the date.
        /// </summary>
        /// <value>The type of the date.</value>
        public string date { get; set; }

        /// <summary>
        /// Gets or sets the type of the text.
        /// </summary>
        /// <value>The type of the text.</value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the type of the eligiblePerson.
        /// </summary>
        /// <value>The type of the eligiblePerson.</value>
        public string eligiblePerson { get; set; }

        /// <summary>
        /// Gets or sets the type of the quarantineType.
        /// </summary>
        /// <value>The type of the quarantineType.</value>
        public string quarantineType { get; set; }

        /// <summary>
        /// Gets or sets the type of the duration.
        /// </summary>
        /// <value>The type of the duration.</value>
        public int duration { get; set; }

        /// <summary>
        /// Gets or sets the type of the rules.
        /// </summary>
        /// <value>The type of the rules.</value>
        public string rules { get; set; }

        /// <summary>
        /// Gets or sets the type of the mandateList.
        /// </summary>
        /// <value>The type of the mandateList.</value>
        public string mandateList { get; set; }

        /// <summary>
        /// Gets or sets the type of the quarantineOnArrivalAreas.
        /// </summary>
        /// <value>The type of the quarantineOnArrivalAreas.</value>
        public List<Area> quarantineOnArrivalAreas { get; set; }
    }
}
