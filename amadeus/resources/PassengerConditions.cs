using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An PassengerConditions object.
    /// </summary>
    public class PassengerConditions
    {
        internal PassengerConditions() { }

        /// <summary>
        /// Gets or sets the type of the travelerId.
        /// </summary>
        /// <value>The type of the travelerId.</value>
        public string travelerId { get; set; }

        /// <summary>
        /// Gets or sets the type of the genderRequired.
        /// </summary>
        /// <value>The type of the genderRequired.</value>
        public bool genderRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the documentRequired.
        /// </summary>
        /// <value>The type of the documentRequired.</value>
        public bool documentRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the documentIssuanceCityRequired.
        /// </summary>
        /// <value>The type of the documentIssuanceCityRequired.</value>
        public bool documentIssuanceCityRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the dateOfBirthRequired.
        /// </summary>
        /// <value>The type of the dateOfBirthRequired.</value>
        public bool dateOfBirthRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the redressRequiredIfAny.
        /// </summary>
        /// <value>The type of the redressRequiredIfAny.</value>
        public bool redressRequiredIfAny { get; set; }

        /// <summary>
        /// Gets or sets the type of the airFranceDiscountRequired.
        /// </summary>
        /// <value>The type of the airFranceDiscountRequired.</value>
        public bool airFranceDiscountRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the spanishResidentDiscountRequired.
        /// </summary>
        /// <value>The type of the spanishResidentDiscountRequired.</value>
        public bool spanishResidentDiscountRequired { get; set; }

        /// <summary>
        /// Gets or sets the type of the residenceRequired.
        /// </summary>
        /// <value>The type of the residenceRequired.</value>
        public bool residenceRequired { get; set; }
    }
}
