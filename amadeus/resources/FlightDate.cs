using System;
using amadeus.resources;
using amadeus.shopping;

namespace amadeus.resources
{

    /// <summary>
    /// An FlightDate object as returned by the FlightDates API.
    /// <see cref="FlightDates.get()"/>
    /// </summary>
    public class FlightDate : Resource
    {

        internal FlightDate() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        /// <value>The origin.</value>
        public string origin { get; set; }

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>The destination.</value>
        public string destination { get; set; }

        /// <summary>
        /// Gets or sets the departure date.
        /// </summary>
        /// <value>The departure date.</value>
        public DateTime departureDate { get; set; }

        /// <summary>
        /// Gets or sets the return date.
        /// </summary>
        /// <value>The return date.</value>
        public DateTime returnDate { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public Price price { get; set; }

        /// <summary>
        /// An FlightDate-related object as returned by the FlightDates API.
        /// <see cref="FlightDates.get()"/>
        /// </summary>
        public class Price
        {

            internal Price() { }

            /// <summary>
            /// Gets or sets the total.
            /// </summary>
            /// <value>The total.</value>
            public double total { get; set; }

        }

    }

}