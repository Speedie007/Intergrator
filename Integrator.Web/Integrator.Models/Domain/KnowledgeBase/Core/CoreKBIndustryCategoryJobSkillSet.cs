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
    
    public partial class CoreKBIndustryCategoryJobSkillSet : BaseEntity
    {
        public CoreKBIndustryCategoryJobSkillSet()
        {
            CompanyIndustryCategoryJobSkillSets = new HashSet<CompanyIndustryCategoryJobSkillSet>();
            IntegratorUserIndustryCategoryJobSkillSets = new HashSet<IntegratorUserIndustryCategoryJobSkillSet>();
        }

      
        public int IndustryCategoryJobID { get; set; }

        [StringLength(100)]
        public string IndustryCategorySkillSet { get; set; }

        public virtual CoreKBIndustryCategoryJob CoreKBIndustryCategoryJob { get; set; }

        public virtual ICollection<CompanyIndustryCategoryJobSkillSet> CompanyIndustryCategoryJobSkillSets { get; set; }

        public virtual ICollection<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }
    }
}