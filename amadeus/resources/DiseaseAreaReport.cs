using System;
using System.Collections.Generic;
using System.Text;

namespace amadeus.resources
{
    /// <summary>
    /// An DiseaseAreaReport object.
    /// </summary>
    public class DiseaseAreaReport : Resource
    {
        internal DiseaseAreaReport() { }

        /// <summary>
        /// Gets or sets the type of the type.
        /// </summary>
        /// <value>The type of the type.</value>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the type of the area.
        /// </summary>
        /// <value>The type of the area.</value>
        public Area area { get; set; }

        /// <summary>
        /// Gets or sets the type of the subAreas.
        /// </summary>
        /// <value>The type of the subAreas.</value>
        public List<Area> subAreas { get; set; }

        /// <summary>
        /// Gets or sets the type of the summary.
        /// </summary>
        /// <value>The type of the summary.</value>
        public Summary summary { get; set; }

        /// <summary>
        /// Gets or sets the type of the diseaseRiskLevel.
        /// </summary>
        /// <value>The type of the diseaseRiskLevel.</value>
        public Summary diseaseRiskLevel { get; set; }

        /// <summary>
        /// Gets or sets the type of the diseaseInfection.
        /// </summary>
        /// <value>The type of the diseaseInfection.</value>
        public DiseaseInfection diseaseInfection { get; set; }

        /// <summary>
        /// Gets or sets the type of the doors.
        /// </summary>
        /// <value>The type of the doors.</value>
        public int doors { get; set; }

        /// <summary>
        /// Gets or sets the type of the diseaseCases.
        /// </summary>
        /// <value>The type of the diseaseCases.</value>
        public DiseaseCase diseaseCases { get; set; }

        /// <summary>
        /// Gets or sets the type of the hotspots.
        /// </summary>
        /// <value>The type of the hotspots.</value>
        public Summary hotspots { get; set; }

        /// <summary>
        /// Gets or sets the type of the dataSources.
        /// </summary>
        /// <value>The type of the dataSources.</value>
        public Sources dataSources { get; set; }

        /// <summary>
        /// Gets or sets the type of the areaRestrictions.
        /// </summary>
        /// <value>The type of the areaRestrictions.</value>
        public List<AreaRestriction> areaRestrictions { get; set; }

        /// <summary>
        /// Gets or sets the type of the areaAccessRestriction.
        /// </summary>
        /// <value>The type of the areaAccessRestriction.</value>
        public AreaAccessRestriction areaAccessRestriction { get; set; }

        /// <summary>
        /// Gets or sets the type of the areaPolicy.
        /// </summary>
        /// <value>The type of the areaPolicy.</value>
        public AreaPolicy areaPolicy { get; set; }

        /// <summary>
        /// Gets or sets the type of the relatedArea.
        /// </summary>
        /// <value>The type of the relatedArea.</value>
        public List<Link> relatedArea { get; set; }

        /// <summary>
        /// Gets or sets the type of the areaVaccinated.
        /// </summary>
        /// <value>The type of the areaVaccinated.</value>
        public List<AreaVaccinated> areaVaccinated { get; set; }
    }
}
