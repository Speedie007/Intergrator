using Integrator.Models.Domain.KnowledgeBase.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyJobRelatedIndustrySector:BaseEntity
    {
        
        public int CompanyRelatedIndustrySectorID { get; set; }
        public int CompanyJobID { get; set; }

        public virtual CompanyJob CompanyJob { get; set; }
        public virtual CompanyRelatedIndustrySector CompanyRelatedIndustrySector { get; set; }
    }
}