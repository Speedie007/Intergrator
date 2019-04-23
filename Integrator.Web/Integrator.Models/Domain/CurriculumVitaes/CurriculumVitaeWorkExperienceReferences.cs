using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class CurriculumVitaeWorkExperienceReferences : BaseEntity
    {
        public CurriculumVitaeWorkExperienceReferences()
        {
            WorkExperienceReferenceContactDetails = new HashSet<WorkExperienceReferenceContactDetail>();
        }

        //public int CurriculumVitaeWorkExperienceReferenceId { get; set; }
        public int CurriculumViteaWorkExperienceID { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public bool HasBeenVerified { get; set; }

        //public virtual CurriculumViteaWorkExperiences CurriculumViteaWorkExperience { get; set; }
        public virtual ICollection<WorkExperienceReferenceContactDetail> WorkExperienceReferenceContactDetails { get; set; }
    }
}