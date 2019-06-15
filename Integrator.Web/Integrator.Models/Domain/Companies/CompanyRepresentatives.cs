using Integrator.Models;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyRepresentative : BaseEntity
    {
        public CompanyRepresentative()
        {
            CompanyJobRepresentitives = new HashSet<CompanyJobRepresentitive>();
            CompanyRelatedIndustryRepresentives = new HashSet<CompanyRelatedIndustryRepresentive>();
        }
        public int IntegratorUserID { get; set; }
        public int CompanyID { get; set; }

        public virtual Company Company { get; set; }
        public virtual IntegratorUser IntegratorUser { get; set; }
        public virtual ICollection<CompanyJobRepresentitive> CompanyJobRepresentitives { get; set; }
        public virtual ICollection<CompanyRelatedIndustryRepresentive> CompanyRelatedIndustryRepresentives { get; set; }
    }
}