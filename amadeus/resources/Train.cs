using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Train object.
    /// </summary>
    public class Train
    {
        internal Train() { }

        /// <summary>
        /// Gets or sets the type of the confirmNbr.
        /// </summary>
        /// <value>The type of the confirmNbr.</value>
        public string confirmNbr { get; set; }

        /// <summary>
        /// Gets or sets the type of the serviceProviderName.
        /// </summary>
        /// <value>The type of the serviceProviderName.</value>
        public string serviceProviderName { get; set; }

        /// <summary>
        /// Gets or sets the type of the bookingClass.
        /// </summary>
        /// <value>The type of the bookingClass.</value>
        public string bookingClass { get; set; }

        /// <summary>
        /// Gets or sets the type of the departure.
        /// </summary>
        /// <value>The type of the departure.</value>
        public DepartureArrival departure { get; set; }

        /// <summary>
        /// Gets or sets the type of the departureDateTime.
        /// </summary>
        /// <value>The type of the departureDateTime.</value>
        public string departureDateTime { get; set; }

        /// <summary>
        /// Gets or sets the type of the arrivalDateTime.
        /// </summary>
        /// <value>The type of the arrivalDateTime.</value>
        public string arrivalDateTime { get; set; }

        /// <summary>
        /// Gets or sets the type of the arrival.
        /// </summary>
        /// <value>The type of the arrival.</value>
        public DepartureArrival arrival { get; set; }

        /// <summary>
        /// Gets or sets the type of the duration.
        /// </summary>
        /// <value>The type of the duration.</value>
        public string duration { get; set; }

        /// <summary>
        /// Gets or sets the type of the arrivalTrack.
        /// </summary>
        /// <value>The type of the arrivalTrack.</value>
        public string arrivalTrack { get; set; }

        /// <summary>
        /// Gets or sets the type of the seats.
        /// </summary>
        /// <value>The type of the seats.</value>
        public Seat[] seats { get; set; }

        /// <summary>
        /// Gets or sets the type of the vehicle.
        /// </summary>
        /// <value>The type of the vehicle.</value>
        public Vehicle vehicle { get; set; }
    }
}
