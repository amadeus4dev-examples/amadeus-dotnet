using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Car object.
    /// </summary>
    public class Car
    {
        internal Car() { }

        /// <summary>
        /// Gets or sets the type of the confirmationNumber.
        /// </summary>
        /// <value>The type of the confirmationNumber.</value>
        public string confirmationNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the serviceProviderName.
        /// </summary>
        /// <value>The type of the serviceProviderName.</value>
        public string serviceProviderName { get; set; }

        /// <summary>
        /// Gets or sets the type of the associatedEquipments.
        /// </summary>
        /// <value>The type of the associatedEquipments.</value>
        public AssociatedEquipment[] associatedEquipments { get; set; }

        /// <summary>
        /// Gets or sets the type of the pickup.
        /// </summary>
        /// <value>The type of the pickup.</value>
        public PickupDropoff pickup { get; set; }

        /// <summary>
        /// Gets or sets the type of the dropoff.
        /// </summary>
        /// <value>The type of the dropoff.</value>
        public PickupDropoff dropoff { get; set; }

        /// <summary>
        /// Gets or sets the type of the driver.
        /// </summary>
        /// <value>The type of the driver.</value>
        public Driver driver { get; set; }

        /// <summary>
        /// Gets or sets the type of the vehicle.
        /// </summary>
        /// <value>The type of the vehicle.</value>
        public CarVehicle vehicle { get; set; }
    }
}
