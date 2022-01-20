using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An Deck object.
    /// </summary>
    public class Deck
    {
        internal Deck() { }

        /// <summary>
        /// Gets or sets the type of the deckType.
        /// </summary>
        /// <value>The type of the deckType.</value>
        public string deckType { get; set; }

        /// <summary>
        /// Gets or sets the type of the deckConfiguration.
        /// </summary>
        /// <value>The type of the deckConfiguration.</value>
        public DeckConfiguration deckConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the type of the facilities.
        /// </summary>
        /// <value>The type of the facilities.</value>
        public List<Facility> facilities { get; set; }

        /// <summary>
        /// Gets or sets the type of the seats.
        /// </summary>
        /// <value>The type of the seats.</value>
        public List<Seat> seats { get; set; }
    }
}
