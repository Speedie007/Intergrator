using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Authentication
{
    public partial class IntegratorUserClaim: IdentityUserClaim<int>
    {
        public IntegratorUserClaim() : base() { }
        public virtual IntegratorUser IntegratorUser { get; set; }
    }
}
