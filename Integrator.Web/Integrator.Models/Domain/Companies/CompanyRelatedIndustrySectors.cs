using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyRelatedIndustrySector:BaseEntity
    {
        public CompanyRelatedIndustrySector()
        {
            CompanyJobRelatedIndustrySectors = new HashSet<CompanyJobRelatedIndustrySector>();
        }

       
        public int CompanyRelatedIndustryID { get; set; }
        public int CoreKbIndustrySectorID { get; set; }

        public virtual CompanyRelatedIndustry CompanyRelatedIndustry { get; set; }
        public virtual CoreKbIndustrySector CoreKbIndustrySector { get; set; }
        public virtual ICollection<CompanyJobRelatedIndustrySector> CompanyJobRelatedIndustrySectors { get; set; }
    }
}