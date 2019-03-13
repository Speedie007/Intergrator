using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.KnowledgeBase.IndividualUser
{
    public partial class IntegratorUserIndustry : BaseEntity
    {
        public IntegratorUserIndustry()
        {
            IntegratorUserIndustryCategories = new HashSet<IntegratorUserIndustryCategory>();
        }

        //[Column("IntegratorUserIndustryID")]
        //public int IntegratorUserIndustryId { get; set; }
        [Column("IntegratorUserID")]
        public int IntegratorUserID { get; set; }
        [Column("IndustryID")]
        public int IndustryID { get; set; }

        public string Description { get; set; }

        [ForeignKey("IndustryID")]
        [InverseProperty("IntegratorUserIndustries")]
        public virtual LookupTableIndustryType Industry { get; set; }
        [ForeignKey("IntegratorUserID")]
        [InverseProperty("IntegratorUserIndustries")]
        public virtual IntegratorUser IntegratorUser { get; set; }
        [InverseProperty("IntegratorUserIndustry")]
        public virtual ICollection<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }
        
    }
}