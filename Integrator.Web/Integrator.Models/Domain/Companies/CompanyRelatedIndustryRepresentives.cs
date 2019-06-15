using Integrator.Models;
using Integrator.Models.Domain.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyRelatedIndustryRepresentive:BaseEntity
    {
       
        public int CompanyRelatedIndustryID { get; set; }
        public int CompanyRepresentativeID { get; set; }
        public DateTime DateAssigned { get; set; }

        public virtual CompanyRelatedIndustry CompanyRelatedIndustry { get; set; }
        public virtual CompanyRepresentative CompanyRepresentative { get; set; }
    }
}