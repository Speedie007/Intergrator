using Integrator.Models.Domain.Authentication;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class CurriculumVitea : BaseEntity
    {
        public CurriculumVitea()
        {
            CurriculumViteaWorkExperiences = new HashSet<CurriculumViteaWorkExperiences>();
        }

        //public int CurriculumViteaId { get; set; }
        public int IntegratorUserID { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string CareerSummary { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }
        public virtual ICollection<CurriculumViteaWorkExperiences> CurriculumViteaWorkExperiences { get; set; }
    }
}