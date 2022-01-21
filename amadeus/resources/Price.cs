using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Price object.
    /// </summary>
    public class Price
    {
        internal Price() { }

        /// <summary>
        /// Gets or sets the margin.
        /// </summary>
        /// <value>The margin.</value>
        public string margin { get; set; }

        /// <summary>
        /// Gets or sets the grandTotal.
        /// </summary>
        /// <value>The grandTotal.</value>
        public string grandTotal { get; set; }

        /// <summary>
        /// Gets or sets the billingCurrency.
        /// </summary>
        /// <value>The billingCurrency.</value>
        public string billingCurrency { get; set; }

        /// <summary>
        /// Gets or sets the additionalServices.
        /// </summary>
        /// <value>The additionalServices.</value>
        public List<AdditionalService> additionalServices { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string currency { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>The total.</value>
        public string total { get; set; }

        /// <summary>
        /// Gets or sets the base.
        /// </summary>
        /// <value>The base.</value>
        public string Base { get; set; }

        /// <summary>
        /// Gets or sets the fees.
        /// </summary>
        /// <value>The fees.</value>
        public List<Fee> fees { get; set; }

        /// <summary>
        /// Gets or sets the taxes.
        /// </summary>
        /// <value>The taxes.</value>
        public List<Tax> taxes { get; set; }

        /// <summary>
        /// Gets or sets the refundableTaxes.
        /// </summary>
        /// <value>The refundableTaxes.</value>
        public string refundableTaxes { get; set; }
    }
}
