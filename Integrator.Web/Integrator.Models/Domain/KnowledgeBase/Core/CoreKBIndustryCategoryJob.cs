//using Integrator.Models.Domain.KnowledgeBase.Companies;
//using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Integrator.Models.Domain.KnowledgeBase.Companies;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    
    public partial class CoreKBIndustryCategoryJob : BaseEntity
    {
        public CoreKBIndustryCategoryJob()
        {
            CompanyIndustryCategoryJobs = new HashSet<CompanyIndustryCategoryJob>();
            IntegratorUserIndustryCategoryJobs = new HashSet<IntegratorUserIndustryCategoryJob>();
            CoreKBIndustryCategoryJobSkillSets = new HashSet<CoreKBIndustryCategoryJobSkillSet>();
        }

        public int IndustryCategoryID { get; set; }

        [StringLength(50)]
        public string JobTitle { get; set; }

        public virtual CoreKBIndustryCategory IndustryCategory { get; set; }

        public virtual ICollection<CompanyIndustryCategoryJob> CompanyIndustryCategoryJobs { get; set; }

        public virtual ICollection<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }

        public virtual ICollection<CoreKBIndustryCategoryJobSkillSet> CoreKBIndustryCategoryJobSkillSets { get; set; }
    }
}