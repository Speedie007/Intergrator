using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    public partial class CompanyIndustryCategoryJobSkillSet
    {
        [Column("CompanyIndustryCategoryJobSkillSetID")]
        public int CompanyIndustryCategoryJobSkillSetId { get; set; }
        [Column("CompanyID")]
        public int CompanyId { get; set; }
        [Column("CompanyIndustryCategoryJobID")]
        public int CompanyIndustryCategoryJobId { get; set; }
        [Column("IndustryCategorySkillSetID")]
        public int IndustryCategorySkillSetId { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("CompanyId")]
        [InverseProperty("CompanyIndustryCategoryJobSkillSets")]
        public virtual Company Company { get; set; }
        [ForeignKey("CompanyIndustryCategoryJobId")]
        [InverseProperty("CompanyIndustryCategoryJobSkillSets")]
        public virtual CompanyIndustryCategoryJob CompanyIndustryCategoryJob { get; set; }
        [ForeignKey("IndustryCategorySkillSetId")]
        [InverseProperty("CompanyIndustryCategoryJobSkillSets")]
        public virtual LookupTableIndustryCategoryJobSkillSet IndustryCategorySkillSet { get; set; }
    }
}