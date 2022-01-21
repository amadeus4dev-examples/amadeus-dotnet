using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An OriginDestination object.
    /// </summary>
    public class OriginDestination
    {
        public OriginDestination() { }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type of the originLocationCode.
        /// </summary>
        /// <value>The type of the originLocationCode.</value>
        public string originLocationCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the originRadius.
        /// </summary>
        /// <value>The type of the originRadius.</value>
        public int originRadius { get; set; }

        /// <summary>
        /// Gets or sets the type of the alternativeOriginsCodes.
        /// </summary>
        /// <value>The type of the alternativeOriginsCodes.</value>
        public List<string> alternativeOriginsCodes { get; set; }

        /// <summary>
        /// Gets or sets the type of the destinationLocationCode.
        /// </summary>
        /// <value>The type of the destinationLocationCode.</value>
        public string destinationLocationCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the destinationRadius.
        /// </summary>
        /// <value>The type of the destinationRadius.</value>
        public int destinationRadius { get; set; }

        /// <summary>
        /// Gets or sets the type of the alternativeDestinationsCodes.
        /// </summary>
        /// <value>The type of the alternativeDestinationsCodes.</value>
        public List<string> alternativeDestinationsCodes { get; set; }

        /// <summary>
        /// Gets or sets the type of the departureDateTimeRange.
        /// </summary>
        /// <value>The type of the departureDateTimeRange.</value>
        public DateTimeRange departureDateTimeRange { get; set; }

        /// <summary>
        /// Gets or sets the type of the arrivalDateTimeRange.
        /// </summary>
        /// <value>The type of the arrivalDateTimeRange.</value>
        public DateTimeRange arrivalDateTimeRange { get; set; }

        /// <summary>
        /// Gets or sets the type of the includedConnectionPoints.
        /// </summary>
        /// <value>The type of the includedConnectionPoints.</value>
        public List<ConnectionPoints> includedConnectionPoints { get; set; }

        /// <summary>
        /// Gets or sets the type of the excludedConnectionPoints.
        /// </summary>
        /// <value>The type of the excludedConnectionPoints.</value>
        public List<ConnectionPoints> excludedConnectionPoints { get; set; }
    }
}
