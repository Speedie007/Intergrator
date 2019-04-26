using System;
using System.Collections.Generic;
using System.Text;
using Integrator.Models.Domain.Authentication;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.CurriculumVitaes;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.CurriculumVitae;
using Integrator.Services.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Integrator.Data.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Integrator.Models.Domain.Common;
using Integrator.Services.Common;
using Integrator.Services.Common.Files;
using Integrator.Models.ViewModels.Common.Files;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Integrator.Services.KnowledgeBase.Users;
using System.Threading.Tasks;
using Integrator.Services.KnowledgeBase.Core;
using Integrator.Services.Companies;
using Integrator.Models.Domain.EnumClasses;

namespace Integrator.Factories.CurriculumVitae
{
    public partial class CurriculumVitaeViewModelFactory : ICurriculumVitaeViewModelFactory
    {
        #region Fields
        private readonly IUserService _userService;
        private readonly ICurriculumVitaeService _curriculumVitaeService;
        private readonly IQualificationService _qualificationService;
        private readonly IEducationInstitutionService _educationInstitutionService;
        private readonly IInterestService _interestService;
        private readonly ILanguageService _languageService;
        private readonly IFileService _fileService;
        private readonly IUserKnowledgeBaseService _userKnowledgeBaseService;
        private readonly ICoreKnowledgeBaseService _coreKnowledgeBaseService;
        private readonly ICompanyService _companyService;

        #endregion


        #region Cstor
        public CurriculumVitaeViewModelFactory(
            IUserService userService,
            ICurriculumVitaeService curriculumVitaeService,
            IQualificationService qualificationService,
            IEducationInstitutionService educationInstitutionService,
            IInterestService interestService,
            ILanguageService languageService,
            IFileService fileService,
            IUserKnowledgeBaseService userKnowledgeBaseService,
            ICoreKnowledgeBaseService coreKnowledgeBaseService,
            ICompanyService companyService
            )
        {
            this._curriculumVitaeService = curriculumVitaeService;
            this._userService = userService;
            this._qualificationService = qualificationService;
            this._educationInstitutionService = educationInstitutionService;
            this._interestService = interestService;
            this._languageService = languageService;
            this._fileService = fileService;
            this._userKnowledgeBaseService = userKnowledgeBaseService;
            this._coreKnowledgeBaseService = coreKnowledgeBaseService;
            this._companyService = companyService;
        }


        #endregion

        #region Methods

        public CurriculumVitaeViewModel PerpareCurriculumVitaeViewModel(CurriculumVitaeViewModel model, Boolean DisplayFullCurriculumVitae)
        {

            if (model == null)
                throw new ArgumentNullException(nameof(model));

            CurriculumVitea UserCurriculumVitae = _curriculumVitaeService.GetCurriculumVitea(_userService.GetUserID());

            //Load All CV Sections
            if (DisplayFullCurriculumVitae)
            {
                model.Id = UserCurriculumVitae.Id;
                model.UserCareerSummary = UserCurriculumVitae.CareerSummary;
                model.DateLastUpdated = UserCurriculumVitae.DateLastUpdated;

                IntegratorUser CurrentUser = _userService.GetCurrentLoginInUser();

                model.UserFirstName = CurrentUser.FirstName;
                model.UserLastName = CurrentUser.LastName;
                model.UserPicture = _userService.GetUserProfilePictureAsync().Result;


                //adds any awrards the the user may have.//.
                foreach (IntegratorUserAwards item in _userService.GetAwards())
                {
                    model.UserAwards.Add(new UserAwardViewModel()
                    {
                        Id = item.Id,
                        AwardDescription = item.AwardDescription,
                        AwardTitle = item.AwardTitle
                    });
                }

                //adds any Languages the the user may Speak.
                foreach (IntegratorUserLanguages item in _userService.GetUserLanguages())
                {
                    model.UserLanguages.Add(new UserLanguageViewModel()
                    {
                        Id = item.Id,
                        IsPrimaryLanguage = item.IsPrimaryLanguage,
                        CanSpeakAndWrite = item.CanSpeakAndWrite,
                        Language = item.SpokenLanguage.LanguageSpoken,
                        LanguageProficiencyLevel = item.LanguageProficiencyLevel
                    });
                }

                //adds any awrards the the user may have.
                foreach (IntegratorUserInterest item in _userService.GetUserInterests())
                {
                    model.UserInterests.Add(new UserInterestViewModel()
                    {
                        Id = item.Id,
                        InterestLevel = item.InterestLevel,
                        Interest = item.UserInterest.AnInterest
                    });
                }

                //adds any Qualifications the the user may have.
                foreach (UserQualification item in _userService.GetQualifications())
                {
                    model.UserQualifications.Add(new UserQualificationViewModel()
                    {
                        Id = item.Id,
                        QualificationLevel = item.QualificationLevel.QualificationLevel,
                        QualificationTitle = item.QualificationTitle,
                        YearStartedQualification = item.YearStartedQualification.Year.ToString(),
                        YearCompletedQualification = item.YearCompletedQualification.Year.ToString(),
                        EductaionalInstitution = item.EductaionalInstitution.EductaionalInstitution,
                        QualificationAverage = item.QualificationAverage
                    });
                }

                //Adds all user jobs Listed -[Curriculum Vitae Experience Deatils]
                foreach (UserJob item in _userKnowledgeBaseService.ListUserJobByCurriculumVitae(model.Id))
                {
                    var CVWEVM = new CurriculumViteaWorkExperienceViewModel()
                    {
                        Id = item.Id,
                        Company = item.Company.CompanyName,
                        JobTitle = item.CoreKbJob.CoreKbJobTitle,
                        WorkExperienceDescription = item.WorkExperienceDescription,
                        Achievements = item.Achievments,
                        YearStarted = item.DateStarted.Year.ToString(),
                        YearEnded = item.DateEnded.Year.ToString()
                    };

                    CVWEVM.ListOfHardSkillsEmployed = _userKnowledgeBaseService.ListUserHardSkillsPerUserJob(item.Id);
                    CVWEVM.ListOfSoftSkillsEmployed = _userKnowledgeBaseService.ListUserSoftSkillsPerUserJob(item.Id);
                    //foreach (UserJobSkill InnerItem in item.UserJobSkills)
                    //{
                    //    //var y = CVWEVM.Select(x => x.JobSkill).FirstOrDefault();
                    //    CVWEVM.SkillsEmployed.Add(new UserSkillViewModel()
                    //    {
                    //        Id = InnerItem.Id,
                    //        JobSkill = InnerItem.CoreKbSkill.CoreSkill,
                    //        SkillLevel = InnerItem.UserJobSkillLevel
                    //    });
                    //}
                    model.UserWorkExperiences.Add(CVWEVM);
                }
            }
            else
            {
                model.Id = UserCurriculumVitae.Id;

                IntegratorUser CurrentUser = _userService.GetCurrentLoginInUser();

                model.UserFirstName = CurrentUser.FirstName;
                model.UserLastName = CurrentUser.LastName;

                model.UserCareerSummary = UserCurriculumVitae.CareerSummary;
                model.DateLastUpdated = UserCurriculumVitae.DateLastUpdated;
            }

            return model;
        }

        public EditUserInterestViewModel prepareEditCurriculumVitaeInterests()
        {


            EditUserInterestViewModel model = new EditUserInterestViewModel();

            model.InterestLevel = 50;

            foreach (Interest item in _interestService.ListInterests().Except((from a in _userService.GetUserInterests()
                                                                               select new Interest()
                                                                               {
                                                                                   Id = a.InterestID,
                                                                                   AnInterest = a.UserInterest.AnInterest
                                                                               }).ToList(), new InterestComparer()).ToList())
            {
                model.Interests.Add(new SelectListItem()
                {
                    Text = item.AnInterest,
                    Value = item.Id.ToString()
                });
            }

            foreach (IntegratorUserInterest item in _userService.GetUserInterests())
            {
                model.UserInterests.Add(new UserInterestViewModel()
                {
                    Id = item.Id,
                    Interest = item.UserInterest.AnInterest,
                    InterestLevel = item.InterestLevel
                });
            }

            return model;

        }

        public EditUserLanguageViewModel PrepareEditCurriculumVitaeLanguages()
        {
            EditUserLanguageViewModel model = new EditUserLanguageViewModel();

            model.LanguageProficiencyLevel = 50;
            model.CanSpeakAndWrite = false;
            model.IsPrimaryLanguage = false;

            var ListOfAllLanguages = _languageService.ListLanguages();
            //populate List of all languages
            foreach (Language item in ListOfAllLanguages.Except((from a in _userService.GetUserLanguages()
                                                                 select new Language()
                                                                 {
                                                                     Id = a.LanguageID,
                                                                     LanguageSpoken = a.SpokenLanguage.LanguageSpoken
                                                                 }).ToList(), new LanguageComparer()).ToList())
            {

                model.ListOfLanguages.Add(new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.LanguageSpoken
                });
            }



            //populate user assoicciated languages

            foreach (var item in _userService.GetUserLanguages())
            {
                model.ListOfUserLanguages.Add(new UserLanguageViewModel()
                {
                    Id = item.Id,
                    CanSpeakAndWrite = item.CanSpeakAndWrite,
                    IsPrimaryLanguage = item.IsPrimaryLanguage,
                    LanguageProficiencyLevel = item.LanguageProficiencyLevel,
                    Language = item.SpokenLanguage.LanguageSpoken
                });
            }

            return model;
        }

        public EditUserQualificationViewModel prepareEditCurriuclumVitaeQualifications()
        {
            EditUserQualificationViewModel model = new EditUserQualificationViewModel();

            model.QualificationAverage = 50;

            foreach (QualificationLevels item in _qualificationService.ListQualificationLevels())
            {
                model.QualificationLevels.Add(new SelectListItem()
                {
                    Text = item.QualificationLevel,
                    Value = item.Id.ToString()
                });
            }

            foreach (EductaionalInstitutions item in _educationInstitutionService.ListEductaionalInstitutions())
            {
                model.EductaionalInstitutions.Add(new SelectListItem()
                {
                    Text = item.EductaionalInstitution,
                    Value = item.Id.ToString()
                });
            }
            foreach (UserQualification item in _userService.GetQualifications())
            {
                model.UserQualifications.Add(new UserQualificationViewModel()
                {
                    Id = item.Id,
                    QualificationTitle = item.QualificationTitle,
                    YearStartedQualification = item.YearStartedQualification.Year.ToString(),
                    YearCompletedQualification = item.YearCompletedQualification.Year.ToString(),
                    EductaionalInstitution = item.EductaionalInstitution.EductaionalInstitution,
                    QualificationLevel = item.QualificationLevel.QualificationLevel,
                    QualificationAverage = item.QualificationAverage
                });
            }

            return model;
        }

        public EditUserAwardViewModel PrepareEditCurriculumVitaeAwards()
        {

            EditUserAwardViewModel model = new EditUserAwardViewModel();

            foreach (var item in _userService.GetAwards())
            {
                model.UserAwards.Add(new UserAwardViewModel()
                {
                    Id = item.Id,
                    AwardDescription = item.AwardDescription,
                    AwardTitle = item.AwardTitle
                });
            }
            return model;
        }

        public EditUserCurriculumViteaWorkExperienceViewModel prepareEditCurriuclumVitaeWorkExperiences()
        {
            EditUserCurriculumViteaWorkExperienceViewModel model = new EditUserCurriculumViteaWorkExperienceViewModel();


            //populates all known Industry Categories
            foreach (var item in _coreKnowledgeBaseService.ListIndustryCategories())
            {
                model.ListOfIndustryCategories.Add(new SelectListItem()
                {
                    Text = item.CoreKbIndustryCategoryName,
                    Value = item.Id.ToString()
                });
            }

            //populates all Hard Skill Categories
            foreach (var item in _coreKnowledgeBaseService.ListSkillCategoriesBySkillType((int)EnumKbSkillType.HardSkill))
            {
                model.ListOfHardSkillCategories.Add(new SelectListItem()
                {
                    Text = item.CoreSkillCategoryName,
                    Value = item.Id.ToString()
                });
            }

            //populates all Soft skill Categories
            foreach (var item in _coreKnowledgeBaseService.ListSkillCategoriesBySkillType((int)EnumKbSkillType.SoftSkill))
            {
                model.ListOfSoftSkillCategories.Add(new SelectListItem()
                {
                    Text = item.CoreSkillCategoryName,
                    Value = item.Id.ToString()
                });
            }

            //populates all known Industry Categories
            foreach (var item in _companyService.ListCompanies())
            {
                model.ListOfCompanies.Add(new SelectListItem()
                {
                    Text = item.CompanyName,
                    Value = item.Id.ToString()
                });
            }

            //populates all known Job Title 
            foreach (var item in _coreKnowledgeBaseService.ListJobs())
            {
                model.ListOfJobTitles.Add(new SelectListItem()
                {
                    Text = item.CoreKbJobTitle,
                    Value = item.Id.ToString()
                });
            }

            //populates list of Curriculum Vitea Work Experience ITems
            foreach (var item in _userService.ListUserJobs())
            {
                model.ListOfUserJobs.Add(new CurriculumViteaWorkExperienceViewModel()
                {
                    Id = item.Id,
                    JobTitle = item.CoreKbJob.CoreKbJobTitle,
                    Company = item.Company.CompanyName,
                    YearStarted = item.DateStarted.Year.ToString(),
                    YearEnded = item.DateEnded.Year.ToString()

                });
            }



            return model;
        }

        public EditUserPictureViewModel PrepareEditCurriculumViteaPictures()
        {
            EditUserPictureViewModel model = new EditUserPictureViewModel();

            model.DefaultPictureID = 0;

            foreach (var item in _fileService.ListUserProfilePictures(true))
            {
                if (item.IsCurrentProfilePicture)
                {
                    model.DefaultPictureID = item.Id;
                }
                model.UserProfileImages.Add(new FileViewModel()
                {
                    Id = item.Id,
                    ContentType = item.IntegratorFile.ContentType,
                    FileName = item.IntegratorFile.FileName,
                    FileExtension = item.IntegratorFile.FileExtension,
                    FileSize = item.IntegratorFile.FileSize,
                    DateCreated = item.IntegratorFile.DateCreated,
                    FileBytes = item.IntegratorFile.InegratorFileBlob.FileBlob
                });
            }

            return model;
        }

        public EditUserCurriculumViteaWorkExperienceViewModel prepareEditSingleCurriuclumVitaeWorkExperiences(int UserJobID)
        {
            UserJob SelectedUserJob = _userKnowledgeBaseService.GetUserJob(UserJobID);

            EditUserCurriculumViteaWorkExperienceViewModel model = new EditUserCurriculumViteaWorkExperienceViewModel()
            {
                CompanyID = SelectedUserJob.CompanyID.ToString(),
                CoreKbJobID = SelectedUserJob.CoreKbJobID.ToString(),
                YearStarted = SelectedUserJob.DateStarted.Year.ToString(),
                YearEnded = SelectedUserJob.DateEnded.Year.ToString(),
                Achievements = SelectedUserJob.Achievments,
                WorkExperienceDescription = SelectedUserJob.WorkExperienceDescription
            };

            foreach (var item in _userKnowledgeBaseService.ListUserHardSkillsPerUserJob(UserJobID))
            {
                model.ListOfSelectedSkillAndIndustryForEntry.Add(new InternalWorkExperienceDataStructure()
                {
                    DataType = "HARDSKILL_TYPE",
                    SelectedCategory = item.SkillCategoryName,
                    SelectedCategoryID = item.SkillCategoryID,
                    SelectedDataItem = new InternalReturnItem()
                    {
                        DataItemID = item.Id.ToString(),
                        DataItemTEXT = item.JobSkill,
                        DataItemLevel = item.SkillLevel.ToString()
                    }
                });
            }

            foreach (var item in _userKnowledgeBaseService.ListUserSoftSkillsPerUserJob(UserJobID))
            {
                model.ListOfSelectedSkillAndIndustryForEntry.Add(new InternalWorkExperienceDataStructure()
                {
                    DataType = "SOFTSKILL_TYPE",
                    SelectedCategory = item.SkillCategoryName,
                    SelectedCategoryID = item.SkillCategoryID,
                    SelectedDataItem = new InternalReturnItem()
                    {
                        DataItemID = item.Id.ToString(),
                        DataItemTEXT = item.JobSkill,
                        DataItemLevel = item.SkillLevel.ToString()
                    }
                });
            }

            foreach (var item in _userKnowledgeBaseService.ListUserIndusrtyPerUserJob(UserJobID))
            {
                model.ListOfSelectedSkillAndIndustryForEntry.Add(new InternalWorkExperienceDataStructure()
                {
                    DataType = "INDUSTRY_TYPE",
                    SelectedCategory = item.IndustryCategoryName,
                    SelectedCategoryID = item.IndustryCategoryID,
                    SelectedDataItem = new InternalReturnItem()
                    {
                        DataItemID = item.Id.ToString(),
                        DataItemTEXT = item.JobIndustry,
                        DataItemLevel = item.IndustryLevelInvolvement.ToString()
                    }
                });
            }

            return model;
        }

        //public EditUserPictureViewModel PrepareEditCurriculumViteaPictures()
        //{
        //    //EditUserPictureViewModel model = new EditUserAwardViewModel();

        //    //foreach (var item in _userService.GetAwards())
        //    //{
        //    //    model.UserAwards.Add(new UserAwardViewModel()
        //    //    {
        //    //        Id = item.Id,
        //    //        AwardDescription = item.AwardDescription,
        //    //        AwardTitle = item.AwardTitle
        //    //    });
        //    //}
        //    //return model;
        //}


        #endregion
    }
}
