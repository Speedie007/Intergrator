using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.Company
{
    public partial class CompanyIndustryCategoryJobSkillSet : BaseEntity
    {
        //[Column("CompanyIndustryCategoryJobSkillSetID")]
        //public int CompanyIndustryCategoryJobSkillSetID { get; set; }
        [Column("CompanyID")]
        public int CompanyID { get; set; }
        [Column("CompanyIndustryCategoryJobID")]
        public int CompanyIndustryCategoryJobID { get; set; }
        [Column("IndustryCategorySkillSetID")]
        public int IndustryCategorySkillSetID { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("CompanyID")]
        [InverseProperty("CompanyIndustryCategoryJobSkillSets")]
        public virtual Integrator.Models.Domain.Companies.Company Company { get; set; }
        [ForeignKey("CompanyIndustryCategoryJobID")]
        [InverseProperty("CompanyIndustryCategoryJobSkillSets")]
        public virtual CompanyIndustryCategoryJob CompanyIndustryCategoryJob { get; set; }
        [ForeignKey("IndustryCategorySkillSetID")]
        [InverseProperty("CompanyIndustryCategoryJobSkillSets")]
        public virtual LookupTableIndustryCategoryJobSkillSet IndustryCategorySkillSet { get; set; }
    }
}