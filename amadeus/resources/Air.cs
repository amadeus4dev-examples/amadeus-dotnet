using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Air object.
    /// </summary>
    public class Air
    {
        internal Air() { }

        /// <summary>
        /// Gets or sets the type of the confirmationNumber.
        /// </summary>
        /// <value>The type of the confirmationNumber.</value>
        public string confirmationNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the baggages.
        /// </summary>
        /// <value>The type of the baggages.</value>
        public Baggage baggages { get; set; }

        /// <summary>
        /// Gets or sets the type of the meal.
        /// </summary>
        /// <value>The type of the meal.</value>
        public Meal meal { get; set; }

        /// <summary>
        /// Gets or sets the type of the departureAirportLocation.
        /// </summary>
        /// <value>The type of the departureAirportLocation.</value>
        public DepartureArrivalAirportLocation departureAirportLocation { get; set; }

        /// <summary>
        /// Gets or sets the type of the arrivalAirportLocation.
        /// </summary>
        /// <value>The type of the arrivalAirportLocation.</value>
        public DepartureArrivalAirportLocation arrivalAirportLocation { get; set; }

        /// <summary>
        /// Gets or sets the type of the departure.
        /// </summary>
        /// <value>The type of the departure.</value>
        public DepartureAir departure { get; set; }

        /// <summary>
        /// Gets or sets the type of the arrival.
        /// </summary>
        /// <value>The type of the arrival.</value>
        public ArrivalAir arrival { get; set; }

        /// <summary>
        /// Gets or sets the type of the marketing.
        /// </summary>
        /// <value>The type of the marketing.</value>
        public MarketingOperating marketing { get; set; }

        /// <summary>
        /// Gets or sets the type of the operating.
        /// </summary>
        /// <value>The type of the operating.</value>
        public MarketingOperating operating { get; set; }

        /// <summary>
        /// Gets or sets the type of the aircraft.
        /// </summary>
        /// <value>The type of the aircraft.</value>
        public Aircraft aircraft { get; set; }

        /// <summary>
        /// Gets or sets the type of the seats.
        /// </summary>
        /// <value>The type of the seats.</value>
        public Seat[] seats { get; set; }
    }
}
