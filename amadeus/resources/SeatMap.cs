using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An SeatMap object.
    /// </summary>
    public class SeatMap : Resource
    {
        internal SeatMap() { }

        /// <summary>
        /// Gets or sets the type of the type.
        /// </summary>
        /// <value>The type of the type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type of the self.
        /// </summary>
        /// <value>The type of the self.</value>
        public Link self { get; set; }

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
        /// Gets or sets the type of the operating.
        /// </summary>
        /// <value>The type of the operating.</value>
        public OperatingFlight operating { get; set; }

        /// <summary>
        /// Gets or sets the type of the aircraft.
        /// </summary>
        /// <value>The type of the aircraft.</value>
        public AircraftEquipment aircraft { get; set; }

        /// <summary>
        /// Gets or sets the type of the class.
        /// </summary>
        /// <value>The type of the class.</value>
        public string seatMapClass { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightOfferId.
        /// </summary>
        /// <value>The type of the flightOfferId.</value>
        public string flightOfferId { get; set; }

        /// <summary>
        /// Gets or sets the type of the segmentId.
        /// </summary>
        /// <value>The type of the segmentId.</value>
        public string segmentId { get; set; }

        /// <summary>
        /// Gets or sets the type of the decks.
        /// </summary>
        /// <value>The type of the decks.</value>
        public List<Deck> decks { get; set; }

        /// <summary>
        /// Gets or sets the type of the aircraftCabinAmenities.
        /// </summary>
        /// <value>The type of the aircraftCabinAmenities.</value>
        public List<AircraftCabinAmenities> aircraftCabinAmenities { get; set; }

        /// <summary>
        /// Gets or sets the type of the availableSeatsCounters.
        /// </summary>
        /// <value>The type of the availableSeatsCounters.</value>
        public List<AvailableSeatsCounter> availableSeatsCounters { get; set; }
    }
}
