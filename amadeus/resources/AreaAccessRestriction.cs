using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AreaAccessRestriction object.
    /// </summary>
    public class AreaAccessRestriction
    {
        internal AreaAccessRestriction() { }

        /// <summary>
        /// Gets or sets the type of the transportation.
        /// </summary>
        /// <value>The type of the transportation.</value>
        public Transportation transportation { get; set; }

        /// <summary>
        /// Gets or sets the type of the declarationDocuments.
        /// </summary>
        /// <value>The type of the declarationDocuments.</value>
        public DeclarationDocuments declarationDocuments { get; set; }

        /// <summary>
        /// Gets or sets the type of the entry.
        /// </summary>
        /// <value>The type of the entry.</value>
        public EntryRestriction entry { get; set; }

        /// <summary>
        /// Gets or sets the type of the diseaseTesting.
        /// </summary>
        /// <value>The type of the diseaseTesting.</value>
        public DiseaseTestingRestriction diseaseTesting { get; set; }

        /// <summary>
        /// Gets or sets the type of the tracingApplication.
        /// </summary>
        /// <value>The type of the tracingApplication.</value>
        public DatedTracingApplicationRestriction tracingApplication { get; set; }

        /// <summary>
        /// Gets or sets the type of the quarantineModality.
        /// </summary>
        /// <value>The type of the quarantineModality.</value>
        public DatedQuarantineRestriction quarantineModality { get; set; }

        /// <summary>
        /// Gets or sets the type of the mask.
        /// </summary>
        /// <value>The type of the mask.</value>
        public MaskRestriction mask { get; set; }

        /// <summary>
        /// Gets or sets the type of the exit.
        /// </summary>
        /// <value>The type of the exit.</value>
        public ExitRestriction exit { get; set; }

        /// <summary>
        /// Gets or sets the type of the otherRestriction.
        /// </summary>
        /// <value>The type of the otherRestriction.</value>
        public DatedInformation otherRestriction { get; set; }

        /// <summary>
        /// Gets or sets the type of the diseaseVaccination.
        /// </summary>
        /// <value>The type of the diseaseVaccination.</value>
        public DiseaseVaccination diseaseVaccination { get; set; }
    }
}
