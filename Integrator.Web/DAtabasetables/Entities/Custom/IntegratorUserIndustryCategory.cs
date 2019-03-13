using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    public partial class IntegratorUserIndustryCategory
    {
        public IntegratorUserIndustryCategory()
        {
            IntegratorUserIndustryCategoryJobs = new HashSet<IntegratorUserIndustryCategoryJob>();
        }

        [Column("IntegratorUserIndustryCategoryID")]
        public int IntegratorUserIndustryCategoryId { get; set; }
        [Column("IntegratorUserID")]
        public int IntegratorUserId { get; set; }
        [Column("IntegratorUserIndustryID")]
        public int IntegratorUserIndustryId { get; set; }
        [Column("IndustryCategoryID")]
        public int IndustryCategoryId { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("IndustryCategoryId")]
        [InverseProperty("IntegratorUserIndustryCategories")]
        public virtual LookupTableIndustryCategory IndustryCategory { get; set; }
        [ForeignKey("IntegratorUserId")]
        [InverseProperty("IntegratorUserIndustryCategories")]
        public virtual User IntegratorUser { get; set; }
        [ForeignKey("IntegratorUserIndustryId")]
        [InverseProperty("IntegratorUserIndustryCategories")]
        public virtual IntegratorUserIndustry IntegratorUserIndustry { get; set; }
        [InverseProperty("IntegratorUserIndustryCategory")]
        public virtual ICollection<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }
    }
}