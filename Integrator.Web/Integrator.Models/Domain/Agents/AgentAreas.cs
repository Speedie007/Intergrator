using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Agents
{
    public partial class AgentArea : BaseEntity
    {
       
        public int SuburbID { get; set; }
        public int IntegratorUserID { get; set; }
        public DateTime DateAssigned { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }
        public virtual Suburb Suburb { get; set; }
    }
}
