using System;
using amadeus.resources;
using amadeus.travel.analytics.airTraffic;

namespace amadeus.resources
{

    /// <summary>
    /// An Search object as returned by the Searched API.
    /// <see cref="Searched.get()"/>
    /// </summary>
    public class Search : Resource
    {

        internal Search() { }

        /// <summary>
        /// Gets or sets the type of the sub.
        /// </summary>
        /// <value>The type of the sub.</value>
        public string subType { get; set; }

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>The destination.</value>
        public string destination { get; set; }

        /// <summary>
        /// Gets or sets the analytics.
        /// </summary>
        /// <value>The analytics.</value>
        public Analytics analytics { get; set; }

        /// <summary>
        /// An Search-related object as returned by the Searched API.
        /// <see cref="Searched.get()"/>
        /// </summary>
        public class Analytics
        {

            internal Analytics() { }

            /// <summary>
            /// Gets or sets the searches.
            /// </summary>
            /// <value>The searches.</value>
            public Searches searches { get; set; }

        }

        /// <summary>
        /// An Search-related object as returned by the Searched API.
        /// <see cref="Searched.get()"/>
        /// </summary>
        public class Searches
        {

            internal Searches() { }

            /// <summary>
            /// Gets or sets the score.
            /// </summary>
            /// <value>The score.</value>
            public double score { get; set; }

        }

    }

}
