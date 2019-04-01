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
    
    public partial class CoreKBIndustryCategory : BaseEntity
    {
        public CoreKBIndustryCategory()
        {
            CompanyIndustryCategories = new HashSet<CompanyIndustryCategory>();
            IntegratorUserIndustryCategories = new HashSet<IntegratorUserIndustryCategory>();
            CoreKBIndustryCategoryJobs = new HashSet<CoreKBIndustryCategoryJob>();
        }
        
        [StringLength(100)]
        public string Category { get; set; }

        public int IndustryID { get; set; }

        public virtual CoreKBIndustryType Industry { get; set; }

        public virtual ICollection<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }

        public virtual ICollection<CoreKBIndustryCategoryJob> CoreKBIndustryCategoryJobs { get; set; }

        public virtual ICollection<CompanyIndustryCategory> CompanyIndustryCategories { get; set; }
    }
}