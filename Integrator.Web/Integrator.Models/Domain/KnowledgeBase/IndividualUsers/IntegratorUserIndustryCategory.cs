using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUsers
{
    public partial class IntegratorUserIndustryCategory : BaseEntity
    {
        public IntegratorUserIndustryCategory()
        {
            IntegratorUserIndustryCategoryJobs = new HashSet<IntegratorUserIndustryCategoryJob>();
        }

        public int IntegratorUserID { get; set; }

        public int IntegratorUserIndustryID { get; set; }

        public int CoreKBIndustryCategoryID { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }

        public virtual CoreKBIndustryCategory CoreKBIndustryCategory { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }

        public virtual IntegratorUserIndustry IntegratorUserIndustry { get; set; }

        public virtual ICollection<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }

    }
}