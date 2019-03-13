using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    public partial class IntegratorUserIndustryCategoryJobSkillSet
    {
        [Column("IntegratorUserIndustryCategoryJobSkillSetID")]
        public int IntegratorUserIndustryCategoryJobSkillSetId { get; set; }
        [Column("IntegratorUserID")]
        public int IntegratorUserId { get; set; }
        [Column("IntegratorUserIndustryCategoryJobID")]
        public int IntegratorUserIndustryCategoryJobId { get; set; }
        [Column("IndustryCategorySkillSetID")]
        public int IndustryCategorySkillSetId { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("IndustryCategorySkillSetId")]
        [InverseProperty("IntegratorUserIndustryCategoryJobSkillSets")]
        public virtual LookupTableIndustryCategoryJobSkillSet IndustryCategorySkillSet { get; set; }
        [ForeignKey("IntegratorUserId")]
        [InverseProperty("IntegratorUserIndustryCategoryJobSkillSets")]
        public virtual User IntegratorUser { get; set; }
        [ForeignKey("IntegratorUserIndustryCategoryJobId")]
        [InverseProperty("IntegratorUserIndustryCategoryJobSkillSets")]
        public virtual IntegratorUserIndustryCategoryJob IntegratorUserIndustryCategoryJob { get; set; }
    }
}