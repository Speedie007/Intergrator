using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    [Table("LookupTable_IndustryCategoryJobs")]
    public partial class LookupTableIndustryCategoryJob
    {
        public LookupTableIndustryCategoryJob()
        {
            CompanyIndustryCategoryJobs = new HashSet<CompanyIndustryCategoryJob>();
            IntegratorUserIndustryCategoryJobs = new HashSet<IntegratorUserIndustryCategoryJob>();
            LookupTableIndustryCategoryJobSkillSets = new HashSet<LookupTableIndustryCategoryJobSkillSet>();
        }

        [Column("IndustryCategoryJobID")]
        public int IndustryCategoryJobId { get; set; }
        [Column("IndustryCategoryID")]
        public int IndustryCategoryId { get; set; }
        [StringLength(50)]
        public string JobTitle { get; set; }

        [ForeignKey("IndustryCategoryId")]
        [InverseProperty("LookupTableIndustryCategoryJobs")]
        public virtual LookupTableIndustryCategory IndustryCategory { get; set; }
        [InverseProperty("IndustryCategoryJob")]
        public virtual ICollection<CompanyIndustryCategoryJob> CompanyIndustryCategoryJobs { get; set; }
        [InverseProperty("IndustryCategoryJob")]
        public virtual ICollection<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }
        [InverseProperty("IndustryCategoryJob")]
        public virtual ICollection<LookupTableIndustryCategoryJobSkillSet> LookupTableIndustryCategoryJobSkillSets { get; set; }
    }
}