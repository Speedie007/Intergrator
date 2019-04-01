
//using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Integrator.Models.Domain.Common;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.Domain.Files;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
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
            #region Knowledge Base
            IntegratorUserIndustries = new HashSet<IntegratorUserIndustry>();
            IntegratorUserIndustryCategories = new HashSet<IntegratorUserIndustryCategory>();
            IntegratorUserIndustryCategoryJobSkillSets = new HashSet<IntegratorUserIndustryCategoryJobSkillSet>();
            IntegratorUserIndustryCategoryJobs = new HashSet<IntegratorUserIndustryCategoryJob>();
            #endregion

            #region User Pictures and Files
            UserFiles = new HashSet<UserFiles>();
            UserPicture = new HashSet<UserPictures>();

            #endregion

            #region CurriculumVitae
            IntegratorUserInterests = new HashSet<IntegratorUserInterest>();
            IntegratorUserLanguages = new HashSet<IntegratorUserLanguages>();
            UserQualifications = new HashSet<UserQualifications>();
            CurriculumViteas = new HashSet<CurriculumVitea>();
            IntegratorUserAwards = new HashSet<IntegratorUserAwards>();
            #endregion


        }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }

        [NotMapped]
        public string FullName => FirstName + " " + LastName;

        #region User Authentication
        public virtual ICollection<IntegratorUserClaim> Claims { get; set; }
        public virtual ICollection<IntegratorUserLogin> Logins { get; set; }
        public virtual ICollection<IntegratorUserToken> Tokens { get; set; }
        public virtual ICollection<IntegratorUserRole> UserRoles { get; set; }
        #endregion User Authentication



        #region User Knowledgebase
        public virtual ICollection<IntegratorUserIndustry> IntegratorUserIndustries { get; set; }

        public virtual ICollection<IntegratorUserIndustryCategory> IntegratorUserIndustryCategories { get; set; }

        public virtual ICollection<IntegratorUserIndustryCategoryJobSkillSet> IntegratorUserIndustryCategoryJobSkillSets { get; set; }

        public virtual ICollection<IntegratorUserIndustryCategoryJob> IntegratorUserIndustryCategoryJobs { get; set; }
        #endregion User Knowledgebase

        #region User Pictures and Files
        public virtual ICollection<UserFiles> UserFiles { get; set; }
        public virtual ICollection<UserPictures> UserPicture { get; set; }

        #endregion

        #region Curriculum Vitae
        public virtual ICollection<CurriculumVitea> CurriculumViteas { get; set; }
        public virtual ICollection<IntegratorUserAwards> IntegratorUserAwards { get; set; }
        public virtual ICollection<IntegratorUserInterest> IntegratorUserInterests { get; set; }
        public virtual ICollection<IntegratorUserLanguages> IntegratorUserLanguages { get; set; }
        public virtual ICollection<UserQualifications> UserQualifications { get; set; }
        #endregion

        #region Contact Details
        public virtual ICollection<IntegratorUserContactDetails> IntegratorUserContactDetails { get; set; }

        #endregion

       

    }
}
