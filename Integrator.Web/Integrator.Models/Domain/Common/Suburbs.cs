using Integrator.Models;
using Integrator.Models.Domain.Addresses;
using Integrator.Models.Domain.Agents;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Common
{
    public partial class Suburb: BaseEntity
    {
        public Suburb()
        {
            Addresses = new HashSet<Address>();
            AgentAreas = new HashSet<AgentArea>();
        }
        public int CityID { get; set; }
        public string SuburbName { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<AgentArea> AgentAreas { get; set; }
    }
}