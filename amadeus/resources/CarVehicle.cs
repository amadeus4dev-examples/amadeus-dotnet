using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An CarVehicle object.
    /// </summary>
    public class CarVehicle
    {
        internal CarVehicle() { }

        /// <summary>
        /// Gets or sets the type of the acrissCode.
        /// </summary>
        /// <value>The type of the acrissCode.</value>
        public string acrissCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the carModel.
        /// </summary>
        /// <value>The type of the carModel.</value>
        public string carModel { get; set; }

        /// <summary>
        /// Gets or sets the type of the doors.
        /// </summary>
        /// <value>The type of the doors.</value>
        public int doors { get; set; }
    }
}
