using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AutomatedProcess object.
    /// </summary>
    public class AutomatedProcess
    {
        internal AutomatedProcess() { }

        /// <summary>
        /// Gets or sets the type of the code.
        /// </summary>
        /// <value>The type of the code.</value>
        public string code { get; set; }

        /// <summary>
        /// Gets or sets the type of the queue.
        /// </summary>
        /// <value>The type of the queue.</value>
        public ProcessQueue queue { get; set; }

        /// <summary>
        /// Gets or sets the type of the text.
        /// </summary>
        /// <value>The type of the text.</value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the type of the delay.
        /// </summary>
        /// <value>The type of the delay.</value>
        public string delay { get; set; }

        /// <summary>
        /// Gets or sets the type of the officeId.
        /// </summary>
        /// <value>The type of the officeId.</value>
        public string officeId { get; set; }

        /// <summary>
        /// Gets or sets the type of the dateTime.
        /// </summary>
        /// <value>The type of the dateTime.</value>
        public string dateTime { get; set; }
    }
}
