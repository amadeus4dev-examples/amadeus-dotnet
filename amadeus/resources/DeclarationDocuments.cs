using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DeclarationDocuments object.
    /// </summary>
    public class DeclarationDocuments
    {
        internal DeclarationDocuments() { }

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
        /// Gets or sets the type of the documentRequired.
        /// </summary>
        /// <value>The type of the documentRequired.</value>
        public string documentRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the healthDocumentationLink.
        /// </summary>
        /// <value>The type of the healthDocumentationLink.</value>
        public string healthDocumentationLink { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelDocumentationLink.
        /// </summary>
        /// <value>The type of the travelDocumentationLink.</value>
        public string travelDocumentationLink { get; set; }

    }
}
