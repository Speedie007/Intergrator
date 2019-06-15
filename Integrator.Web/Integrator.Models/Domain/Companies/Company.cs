//using Integrator.Models.Domain.KnowledgeBase.Companies;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.Domain.KnowledgeBase.Companies;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Integrator.Models.Domain.Companies
{
    public partial class Company : BaseEntity
    {
       
        public Company()
        {
            CompanyRepresentatives = new HashSet<CompanyRepresentative>();
            CompanyAddresses = new HashSet<CompanyAddress>();
            CompanyContactDetails = new HashSet<CompanyContactDetail>();
            CompanyJobs = new HashSet<CompanyJob>();
            CompanyRelatedIndustries = new HashSet<CompanyRelatedIndustry>();
            #region CV
            UserJobs = new HashSet<UserJob>();
            
            #endregion
        }

        
        public string CompanyName { get; set; }

        public virtual ICollection<CompanyJob> CompanyJobs { get; set; }
        public virtual ICollection<CompanyRelatedIndustry> CompanyRelatedIndustries { get; set; }

        public virtual ICollection<UserJob> UserJobs { get; set; }
        //public virtual ICollection<CurriculumViteaWorkExperiences> CurriculumViteaWorkExperiences { get; set; }

        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }
        public virtual ICollection<CompanyContactDetail> CompanyContactDetails { get; set; }
        public virtual ICollection<CompanyRepresentative> CompanyRepresentatives { get; set; }

    }
}
