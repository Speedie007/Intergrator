using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    [Table("LookupTable_IndustryCategories")]
    public partial class LookupTableIndustryCategory
    {
        public LookupTableIndustryCategory()
        {
            CompanyIndustryCategories = new HashSet<CompanyIndustryCategory>();
            IntegratorUserIndustryCategories = new HashSet<IntegratorUserIndustryCategory>();
            LookupTableIndustryCategoryJobs = new HashSet<LookupTableIndustryCategoryJob>();
        }

        [Column("IndustryCategoryID")]
        public int IndustryCategoryId { get; set; }
        [Column("IndustryID")]
        public int IndustryId { get; set; }

        [ForeignKey("IndustryId")]
        [InverseProperty("LookupTableIndustryCategories")]
        public virtual LookupTableIndustryType Industry { get; set; }
        [InverseProperty("IndustryCategory")]
        public virtual ICollection<CompanyIndustryCategory> CompanyIndustryCategories { get; set; }
        [InverseProperty("IndustryCategory")]
        public virtual ICollection<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }
        [InverseProperty("IndustryCategory")]
        public virtual ICollection<LookupTableIndustryCategoryJob> LookupTableIndustryCategoryJobs { get; set; }
    }
}