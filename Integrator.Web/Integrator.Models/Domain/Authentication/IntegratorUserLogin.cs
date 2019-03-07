using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Authentication
{
    public partial class IntegratorUserLogin : IdentityUserLogin<int>
    {
        public IntegratorUserLogin() : base() { }
        public virtual IntegratorUser IntegratorUser { get; set; }
    }
}
