using Integrator.Models.Domain.Common;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class WorkExperienceReferenceContactDetail : BaseEntity
    {
        //public int WorkExperienceReferenceContactDetailId { get; set; }
        public int ContactDetailID { get; set; }
        public int CurriculumVitaeWorkExperienceReferenceID { get; set; }

        public virtual ContactDetail ContactDetail { get; set; }
        public virtual CurriculumVitaeWorkExperienceReferences CurriculumVitaeWorkExperienceReference { get; set; }
    }
}