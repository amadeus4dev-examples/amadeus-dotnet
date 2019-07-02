using System;
using amadeus.resources;
using resources.referenceData.urls;

namespace amadeus.resources
{

    /// <summary>
    /// An CheckinLink object as returned by the CheckinLink API.
    /// <see cref="CheckinLinks"/>
    /// </summary>
    public class CheckinLink : Resource
    {

        internal CheckinLink() { }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        /// <value>The href.</value>
        public string href { get; set; }

        /// <summary>
        /// Gets or sets the channel.
        /// </summary>
        /// <value>The channel.</value>
        public string channel { get; set; }

    }

}
