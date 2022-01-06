using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Contact object.
    /// </summary>
    public class Contact
    {
        internal Contact() { }

        /// <summary>
        /// Gets or sets the type of the phone.
        /// </summary>
        /// <value>The type of the phone.</value>
        public Phone phone { get; set; }
    }
}
