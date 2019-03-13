using Integrator.Models.Domain.KnowledgeBase.IndividualUser;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

            IntegratorUserIndustries = new HashSet<IntegratorUserIndustry>();
            IntegratorUserIndustryCategories = new HashSet<IntegratorUserIndustryCategory>();
            IntegratorUserIndustryCategoryJobSkillSets = new HashSet<IntegratorUserIndustryCategoryJobSkillSet>();
            IntegratorUserIndustryCategoryJobs = new HashSet<IntegratorUserIndustryCategoryJob>();
            //Addresses = new List<Address>();
            //BoatHouseRentals = new List<BoatHouseRental>();
            //AffiliatedMembers = new List<AffiliatedMember>();
            //CampSiteBookings = new List<CampSiteBooking>();
            //MemberItems = new List<MemberItem>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }

        #region User Authentication
        public virtual ICollection<IntegratorUserClaim> Claims { get; set; }
        public virtual ICollection<IntegratorUserLogin> Logins { get; set; }
        public virtual ICollection<IntegratorUserToken> Tokens { get; set; }
        public virtual ICollection<IntegratorUserRole> UserRoles { get; set; }
        #endregion User Authentication

        #region User Knowledgebase
        [InverseProperty("IntegratorUser")]
        public virtual ICollection<IntegratorUserIndustry> IntegratorUserIndustries { get; set; }
        [InverseProperty("IntegratorUser")]
        public virtual ICollection<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }
        [InverseProperty("IntegratorUser")]
        public virtual ICollection<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }
        [InverseProperty("IntegratorUser")]
        public virtual ICollection<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }
        #endregion User Knowledgebase
    }
}
