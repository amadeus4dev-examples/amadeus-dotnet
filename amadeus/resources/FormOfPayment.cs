using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An FormOfPayment object.
    /// </summary>
    public class FormOfPayment
    {
        internal FormOfPayment() { }

        /// <summary>
        /// Gets or sets the type of the b2bWallet.
        /// </summary>
        /// <value>The type of the b2bWallet.</value>
        public B2bWallet b2bWallet { get; set; }

        /// <summary>
        /// Gets or sets the type of the creditCard.
        /// </summary>
        /// <value>The type of the creditCard.</value>
        public CreditCard creditCard { get; set; }

        /// <summary>
        /// Gets or sets the type of the other.
        /// </summary>
        /// <value>The type of the other.</value>
        public CreditCard other { get; set; }
    }
}
