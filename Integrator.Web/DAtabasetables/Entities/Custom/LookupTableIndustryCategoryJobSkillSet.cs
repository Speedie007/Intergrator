using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    [Table("LookupTable_IndustryCategoryJobSkillSets")]
    public partial class LookupTableIndustryCategoryJobSkillSet
    {
        public LookupTableIndustryCategoryJobSkillSet()
        {
            CompanyIndustryCategoryJobSkillSets = new HashSet<CompanyIndustryCategoryJobSkillSet>();
            IntegratorUserIndustryCategoryJobSkillSets = new HashSet<IntegratorUserIndustryCategoryJobSkillSet>();
        }

        [Column("IndustryCategorySkillSetID")]
        public int IndustryCategorySkillSetId { get; set; }
        [Column("IndustryCategoryJobID")]
        public int IndustryCategoryJobId { get; set; }
        [StringLength(50)]
        public string IndustryCategorySkillSet { get; set; }

        [ForeignKey("IndustryCategoryJobId")]
        [InverseProperty("LookupTableIndustryCategoryJobSkillSets")]
        public virtual LookupTableIndustryCategoryJob IndustryCategoryJob { get; set; }
        [InverseProperty("IndustryCategorySkillSet")]
        public virtual ICollection<CompanyIndustryCategoryJobSkillSet> CompanyIndustryCategoryJobSkillSets { get; set; }
        [InverseProperty("IndustryCategorySkillSet")]
        public virtual ICollection<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }
    }
}