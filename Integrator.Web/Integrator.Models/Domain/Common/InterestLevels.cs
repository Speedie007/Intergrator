using Integrator.Models.Domain.CurriculumVitaes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Common
{
    public partial class InterestLevels : BaseEntity
    {
        public InterestLevels()
        {
            IntegratorUserInterests = new HashSet<IntegratorUserInterests>();
        }

        //public int InterestLevelId { get; set; }
        public string InterestLevel { get; set; }

        public virtual ICollection<IntegratorUserInterests> IntegratorUserInterests { get; set; }
    }
}