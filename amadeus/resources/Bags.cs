using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Bags object.
    /// </summary>
    public class Bags
    {
        internal Bags() { }

        /// <summary>
        /// Gets or sets the type of the quantity.
        /// </summary>
        /// <value>The type of the quantity.</value>
        public int quantity { get; set; }

        /// <summary>
        /// Gets or sets the type of the weight.
        /// </summary>
        /// <value>The type of the weight.</value>
        public int weight { get; set; }

        /// <summary>
        /// Gets or sets the type of the weightUnit.
        /// </summary>
        /// <value>The type of the weightUnit.</value>
        public string weightUnit { get; set; }

        /// <summary>
        /// Gets or sets the type of the name.
        /// </summary>
        /// <value>The type of the name.</value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the type of the price.
        /// </summary>
        /// <value>The type of the price.</value>
        public ElementaryPrice price { get; set; }

        /// <summary>
        /// Gets or sets the type of the bookableByItinerary.
        /// </summary>
        /// <value>The type of the bookableByItinerary.</value>
        public bool bookableByItinerary { get; set; }

        /// <summary>
        /// Gets or sets the type of the segmentIds.
        /// </summary>
        /// <value>The type of the segmentIds.</value>
        public List<string> segmentIds { get; set; }

        /// <summary>
        /// Gets or sets the type of the travelerIds.
        /// </summary>
        /// <value>The type of the travelerIds.</value>
        public List<string> travelerIds { get; set; }
    }
}
