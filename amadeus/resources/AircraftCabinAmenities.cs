using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An AircraftCabinAmenities object.
    /// </summary>
    public class AircraftCabinAmenities
    {
        internal AircraftCabinAmenities() { }

        /// <summary>
        /// Gets or sets the type of the power.
        /// </summary>
        /// <value>The type of the power.</value>
        public Amenity power { get; set; }

        /// <summary>
        /// Gets or sets the type of the seat.
        /// </summary>
        /// <value>The type of the seat.</value>
        public AmenitySeat seat { get; set; }

        /// <summary>
        /// Gets or sets the type of the wifi.
        /// </summary>
        /// <value>The type of the wifi.</value>
        public Amenity wifi { get; set; }

        /// <summary>
        /// Gets or sets the type of the entertainment.
        /// </summary>
        /// <value>The type of the entertainment.</value>
        public List<Amenity> entertainment { get; set; }

        /// <summary>
        /// Gets or sets the type of the food.
        /// </summary>
        /// <value>The type of the food.</value>
        public Amenity food { get; set; }

        /// <summary>
        /// Gets or sets the type of the beverage.
        /// </summary>
        /// <value>The type of the beverage.</value>
        public Amenity beverage { get; set; }
    }
}
