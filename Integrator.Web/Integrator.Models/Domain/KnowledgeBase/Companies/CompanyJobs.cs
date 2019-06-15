using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.KnowledgeBase.Core;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.KnowledgeBase.Companies
{
    public partial class CompanyJob:BaseEntity
    {
        public CompanyJob()
        {
            CompanyJobRelatedIndustries = new HashSet<CompanyJobRelatedIndustry>();
            CompanyJobListings = new HashSet<CompanyJobListing>();
            CompanyJobSkills = new HashSet<CompanyJobSkill>();
            CompanyJobRepresentitives = new HashSet<CompanyJobRepresentitive>();
        }

        
        public int CompanyID { get; set; }
        public int CoreKbJobID { get; set; }
        public string JobDescription { get; set; }

        public virtual Company Company { get; set; }
        public virtual CoreKbJob CoreKbJob { get; set; }
        public virtual ICollection<CompanyJobRelatedIndustry> CompanyJobRelatedIndustries { get; set; }
        public virtual ICollection<CompanyJobListing> CompanyJobListings { get; set; }
        public virtual ICollection<CompanyJobSkill> CompanyJobSkills { get; set; }
        public virtual ICollection<CompanyJobRepresentitive> CompanyJobRepresentitives { get; set; }
    }
}