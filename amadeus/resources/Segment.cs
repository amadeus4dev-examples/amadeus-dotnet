using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Segment object.
    /// </summary>
    public class Segment
    {
        internal Segment() { }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type of the numberOfStops.
        /// </summary>
        /// <value>The type of the numberOfStops.</value>
        public int numberOfStops { get; set; }

        /// <summary>
        /// Gets or sets the type of the blacklistedInEU.
        /// </summary>
        /// <value>The type of the blacklistedInEU.</value>
        public bool blacklistedInEU { get; set; }

        /// <summary>
        /// Gets or sets the type of the co2Emissions.
        /// </summary>
        /// <value>The type of the co2Emissions.</value>
        public List<Co2Emission> co2Emissions { get; set; }

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
        public List<FlightStop> stops { get; set; }
    }
}
