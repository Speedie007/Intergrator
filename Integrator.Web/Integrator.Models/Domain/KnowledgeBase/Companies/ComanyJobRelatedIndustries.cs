using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Companies
{
    public partial class CompanyJobRelatedIndustry : BaseEntity
    {

        public int CoreKbIndustryID { get; set; }
        public int CompanyJobID { get; set; }
        public Boolean LevelOfCompanyInvolvement { get; set; }

        public virtual CompanyJob CompanyJob { get; set; }
        public virtual CoreKbIndustry CoreKbIndustry { get; set; }

    }
}