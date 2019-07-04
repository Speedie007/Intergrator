using Integrator.Models;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyRepresentiveBranch:BaseEntity
    {
        
        public int CompanyBranchID { get; set; }
        public int CompanyRepresentativeID { get; set; }

        public virtual CompanyBranch CompanyBranch { get; set; }
        public virtual CompanyRepresentative CompanyRepresentative { get; set; }
    }
}