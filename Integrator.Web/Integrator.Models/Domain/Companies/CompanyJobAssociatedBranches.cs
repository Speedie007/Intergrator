using Integrator.Models.Domain.KnowledgeBase.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyJobAssociatedBranch: BaseEntity
    {
        public int CompanyJobID { get; set; }
        public int CompanyBranchID { get; set; }

        public virtual CompanyBranch CompanyBranch { get; set; }
        public virtual CompanyJob CompanyJob { get; set; }
    }
}