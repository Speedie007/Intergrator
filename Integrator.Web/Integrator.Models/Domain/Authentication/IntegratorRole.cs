using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Authentication
{
    public partial class IntegratorRole : IdentityRole<int>
    {
        public IntegratorRole() : base() { }
        public IntegratorRole(string roleName) : base(roleName) { }

        public virtual ICollection<IntegratorUserRole> UserRoles { get; set; }
        public virtual ICollection<IntegratorRoleClaim> RoleClaims { get; set; }
    }

    
}
