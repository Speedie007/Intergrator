using Integrator.Models.Domain.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    public partial class CoreKbIndustrySector :BaseEntity
    {
        public CoreKbIndustrySector()
        {
            CompanyRelatedIndustrySectors = new HashSet<CompanyRelatedIndustrySector>();
        }

       
        public int CoreKbIndustryID { get; set; }
        public string IndustrySectorName { get; set; }

        public virtual CoreKbIndustry CoreKbIndustry { get; set; }
        public virtual ICollection<CompanyRelatedIndustrySector> CompanyRelatedIndustrySectors { get; set; }
    }
}