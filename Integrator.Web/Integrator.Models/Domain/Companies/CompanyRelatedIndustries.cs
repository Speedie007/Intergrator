using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyRelatedIndustry:BaseEntity
    {
        
        public int CoreKbIndustryID { get; set; }
        public int CompanyID { get; set; }

        public virtual Company Company { get; set; }
        public virtual CoreKbIndustry CoreKbIndustry { get; set; }
    }
}