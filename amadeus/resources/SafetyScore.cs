using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An SafetyScore object.
    /// </summary>
    public class SafetyScore
    {
        internal SafetyScore() { }

        /// <summary>
        /// Gets or sets the type of the women.
        /// </summary>
        /// <value>The type of the women.</value>
        public int women { get; set; }

        /// <summary>
        /// Gets or sets the type of the physicalHarm.
        /// </summary>
        /// <value>The type of the physicalHarm.</value>
        public int physicalHarm { get; set; }

        /// <summary>
        /// Gets or sets the type of the theft.
        /// </summary>
        /// <value>The type of the theft.</value>
        public int theft { get; set; }

        /// <summary>
        /// Gets or sets the type of the politicalFreedom.
        /// </summary>
        /// <value>The type of the politicalFreedom.</value>
        public int politicalFreedom { get; set; }

        /// <summary>
        /// Gets or sets the type of the lgbtq.
        /// </summary>
        /// <value>The type of the lgbtq.</value>
        public int lgbtq { get; set; }

        /// <summary>
        /// Gets or sets the type of the medical.
        /// </summary>
        /// <value>The type of the medical.</value>
        public int medical { get; set; }

        /// <summary>
        /// Gets or sets the type of the overall.
        /// </summary>
        /// <value>The type of the overall.</value>
        public int overall { get; set; }
    }
}
