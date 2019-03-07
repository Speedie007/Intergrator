using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Authentication
{
    public partial class IntegratorUserRole : IdentityUserRole<int>
    {
        public IntegratorUserRole() : base() { }
        public virtual IntegratorUser IntegratorUser { get; set; }
        public virtual IntegratorRole Role { get; set; }
    }
}
