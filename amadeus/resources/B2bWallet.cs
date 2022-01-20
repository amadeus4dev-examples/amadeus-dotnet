using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An B2bWallet object.
    /// </summary>
    public class B2bWallet
    {
        internal B2bWallet() { }

        /// <summary>
        /// Gets or sets the type of the cardId.
        /// </summary>
        /// <value>The type of the cardId.</value>
        public string cardId { get; set; }

        /// <summary>
        /// Gets or sets the type of the cardUsageName.
        /// </summary>
        /// <value>The type of the cardUsageName.</value>
        public string cardUsageName { get; set; }

        /// <summary>
        /// Gets or sets the type of the cardFriendlyName.
        /// </summary>
        /// <value>The type of the cardFriendlyName.</value>
        public string cardFriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the type of the reportingData.
        /// </summary>
        /// <value>The type of the reportingData.</value>
        public List<ReportingData> reportingData { get; set; }

        /// <summary>
        /// Gets or sets the type of the virtualCreditCardDetails.
        /// </summary>
        /// <value>The type of the virtualCreditCardDetails.</value>
        public CreditCardCommon virtualCreditCardDetails { get; set; }

        /// <summary>
        /// Gets or sets the type of the flightOfferIds.
        /// </summary>
        /// <value>The type of the flightOfferIds.</value>
        public List<string> flightOfferIds { get; set; }
    }
}
