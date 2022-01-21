using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AutomatedProcessCommon object.
    /// </summary>
    public class AutomatedProcessCommon
    {
        internal AutomatedProcessCommon() { }

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
        public int text { get; set; }
    }
}
