using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Companies
{
    public partial class CompanyIndustryCategoryJob : BaseEntity
    {
        public CompanyIndustryCategoryJob()
        {
            CompanyIndustryCategoryJobSkillSets = new HashSet<CompanyIndustryCategoryJobSkillSet>();
        }

        public int CompanyID { get; set; }

        public int CompanyIndustryCategoryID { get; set; }

        public int CoreKBIndustryCategoryJobID { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        public virtual Company Company { get; set; }

        public virtual CompanyIndustryCategory CompanyIndustryCategory { get; set; }

        public virtual CoreKBIndustryCategoryJob CoreKBIndustryCategoryJob { get; set; }

        public virtual ICollection<CompanyIndustryCategoryJobSkillSet> CompanyIndustryCategoryJobSkillSets { get; set; }
    }
}