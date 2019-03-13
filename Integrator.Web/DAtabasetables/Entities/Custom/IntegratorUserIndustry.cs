using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAtabasetables.Entities.Custom
{
    public partial class IntegratorUserIndustry
    {
        public IntegratorUserIndustry()
        {
            IntegratorUserIndustryCategories = new HashSet<IntegratorUserIndustryCategory>();
        }

        [Column("IntegratorUserIndustryID")]
        public int IntegratorUserIndustryId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("IndustryID")]
        public int IndustryId { get; set; }

        [ForeignKey("IndustryId")]
        [InverseProperty("IntegratorUserIndustries")]
        public virtual LookupTableIndustryType Industry { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("IntegratorUserIndustries")]
        public virtual User User { get; set; }
        [InverseProperty("IntegratorUserIndustry")]
        public virtual ICollection<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }
    }
}