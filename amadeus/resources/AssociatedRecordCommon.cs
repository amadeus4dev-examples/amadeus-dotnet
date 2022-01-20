using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AssociatedRecordCommon object.
    /// </summary>
    public class AssociatedRecordCommon
    {
        internal AssociatedRecordCommon() { }

        /// <summary>
        /// Gets or sets the type of the reference.
        /// </summary>
        /// <value>The type of the reference.</value>
        public string reference { get; set; }

        /// <summary>
        /// Gets or sets the type of the creationDate.
        /// </summary>
        /// <value>The type of the creationDate.</value>
        public string creationDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the originSystemCode.
        /// </summary>
        /// <value>The type of the originSystemCode.</value>
        public string originSystemCode { get; set; }
    }
}
