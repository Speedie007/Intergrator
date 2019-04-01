using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.Common;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class IntegratorUserInterest : BaseEntity
    {

        public int IntegratorUserID { get; set; }
        public int InterestID { get; set; }
        public double InterestLevel { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }
        public virtual Interests UserInterest { get; set; }


    }
}