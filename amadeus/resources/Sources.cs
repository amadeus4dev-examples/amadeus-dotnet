using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Sources object.
    /// </summary>
    public class Sources
    {
        internal Sources() { }

        /// <summary>
        /// Gets or sets the type of the covidDashboardLink.
        /// </summary>
        /// <value>The type of the covidDashboardLink.</value>
        public string covidDashboardLink { get; set; }

        /// <summary>
        /// Gets or sets the type of the healthDepartementSiteLink.
        /// </summary>
        /// <value>The type of the healthDepartementSiteLink.</value>
        public string healthDepartementSiteLink { get; set; }

        /// <summary>
        /// Gets or sets the type of the governmentSiteLink.
        /// </summary>
        /// <value>The type of the governmentSiteLink.</value>
        public string governmentSiteLink { get; set; }
    }
}
