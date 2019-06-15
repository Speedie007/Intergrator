using Integrator.Models;
using Integrator.Models.Domain.Common;
using Integrator.Models.Domain.Companies;
using System;
using System.Collections.Generic;

namespace Integrator.Models.Domain.Companies
{
    public partial class CompanyContactDetail :BaseEntity
    {
        
        public int ContactDetailID { get; set; }
        public int CompanyID { get; set; }

        public virtual Company Company { get; set; }
        public virtual ContactDetail ContactDetail { get; set; }
    }
}