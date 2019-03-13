using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUser
{
    public partial class IntegratorUserIndustryCategory : BaseEntity
    {
        public IntegratorUserIndustryCategory()
        {
            IntegratorUserIndustryCategoryJobs = new HashSet<IntegratorUserIndustryCategoryJob>();
        }

        [Column("IntegratorUserIndustryCategoryID")]
        public int IntegratorUserIndustryCategoryID { get; set; }
        [Column("IntegratorUserID")]
        public int IntegratorUserID { get; set; }
        [Column("IntegratorUserIndustryID")]
        public int IntegratorUserIndustryID { get; set; }
        [Column("IndustryCategoryID")]
        public int IndustryCategoryID { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        [ForeignKey("IndustryCategoryID")]
        [InverseProperty("IntegratorUserIndustryCategories")]
        public virtual LookupTableIndustryCategory IndustryCategory { get; set; }
        [ForeignKey("IntegratorUserID")]
        [InverseProperty("IntegratorUserIndustryCategories")]
        public virtual IntegratorUser IntegratorUser { get; set; }
        [ForeignKey("IntegratorUserIndustryID")]
        [InverseProperty("IntegratorUserIndustryCategories")]
        public virtual IntegratorUserIndustry IntegratorUserIndustry { get; set; }
        [InverseProperty("IntegratorUserIndustryCategory")]
        public virtual ICollection<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }

    }
}