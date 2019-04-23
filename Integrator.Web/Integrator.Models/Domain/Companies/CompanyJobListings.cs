using Integrator.Models.Domain.KnowledgeBase.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyJobListing:BaseEntity
    {
        
        public int CompanyJobID { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public int LevelOfUrgentcy { get; set; }

        public virtual CompanyJob CompanyJob { get; set; }
    }
}