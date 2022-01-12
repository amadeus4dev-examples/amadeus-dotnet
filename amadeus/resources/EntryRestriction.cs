using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An EntryRestriction object.
    /// </summary>
    public class EntryRestriction
    {
        internal EntryRestriction() { }

        /// <summary>
        /// Gets or sets the type of the date.
        /// </summary>
        /// <value>The type of the date.</value>
        public string date { get; set; }

        /// <summary>
        /// Gets or sets the type of the text.
        /// </summary>
        /// <value>The type of the text.</value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the type of the ban.
        /// </summary>
        /// <value>The type of the ban.</value>
        public string ban { get; set; }

        /// <summary>
        /// Gets or sets the type of the throughDate.
        /// </summary>
        /// <value>The type of the throughDate.</value>
        public string throughDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the rules.
        /// </summary>
        /// <value>The type of the rules.</value>
        public string rules { get; set; }

        /// <summary>
        /// Gets or sets the type of the exemptions.
        /// </summary>
        /// <value>The type of the exemptions.</value>
        public string exemptions { get; set; }

        /// <summary>
        /// Gets or sets the type of the bannedArea.
        /// </summary>
        /// <value>The type of the bannedArea.</value>
        public List<Area> bannedArea { get; set; }

        /// <summary>
        /// Gets or sets the type of the borderBan.
        /// </summary>
        /// <value>The type of the borderBan.</value>
        public List<Border> borderBan { get; set; }
    }
}
