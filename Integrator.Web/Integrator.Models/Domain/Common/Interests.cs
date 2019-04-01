using Integrator.Models.Domain.CurriculumVitaes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Integrator.Models.Domain.Common
{
    public partial class Interests : BaseEntity
    {
        public Interests()
        {
            IntegratorUserInterests = new HashSet<IntegratorUserInterest>();
        }

        
        public string Interest { get; set; }

        public virtual ICollection<IntegratorUserInterest> IntegratorUserInterests { get; set; }
    }
}