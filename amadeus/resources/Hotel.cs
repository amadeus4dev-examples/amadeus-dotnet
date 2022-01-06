using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Hotel object.
    /// </summary>
    public class Hotel
    {
        internal Hotel() { }

        /// <summary>
        /// Gets or sets the confirmationNumber.
        /// </summary>
        /// <value>The confirmationNumber.</value>
        public string confirmationNumber { get; set; }

        /// <summary>
        /// Gets or sets the checkInDate.
        /// </summary>
        /// <value>The checkInDate.</value>
        public string checkInDate { get; set; }

        /// <summary>
        /// Gets or sets the checkOutDate.
        /// </summary>
        /// <value>The checkOutDate.</value>
        public string checkOutDate { get; set; }

        /// <summary>
        /// Gets or sets the roomQuantity.
        /// </summary>
        /// <value>The roomQuantity.</value>
        public int roomQuantity { get; set; }

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        /// <value>The contact.</value>
        public ContactHotel contact { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public Address address { get; set; }

        /// <summary>
        /// Gets or sets the amenities.
        /// </summary>
        /// <value>The amenities.</value>
        public string[] amenities { get; set; }


        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public Description description { get; set; }

        /// <summary>
        /// Gets or sets the policies.
        /// </summary>
        /// <value>The policies.</value>
        public Policies policies { get; set; }

        /// <summary>
        /// Gets or sets the guests.
        /// </summary>
        /// <value>The guests.</value>
        public Guests guests { get; set; }

        /// <summary>
        /// Gets or sets the room.
        /// </summary>
        /// <value>The room.</value>
        public Room room { get; set; }
    }
}
