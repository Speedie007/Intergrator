using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Companies
{
    public partial class CompanyIndustryCategoryJobSkillSet : BaseEntity
    {
        public int CompanyID { get; set; }

        public int CompanyIndustryCategoryJobID { get; set; }

        public int CoreKBIndustryCategorySkillSetID { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        public virtual Integrator.Models.Domain.Companies.Company Company { get; set; }

        public virtual CompanyIndustryCategoryJob CompanyIndustryCategoryJob { get; set; }

        public virtual CoreKBIndustryCategoryJobSkillSet CoreKBIndustryCategorySkillSet { get; set; }
    }
}