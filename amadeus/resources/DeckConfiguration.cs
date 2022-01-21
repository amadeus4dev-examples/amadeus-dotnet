using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DeckConfiguration object.
    /// </summary>
    public class DeckConfiguration
    {
        internal DeckConfiguration() { }

        /// <summary>
        /// Gets or sets the type of the width.
        /// </summary>
        /// <value>The type of the width.</value>
        public int width { get; set; }

        /// <summary>
        /// Gets or sets the type of the length.
        /// </summary>
        /// <value>The type of the length.</value>
        public int length { get; set; }

        /// <summary>
        /// Gets or sets the type of the startSeatRow.
        /// </summary>
        /// <value>The type of the startSeatRow.</value>
        public int startSeatRow { get; set; }

        /// <summary>
        /// Gets or sets the type of the endSeatRow.
        /// </summary>
        /// <value>The type of the endSeatRow.</value>
        public int endSeatRow { get; set; }

        /// <summary>
        /// Gets or sets the type of the startWingsX.
        /// </summary>
        /// <value>The type of the startWingsX.</value>
        public int startWingsX { get; set; }

        /// <summary>
        /// Gets or sets the type of the endWingsX.
        /// </summary>
        /// <value>The type of the endWingsX.</value>
        public int endWingsX { get; set; }

        /// <summary>
        /// Gets or sets the type of the startWingsRow.
        /// </summary>
        /// <value>The type of the startWingsRow.</value>
        public int startWingsRow { get; set; }

        /// <summary>
        /// Gets or sets the type of the endWingsRow.
        /// </summary>
        /// <value>The type of the endWingsRow.</value>
        public int endWingsRow { get; set; }

        /// <summary>
        /// Gets or sets the type of the exitRowsX.
        /// </summary>
        /// <value>The type of the exitRowsX.</value>
        public List<int> exitRowsX { get; set; }
    }
}
