using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.KnowledgeBase.Companies;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    public partial class CoreKbIndustry:BaseEntity
    {
        public CoreKbIndustry()
        {
            ComanyJobRelatedIndustries = new HashSet<CompanyJobRelatedIndustry>();
            CompanyRelatedIndustries = new HashSet<CompanyRelatedIndustry>();
            CoreKbIndustryJobs = new HashSet<CoreKbIndustryJob>();
            UserJobRelatedIndustries = new HashSet<UserJobRelatedIndustry>();
        }

        
        public int CoreKbIndustryCategoryID { get; set; }
        public string CoreKbIndustryName { get; set; }

        public virtual CoreKbIndustryCategory CoreKbIndustryCategory { get; set; }
        public virtual ICollection<CompanyJobRelatedIndustry> ComanyJobRelatedIndustries { get; set; }
        public virtual ICollection<CompanyRelatedIndustry> CompanyRelatedIndustries { get; set; }
        public virtual ICollection<CoreKbIndustryJob> CoreKbIndustryJobs { get; set; }
        public virtual ICollection<UserJobRelatedIndustry> UserJobRelatedIndustries { get; set; }
    }
}