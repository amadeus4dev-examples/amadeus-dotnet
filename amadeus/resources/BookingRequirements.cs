using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An BookingRequirements object.
    /// </summary>
    public class BookingRequirements
    {
        internal BookingRequirements() { }

        /// <summary>
        /// Gets or sets the type of the invoiceAddressRequired.
        /// </summary>
        /// <value>The type of the invoiceAddressRequired.</value>
        public bool invoiceAddressRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the mailingAddressRequired.
        /// </summary>
        /// <value>The type of the mailingAddressRequired.</value>
        public bool mailingAddressRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the emailAddressRequired.
        /// </summary>
        /// <value>The type of the emailAddressRequired.</value>
        public bool emailAddressRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the phoneCountryCodeRequired.
        /// </summary>
        /// <value>The type of the phoneCountryCodeRequired.</value>
        public bool phoneCountryCodeRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the mobilePhoneNumberRequired.
        /// </summary>
        /// <value>The type of the mobilePhoneNumberRequired.</value>
        public bool mobilePhoneNumberRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the phoneNumberRequired.
        /// </summary>
        /// <value>The type of the phoneNumberRequired.</value>
        public bool phoneNumberRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the postalCodeRequired.
        /// </summary>
        /// <value>The type of the postalCodeRequired.</value>
        public bool postalCodeRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelerRequirements.
        /// </summary>
        /// <value>The type of the travelerRequirements.</value>
        public List<PassengerConditions> travelerRequirements { get; set; }
    }
}
