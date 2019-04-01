using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class CurriculumViteaWorkExperiences : BaseEntity
    {
        public CurriculumViteaWorkExperiences()
        {
            CurriculumViteaWorkExperienceSkillSets = new HashSet<CurriculumViteaWorkExperienceSkillSets>();
            CurriculumVitaeWorkExperienceReferences = new HashSet<CurriculumVitaeWorkExperienceReferences>();
        }

        //public int UserWorkExperienceHistoryId { get; set; }
        public int CurriculumViteaID { get; set; }
        public int IntegratorUserIndustryCategoryJobID { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public int CompanyID { get; set; }
        public string Achievments { get; set; }
        public string WorkExperienceDescription { get; set; }

        public virtual CurriculumVitea CurriculumVitea { get; set; }
        public virtual IntegratorUserIndustryCategoryJob Job { get; set; }
        public virtual ICollection<CurriculumViteaWorkExperienceSkillSets> CurriculumViteaWorkExperienceSkillSets { get; set; }
        public virtual ICollection<CurriculumVitaeWorkExperienceReferences> CurriculumVitaeWorkExperienceReferences { get; set; }

        public virtual Company Company { get; set; }
    }
}