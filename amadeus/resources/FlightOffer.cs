using System;
using amadeus.resources;
using amadeus.shopping;

namespace amadeus.resources
{

    /// <summary>
    /// An FlightOffer object as returned by the FlightOffers API.
    /// <see cref="FlightOffers.get()"/>
    /// </summary>
    public class FlightOffer : Resource
    {

        internal FlightOffer() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the offer items.
        /// </summary>
        /// <value>The offer items.</value>
        public OfferItem[] offerItems { get; set; }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class OfferItem
        {

            internal OfferItem() { }

            /// <summary>
            /// Gets or sets the services.
            /// </summary>
            /// <value>The services.</value>
            public Service[] services { get; set; }

            /// <summary>
            /// Gets or sets the price.
            /// </summary>
            /// <value>The price.</value>
            public Price price { get; set; }

            /// <summary>
            /// Gets or sets the price per adult.
            /// </summary>
            /// <value>The price per adult.</value>
            public Price pricePerAdult { get; set; }

            /// <summary>
            /// Gets or sets the price per infant.
            /// </summary>
            /// <value>The price per infant.</value>
            public Price pricePerInfant { get; set; }

            /// <summary>
            /// Gets or sets the price per child.
            /// </summary>
            /// <value>The price per child.</value>
            public Price pricePerChild { get; set; }

            /// <summary>
            /// Gets or sets the price per senior.
            /// </summary>
            /// <value>The price per senior.</value>
            public Price pricePerSenior { get; set; }

        }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class Service
        {

            internal Service() { }

            /// <summary>
            /// Gets or sets the segments.
            /// </summary>
            /// <value>The segments.</value>
            public Segment[] segments { get; set; }

        }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class Segment
        {

            internal Segment() { }

            /// <summary>
            /// Gets or sets the flight segment.
            /// </summary>
            /// <value>The flight segment.</value>
            public FlightSegment flightSegment { get; set; }

            /// <summary>
            /// Gets or sets the pricing detail per adult.
            /// </summary>
            /// <value>The pricing detail per adult.</value>
            public PricingDetail pricingDetailPerAdult { get; set; }

            /// <summary>
            /// Gets or sets the pricing detail per infant.
            /// </summary>
            /// <value>The pricing detail per infant.</value>
            public PricingDetail pricingDetailPerInfant { get; set; }

            /// <summary>
            /// Gets or sets the pricing detail per child.
            /// </summary>
            /// <value>The pricing detail per child.</value>
            public PricingDetail pricingDetailPerChild { get; set; }

            /// <summary>
            /// Gets or sets the pricing detail per senior.
            /// </summary>
            /// <value>The pricing detail per senior.</value>
            public PricingDetail pricingDetailPerSenior { get; set; }

        }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class FlightSegment
        {

            internal FlightSegment() { }

            /// <summary>
            /// Gets or sets the departure.
            /// </summary>
            /// <value>The departure.</value>
            public FlightEndPoint departure { get; set; }

            /// <summary>
            /// Gets or sets the arrival.
            /// </summary>
            /// <value>The arrival.</value>
            public FlightEndPoint arrival { get; set; }

            /// <summary>
            /// Gets or sets the carrier code.
            /// </summary>
            /// <value>The carrier code.</value>
            public string carrierCode { get; set; }

            /// <summary>
            /// Gets or sets the number.
            /// </summary>
            /// <value>The number.</value>
            public string number { get; set; }

            /// <summary>
            /// Gets or sets the operating.
            /// </summary>
            /// <value>The operating.</value>
            public OperatingFlight operating { get; set; }

            /// <summary>
            /// Gets or sets the duration.
            /// </summary>
            /// <value>The duration.</value>
            public string duration { get; set; }

            /// <summary>
            /// Gets or sets the stops.
            /// </summary>
            /// <value>The stops.</value>
            public FlightStop[] stops { get; set; }

        }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class FlightEndPoint
        {

            internal FlightEndPoint() { }

            /// <summary>
            /// Gets or sets the iata code.
            /// </summary>
            /// <value>The iata code.</value>
            public string iataCode { get; set; }

            /// <summary>
            /// Gets or sets the terminal.
            /// </summary>
            /// <value>The terminal.</value>
            public string terminal { get; set; }

            /// <summary>
            /// Gets or sets at.
            /// </summary>
            /// <value>At.</value>
            public string at { get; set; }

        }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class OperatingFlight
        {

            internal OperatingFlight() { }

            /// <summary>
            /// Gets or sets the carrier code.
            /// </summary>
            /// <value>The carrier code.</value>
            public string carrierCode { get; set; }

            /// <summary>
            /// Gets or sets the number.
            /// </summary>
            /// <value>The number.</value>
            public string number { get; set; }

        }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class FlightStop
        {

            internal FlightStop() { }

            /// <summary>
            /// Gets or sets the iata code.
            /// </summary>
            /// <value>The iata code.</value>
            public string iataCode { get; set; }

            /// <summary>
            /// Gets or sets the new aircraft.
            /// </summary>
            /// <value>The new aircraft.</value>
            public AircraftEquipment newAircraft { get; set; }

            /// <summary>
            /// Gets or sets the duration.
            /// </summary>
            /// <value>The duration.</value>
            public string duration { get; set; }

            /// <summary>
            /// Gets or sets the arrival at.
            /// </summary>
            /// <value>The arrival at.</value>
            public DateTime arrivalAt { get; set; }

            /// <summary>
            /// Gets or sets the departure at.
            /// </summary>
            /// <value>The departure at.</value>
            public DateTime departureAt { get; set; }

        }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class AircraftEquipment
        {

            internal AircraftEquipment() { }

            /// <summary>
            /// Gets or sets the code.
            /// </summary>
            /// <value>The code.</value>
            public string code { get; set; }

        }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class Price
        {

            internal Price() { }

            /// <summary>
            /// Gets or sets the total.
            /// </summary>
            /// <value>The total.</value>
            public double total { get; set; }

            /// <summary>
            /// Gets or sets the total taxes.
            /// </summary>
            /// <value>The total taxes.</value>
            public double totalTaxes { get; set; }

        }

        /// <summary>
        /// An FlightOffer-related object as returned by the FlightOffers API.
        /// <see cref="FlightOffers.get()"/>
        /// </summary>
        public class PricingDetail
        {

            internal PricingDetail() { }

            /// <summary>
            /// Gets or sets the travel class.
            /// </summary>
            /// <value>The travel class.</value>
            public string travelClass { get; set; }

            /// <summary>
            /// Gets or sets the fare class.
            /// </summary>
            /// <value>The fare class.</value>
            public string fareClass { get; set; }

            /// <summary>
            /// Gets or sets the availability.
            /// </summary>
            /// <value>The availability.</value>
            public int availability { get; set; }

            /// <summary>
            /// Gets or sets the fare basis.
            /// </summary>
            /// <value>The fare basis.</value>
            public string fareBasis { get; set; }

        }
    }

}
