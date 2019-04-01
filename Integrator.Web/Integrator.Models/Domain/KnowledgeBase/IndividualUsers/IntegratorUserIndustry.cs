using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUsers
{
    public partial class IntegratorUserIndustry : BaseEntity
    {
        public IntegratorUserIndustry()
        {
            IntegratorUserIndustryCategories = new HashSet<IntegratorUserIndustryCategory>();
        }

        public int IntegratorUserID { get; set; }

        public int CoreKBIndustryID { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public virtual CoreKBIndustryType CoreKBIndustry { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }

        public virtual ICollection<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }
        
    }
}