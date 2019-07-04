using Integrator.Models.Domain.Addresses;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyBranchAddress:BaseEntity
    {
        
        public int CompanyBranchID { get; set; }
        public int AddressID { get; set; }

        public virtual Address Address { get; set; }
        public virtual CompanyBranch CompanyBranch { get; set; }
    }
}