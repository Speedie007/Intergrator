using Integrator.Models;
using Integrator.Models.Domain.Addresses;
using Integrator.Models.Domain.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyAddress:BaseEntity
    {
        
        public int AddressID { get; set; }
        public int CompanyID { get; set; }

        public virtual Address Address { get; set; }
        public virtual Company Company { get; set; }
    }
}