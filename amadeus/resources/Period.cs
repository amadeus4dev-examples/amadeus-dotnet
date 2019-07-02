using System;
using amadeus.resources;
using amadeus.travel.analytics.airTraffic;

namespace amadeus.resources
{

    /// <summary>
    /// An Period object as returned by the BusiestPeriod API.
    /// <see cref="BusiestPeriod.get()"/>
    /// </summary>
    public class Period : Resource
    {

        internal Period() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the period.
        /// </summary>
        /// <value>The period.</value>
        public string period { get; set; }

        /// <summary>
        /// Gets or sets the analytics.
        /// </summary>
        /// <value>The analytics.</value>
        public Analytics analytics { get; set; }

        /// <summary>
        /// An Period-related object as returned by the BusiestPeriod API.
        /// <see cref="BusiestPeriod.get()"/>
        /// </summary>
        public class Analytics
        {

            internal Analytics() { }

            /// <summary>
            /// Gets or sets the travelers.
            /// </summary>
            /// <value>The travelers.</value>
            public Travelers travelers { get; set; }

        }

        /// <summary>
        /// An Period-related object as returned by the BusiestPeriod API.
        /// <see cref="BusiestPeriod.get()"/>
        /// </summary>
        public class Travelers
        {

            internal Travelers() { }

            /// <summary>
            /// Gets or sets the score.
            /// </summary>
            /// <value>The score.</value>
            public double score { get; set; }

        }

    }

}
