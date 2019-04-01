using Integrator.Models.Domain.Authentication;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class IntegratorUserAwards : BaseEntity
    {
       // public int IntegratorUserAwardId { get; set; }
        public int IntegratorUserID { get; set; }
        public string AwardTitle { get; set; }
        public string AwardDescription { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }
    }
}