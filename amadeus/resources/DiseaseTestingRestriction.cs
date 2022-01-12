using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DiseaseTestingRestriction object.
    /// </summary>
    public class DiseaseTestingRestriction
    {
        internal DiseaseTestingRestriction() { }

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

        /// <summary>
        /// Gets or sets the type of the isRequired.
        /// </summary>
        /// <value>The type of the isRequired.</value>
        public string isRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the when.
        /// </summary>
        /// <value>The type of the when.</value>
        public string when { get; set; }

        /// <summary>
        /// Gets or sets the type of the requirement.
        /// </summary>
        /// <value>The type of the requirement.</value>
        public string requirement { get; set; }

        /// <summary>
        /// Gets or sets the type of the rules.
        /// </summary>
        /// <value>The type of the rules.</value>
        public string rules { get; set; }

        /// <summary>
        /// Gets or sets the type of the testType.
        /// </summary>
        /// <value>The type of the testType.</value>
        public string testType { get; set; }

        /// <summary>
        /// Gets or sets the type of the minimumAge.
        /// </summary>
        /// <value>The type of the minimumAge.</value>
        public int minimumAge { get; set; }

        /// <summary>
        /// Gets or sets the type of the validityPeriod.
        /// </summary>
        /// <value>The type of the validityPeriod.</value>
        public ValidityPeriod validityPeriod { get; set; }
    }
}
