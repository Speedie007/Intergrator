using Integrator.Models;
using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.KnowledgeBase.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyJobRepresentitive : BaseEntity
    {
        
        public int CompanyRepresentativeID { get; set; }
        public int CompanyJobID { get; set; }

        public virtual CompanyJob CompanyJob { get; set; }
        public virtual CompanyRepresentative CompanyRepresentative { get; set; }
    }
}