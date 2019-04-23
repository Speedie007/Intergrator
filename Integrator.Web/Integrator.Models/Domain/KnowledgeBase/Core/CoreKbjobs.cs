using Integrator.Models.Domain.KnowledgeBase.Companies;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Core
{
    public partial class CoreKbJob :BaseEntity
    {
        public CoreKbJob()
        {
            CompanyJobs = new HashSet<CompanyJob>();
            CoreKbIndustryJobs = new HashSet<CoreKbIndustryJob>();
            CoreKbJobSkills = new HashSet<CoreKbJobSkill>();
            UserJobs = new HashSet<UserJob>();
        }

        
        public string CoreKbJobTitle { get; set; }

        public virtual ICollection<CompanyJob> CompanyJobs { get; set; }
        public virtual ICollection<CoreKbIndustryJob> CoreKbIndustryJobs { get; set; }
        public virtual ICollection<CoreKbJobSkill> CoreKbJobSkills { get; set; }
        public virtual ICollection<UserJob> UserJobs { get; set; }
    }
}