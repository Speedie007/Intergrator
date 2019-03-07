using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Models.Domain.Authentication
{
    public partial class IntegratorUser : IdentityUser<int>
    {
        public IntegratorUser() : base()
        {
            this.Init();
        }

        public IntegratorUser(string UserName) : base(UserName) { this.Init(); }

        protected virtual void Init()
        {
            //Addresses = new List<Address>();
            //BoatHouseRentals = new List<BoatHouseRental>();
            //AffiliatedMembers = new List<AffiliatedMember>();
            //CampSiteBookings = new List<CampSiteBooking>();
            //MemberItems = new List<MemberItem>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }

        public virtual ICollection<IntegratorUserClaim> Claims { get; set; }
        public virtual ICollection< IntegratorUserLogin> Logins { get; set; }
        public virtual ICollection<IntegratorUserToken> Tokens { get; set; }
        public virtual ICollection<IntegratorUserRole> UserRoles { get; set; }
    }
}
