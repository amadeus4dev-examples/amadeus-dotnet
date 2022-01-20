using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An TicketingAgreement object.
    /// </summary>
    public class TicketingAgreement
    {
        internal TicketingAgreement() { }

        /// <summary>
        /// Gets or sets the type of the option.
        /// </summary>
        /// <value>The type of the option.</value>
        public string option { get; set; }

        /// <summary>
        /// Gets or sets the type of the delay.
        /// </summary>
        /// <value>The type of the delay.</value>
        public string delay { get; set; }

        /// <summary>
        /// Gets or sets the type of the dateTime.
        /// </summary>
        /// <value>The type of the dateTime.</value>
        public string dateTime { get; set; }

        /// <summary>
        /// Gets or sets the type of the dateTime.
        /// </summary>
        /// <value>The type of the dateTime.</value>
        public List<string> segmentIds { get; set; }
    }
}
