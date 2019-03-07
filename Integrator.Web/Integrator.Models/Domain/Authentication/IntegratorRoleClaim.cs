using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Authentication
{
    public partial class IntegratorRoleClaim : IdentityRoleClaim<int>
    {
        public IntegratorRoleClaim() : base() { }
        public virtual IntegratorRole Role { get; set; }
    }
}
