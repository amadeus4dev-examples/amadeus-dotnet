using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FlightSegment object.
    /// </summary>
    public class FlightSegment
    {
        internal FlightSegment() { }

        /// <summary>
        /// Gets or sets the type of the departure.
        /// </summary>
        /// <value>The type of the departure.</value>
        public FlightEndPoint departure { get; set; }

        /// <summary>
        /// Gets or sets the type of the arrival.
        /// </summary>
        /// <value>The type of the arrival.</value>
        public FlightEndPoint arrival { get; set; }

        /// <summary>
        /// Gets or sets the type of the carrierCode.
        /// </summary>
        /// <value>The type of the carrierCode.</value>
        public string carrierCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the number.
        /// </summary>
        /// <value>The type of the number.</value>
        public string number { get; set; }

        /// <summary>
        /// Gets or sets the type of the aircraft.
        /// </summary>
        /// <value>The type of the aircraft.</value>
        public AircraftEquipment aircraft { get; set; }

        /// <summary>
        /// Gets or sets the type of the operating.
        /// </summary>
        /// <value>The type of the operating.</value>
        public OperatingFlight operating { get; set; }

        /// <summary>
        /// Gets or sets the type of the duration.
        /// </summary>
        /// <value>The type of the duration.</value>
        public string duration { get; set; }

        /// <summary>
        /// Gets or sets the type of the stops.
        /// </summary>
        /// <value>The type of the stops.</value>
        public FlightStop stops { get; set; }
    }
}
