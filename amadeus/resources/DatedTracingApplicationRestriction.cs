using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DatedTracingApplicationRestriction object.
    /// </summary>
    public class DatedTracingApplicationRestriction
    {
        internal DatedTracingApplicationRestriction() { }

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
        /// Gets or sets the type of the isRequired.
        /// </summary>
        /// <value>The type of the isRequired.</value>
        public string isRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the iosUrl.
        /// </summary>
        /// <value>The type of the iosUrl.</value>
        public List<string> iosUrl { get; set; }

        /// <summary>
        /// Gets or sets the type of the androidUrl.
        /// </summary>
        /// <value>The type of the androidUrl.</value>
        public List<string> androidUrl { get; set; }

        /// <summary>
        /// Gets or sets the type of the website.
        /// </summary>
        /// <value>The type of the website.</value>
        public string website { get; set; }
    }
}
