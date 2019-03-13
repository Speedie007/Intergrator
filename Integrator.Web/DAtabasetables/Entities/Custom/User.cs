using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    public partial class User
    {
        public User()
        {
            IntegratorUserIndustries = new HashSet<IntegratorUserIndustry>();
            IntegratorUserIndustryCategories = new HashSet<IntegratorUserIndustryCategory>();
            IntegratorUserIndustryCategoryJobSkillSets = new HashSet<IntegratorUserIndustryCategoryJobSkillSet>();
            IntegratorUserIndustryCategoryJobs = new HashSet<IntegratorUserIndustryCategoryJob>();
        }

        [Key]
        [Column("IntegratorUserID")]
        public int IntegratorUserId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }

        [InverseProperty("IntegratorUser")]
        public virtual ICollection<IntegratorUserIndustry> IntegratorUserIndustries { get; set; }
        [InverseProperty("IntegratorUser")]
        public virtual ICollection<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }
        [InverseProperty("IntegratorUser")]
        public virtual ICollection<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }
        [InverseProperty("IntegratorUser")]
        public virtual ICollection<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }
    }
}