using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    public partial class IntegratorUserIndustryCategoryJob
    {
        public IntegratorUserIndustryCategoryJob()
        {
            IntegratorUserIndustryCategoryJobSkillSets = new HashSet<IntegratorUserIndustryCategoryJobSkillSet>();
        }

        [Column("IntegratorUserIndustryCategoryJobID")]
        public int IntegratorUserIndustryCategoryJobId { get; set; }
        [Column("IntegratorUserID")]
        public int IntegratorUserId { get; set; }
        [Column("IntegratorUserIndustryCategoryID")]
        public int IntegratorUserIndustryCategoryId { get; set; }
        [Column("IndustryCategoryJobID")]
        public int IndustryCategoryJobId { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("IndustryCategoryJobId")]
        [InverseProperty("IntegratorUserIndustryCategoryJobs")]
        public virtual LookupTableIndustryCategoryJob IndustryCategoryJob { get; set; }
        [ForeignKey("IntegratorUserId")]
        [InverseProperty("IntegratorUserIndustryCategoryJobs")]
        public virtual User IntegratorUser { get; set; }
        [ForeignKey("IntegratorUserIndustryCategoryId")]
        [InverseProperty("IntegratorUserIndustryCategoryJobs")]
        public virtual IntegratorUserIndustryCategory IntegratorUserIndustryCategory { get; set; }
        [InverseProperty("IntegratorUserIndustryCategoryJob")]
        public virtual ICollection<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }
    }
}