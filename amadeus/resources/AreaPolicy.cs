using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AreaPolicy object.
    /// </summary>
    public class AreaPolicy
    {
        internal AreaPolicy() { }

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
        /// Gets or sets the type of the status.
        /// </summary>
        /// <value>The type of the status.</value>
        public string status { get; set; }


        /// <summary>
        /// Gets or sets the type of the startDate.
        /// </summary>
        /// <value>The type of the startDate.</value>
        public string startDate { get; set; }


        /// <summary>
        /// Gets or sets the type of the endDate.
        /// </summary>
        /// <value>The type of the endDate.</value>
        public string endDate { get; set; }


        /// <summary>
        /// Gets or sets the type of the referenceLink.
        /// </summary>
        /// <value>The type of the referenceLink.</value>
        public string referenceLink { get; set; }

    }
}
