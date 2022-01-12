using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DiseaseVaccination object.
    /// </summary>
    public class DiseaseVaccination
    {
        internal DiseaseVaccination() { }

        /// <summary>
        /// Gets or sets the type of the isRequired.
        /// </summary>
        /// <value>The type of the isRequired.</value>
        public string isRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the referenceLink.
        /// </summary>
        /// <value>The type of the referenceLink.</value>
        public string referenceLink { get; set; }

        /// <summary>
        /// Gets or sets the type of the acceptedCertificates.
        /// </summary>
        /// <value>The type of the acceptedCertificates.</value>
        public List<string> acceptedCertificates { get; set; }

        /// <summary>
        /// Gets or sets the type of the qualifiedVaccines.
        /// </summary>
        /// <value>The type of the qualifiedVaccines.</value>
        public List<string> qualifiedVaccines { get; set; }

        /// <summary>
        /// Gets or sets the type of the policy.
        /// </summary>
        /// <value>The type of the policy.</value>
        public string policy { get; set; }

        /// <summary>
        /// Gets or sets the type of the exemptions.
        /// </summary>
        /// <value>The type of the exemptions.</value>
        public string exemptions { get; set; }

        /// <summary>
        /// Gets or sets the type of the details.
        /// </summary>
        /// <value>The type of the details.</value>
        public string details { get; set; }

        /// <summary>
        /// Gets or sets the type of the date.
        /// </summary>
        /// <value>The type of the date.</value>
        public string date { get; set; }

        /// <summary>
        /// Gets or sets the type of the text.
        /// </summary>
        /// <value>The type of the text.</value>
        public string text { get; set; }
    }
}
