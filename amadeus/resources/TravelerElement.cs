using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An TravelerElement object.
    /// </summary>
    public class TravelerElement
    {
        internal TravelerElement() { }

        /// <summary>
        /// Gets or sets the type of the id.
        /// </summary>
        /// <value>The type of the id.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the type of the dateOfBirth.
        /// </summary>
        /// <value>The type of the dateOfBirth.</value>
        public string dateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the type of the gender.
        /// </summary>
        /// <value>The type of the gender.</value>
        public string gender { get; set; }

        /// <summary>
        /// Gets or sets the type of the name.
        /// </summary>
        /// <value>The type of the name.</value>
        public Name name { get; set; }

        /// <summary>
        /// Gets or sets the type of the documents.
        /// </summary>
        /// <value>The type of the documents.</value>
        public List<TravelerDocument> documents { get; set; }

        /// <summary>
        /// Gets or sets the type of the emergencyContact.
        /// </summary>
        /// <value>The type of the emergencyContact.</value>
        public EmergencyContact emergencyContact { get; set; }

        /// <summary>
        /// Gets or sets the type of the loyaltyPrograms.
        /// </summary>
        /// <value>The type of the loyaltyPrograms.</value>
        public List<LoyaltyProgram> loyaltyPrograms { get; set; }

        /// <summary>
        /// Gets or sets the type of the discountEligibility.
        /// </summary>
        /// <value>The type of the discountEligibility.</value>
        public List<Discount> discountEligibility { get; set; }

        /// <summary>
        /// Gets or sets the type of the contact.
        /// </summary>
        /// <value>The type of the contact.</value>
        public TravelerContact contact { get; set; }
    }
}
