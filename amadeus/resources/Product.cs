using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Product object.
    /// </summary>
    public class Product
    {
        internal Product() { }

        /// <summary>
        /// Gets or sets the type of the air.
        /// </summary>
        /// <value>The type of the air.</value>
        public Air air { get; set; }

        /// <summary>
        /// Gets or sets the type of the hotel.
        /// </summary>
        /// <value>The type of the hotel.</value>
        public Hotel hotel { get; set; }

        /// <summary>
        /// Gets or sets the type of the car.
        /// </summary>
        /// <value>The type of the car.</value>
        public Car car { get; set; }

        /// <summary>
        /// Gets or sets the type of the train.
        /// </summary>
        /// <value>The type of the train.</value>
        public Train train { get; set; }
    }
}
