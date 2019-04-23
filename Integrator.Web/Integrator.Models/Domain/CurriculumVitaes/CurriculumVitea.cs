using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.CurriculumVitaes
{
    public partial class CurriculumVitea : BaseEntity
    {
        public CurriculumVitea()
        {
            UserJobs = new HashSet<UserJob>();
        }

        //public int CurriculumViteaId { get; set; }
        public int IntegratorUserID { get; set; }
        public DateTime DateLastUpdated { get; set; }
        public string CareerSummary { get; set; }

        public virtual ICollection<UserJob> UserJobs { get; set; }

        public virtual IntegratorUser IntegratorUser { get; set; }
        
        ///
        

        
    }
}