using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Vehicle object.
    /// </summary>
    public class Vehicle
    {
        internal Vehicle() { }

        /// <summary>
        /// Gets or sets the type of the vehicleType.
        /// </summary>
        /// <value>The type of the vehicleType.</value>
        public string vehicleType { get; set; }

        /// <summary>
        /// Gets or sets the type of the code.
        /// </summary>
        /// <value>The type of the code.</value>
        public string code { get; set; }

        /// <summary>
        /// Gets or sets the type of the number.
        /// </summary>
        /// <value>The type of the number.</value>
        public string number { get; set; }

        /// <summary>
        /// Gets or sets the type of the displayName.
        /// </summary>
        /// <value>The type of the displayName.</value>
        public string displayName { get; set; }
    }
}
