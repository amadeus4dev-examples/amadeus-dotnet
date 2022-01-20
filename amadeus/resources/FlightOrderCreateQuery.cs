using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FlightOrderCreateQuery object.
    /// </summary>
    public class FlightOrderCreateQuery : Resource
    {
        internal FlightOrderCreateQuery() { }

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
        /// Gets or sets the type of the queuingOfficeId.
        /// </summary>
        /// <value>The type of the queuingOfficeId.</value>
        public string queuingOfficeId { get; set; }

        /// <summary>
        /// Gets or sets the type of the ownerOfficeId.
        /// </summary>
        /// <value>The type of the ownerOfficeId.</value>
        public string ownerOfficeId { get; set; }

        /// <summary>
        /// Gets or sets the type of the associatedRecords.
        /// </summary>
        /// <value>The type of the associatedRecords.</value>
        public List<AssociatedRecord> associatedRecords { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightOffers.
        /// </summary>
        /// <value>The type of the flightOffers.</value>
        public List<FlightOffer> flightOffers { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelers.
        /// </summary>
        /// <value>The type of the travelers.</value>
        public List<TravelerElement> travelers { get; set; }

        /// <summary>
        /// Gets or sets the type of the remarks.
        /// </summary>
        /// <value>The type of the remarks.</value>
        public Remarks remarks { get; set; }

        /// <summary>
        /// Gets or sets the type of the formOfPayments.
        /// </summary>
        /// <value>The type of the formOfPayments.</value>
        public List<FormOfPayment> formOfPayments { get; set; }

        /// <summary>
        /// Gets or sets the type of the ticketingAgreement.
        /// </summary>
        /// <value>The type of the ticketingAgreement.</value>
        public TicketingAgreement ticketingAgreement { get; set; }

        /// <summary>
        /// Gets or sets the type of the automatedProcess.
        /// </summary>
        /// <value>The type of the automatedProcess.</value>
        public List<AutomatedProcess> automatedProcess { get; set; }

        /// <summary>
        /// Gets or sets the type of the contacts.
        /// </summary>
        /// <value>The type of the contacts.</value>
        public List<Contact> contacts { get; set; }

        /// <summary>
        /// Gets or sets the type of the tickets.
        /// </summary>
        /// <value>The type of the tickets.</value>
        public List<AirTravelDocument> tickets { get; set; }
    }
}
