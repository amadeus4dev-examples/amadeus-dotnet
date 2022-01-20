using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An TravelerDocument object.
    /// </summary>
    public class TravelerDocument
    {
        internal TravelerDocument() { }

        /// <summary>
        /// Gets or sets the type of the number.
        /// </summary>
        /// <value>The type of the number.</value>
        public string number { get; set; }

        /// <summary>
        /// Gets or sets the type of the issuanceDate.
        /// </summary>
        /// <value>The type of the issuanceDate.</value>
        public string issuanceDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the expiryDate.
        /// </summary>
        /// <value>The type of the expiryDate.</value>
        public string expiryDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the issuanceCountry.
        /// </summary>
        /// <value>The type of the issuanceCountry.</value>
        public string issuanceCountry { get; set; }

        /// <summary>
        /// Gets or sets the type of the issuanceLocation.
        /// </summary>
        /// <value>The type of the issuanceLocation.</value>
        public string issuanceLocation { get; set; }

        /// <summary>
        /// Gets or sets the type of the nationality.
        /// </summary>
        /// <value>The type of the nationality.</value>
        public string nationality { get; set; }

        /// <summary>
        /// Gets or sets the type of the birthPlace.
        /// </summary>
        /// <value>The type of the birthPlace.</value>
        public string birthPlace { get; set; }

        /// <summary>
        /// Gets or sets the type of the documentType.
        /// </summary>
        /// <value>The type of the documentType.</value>
        public string documentType { get; set; }

        /// <summary>
        /// Gets or sets the type of the validityCountry.
        /// </summary>
        /// <value>The type of the validityCountry.</value>
        public string validityCountry { get; set; }

        /// <summary>
        /// Gets or sets the type of the birthCountry.
        /// </summary>
        /// <value>The type of the birthCountry.</value>
        public string birthCountry { get; set; }

        /// <summary>
        /// Gets or sets the type of the holder.
        /// </summary>
        /// <value>The type of the holder.</value>
        public bool holder { get; set; }
    }
}
