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
    
    public partial class CoreKBIndustryType : BaseEntity
    {
        public CoreKBIndustryType()
        {
            CompanyIndustries = new HashSet<CompanyIndustry>();
            IntegratorUserIndustries = new HashSet<IntegratorUserIndustry>();
            CoreKBIndustryCategories = new HashSet<CoreKBIndustryCategory>();
        }

        [StringLength(100)]
        public string Industry { get; set; }

        //[InverseProperty("Industry")]
        public virtual ICollection<CompanyIndustry> CompanyIndustries { get; set; }

        public virtual ICollection<IntegratorUserIndustry> IntegratorUserIndustries { get; set; }

        public virtual ICollection<CoreKBIndustryCategory> CoreKBIndustryCategories { get; set; }
    }
}