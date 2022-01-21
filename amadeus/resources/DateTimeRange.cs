using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DateTimeRange object.
    /// </summary>
    public class DateTimeRange
    {
        public DateTimeRange() { }

        /// <summary>
        /// Gets or sets the type of the date.
        /// </summary>
        /// <value>The type of the date.</value>
        public string date { get; set; }

        /// <summary>
        /// Gets or sets the type of the dateWindow.
        /// </summary>
        /// <value>The type of the dateWindow.</value>
        public string dateWindow { get; set; }

        /// <summary>
        /// Gets or sets the type of the time.
        /// </summary>
        /// <value>The type of the time.</value>
        public string time { get; set; }

        /// <summary>
        /// Gets or sets the type of the timeWindow.
        /// </summary>
        /// <value>The type of the timeWindow.</value>
        public string timeWindow { get; set; }
    }
}
