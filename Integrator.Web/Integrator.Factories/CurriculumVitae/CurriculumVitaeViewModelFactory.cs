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

namespace Integrator.Factories.CurriculumVitae
{
    public partial class CurriculumVitaeViewModelFactory : ICurriculumVitaeViewModelFactory
    {
        #region Fields
        private readonly IUserService _userService;
        private readonly ICurriculumVitaeService _curriculumVitaeService;
        private readonly IRepository<QualificationLevels> _qualificationLevelsRepository;
        private readonly IRepository<EductaionalInstitutions> _eductaionalInstitutionRepository;
        #endregion


        #region Cstor
        public CurriculumVitaeViewModelFactory(
            IUserService userService,
            ICurriculumVitaeService curriculumVitaeService,
            IRepository<QualificationLevels> qualificationLevelsRepository,
            IRepository<EductaionalInstitutions> eductaionalInstitutionRepository
            )
        {
            this._curriculumVitaeService = curriculumVitaeService;
            this._userService = userService;
            this._qualificationLevelsRepository = qualificationLevelsRepository;
            this._eductaionalInstitutionRepository = eductaionalInstitutionRepository;
        }


        #endregion

        #region Methods

        public CurriculumVitaeViewModel PerpareCurriculumVitaeViewModel(CurriculumVitaeViewModel model, Boolean DisplayFullCurriculumVitae)
        {

            if (model == null)
                throw new ArgumentNullException(nameof(model));

            CurriculumVitea UserCurriculumVitae = _curriculumVitaeService.GetCurriculumVitea(_userService.GetUserID());
            //If User Currently Does not have a CV Generated - first create CV for the current user.
            if (UserCurriculumVitae == null)
            {
                CurriculumVitea NewCV = new CurriculumVitea()
                {
                    CareerSummary = "<h1>{Default Text REPLACE}</h1><br/><h1>Welcome</h1><br/><p> Your career summary is awaiting your creative and insightful completion.</p><br/>{ REMOVE THIS TEXT AND REPLACE WITH YOUR CAREER SUMMARY }",
                    DateLastUpdated = DateTime.Now,
                    IntegratorUserID = _userService.GetUserID()
                };
                UserCurriculumVitae = _curriculumVitaeService.AddCurriculumVitea(NewCV);

            }
            //Load All CV Sections
            if (DisplayFullCurriculumVitae)
            {
                model.Id = UserCurriculumVitae.Id;
                model.UserCareerSummary = UserCurriculumVitae.CareerSummary;
                model.DateLastUpdated = UserCurriculumVitae.DateLastUpdated;

                // CurriculumVitaeViewModel model = new CurriculumVitaeViewModel();

                IntegratorUser CurrentUser = _userService.GetCurrentLoginInUser();

                model.UserFirstName = CurrentUser.FirstName;
                model.UserLastName = CurrentUser.LastName;



                //adds any awrards the the user may have.
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
                foreach (IntegratorUserLanguages item in _userService.GetLanguages())
                {
                    model.UserLanguages.Add(new UserLanguageViewModel()
                    {
                        Id = item.Id,
                        IsPrimaryLanguage = item.IsPrimaryLanguage,
                        CanSpeakAndWrite = item.CanSpeakAndWrite,
                        Language = item.LanguageSpoken.Language
                    });
                }

                //adds any awrards the the user may have.
                foreach (IntegratorUserInterest item in _userService.GetInterests())
                {
                    model.UserInterests.Add(new UserInterestViewModel()
                    {
                        Id = item.Id,
                        InterestLevel = item.InterestLevel,
                        Interest = item.UserInterest.Interest
                    });
                }

                //adds any Qualifications the the user may have.
                foreach (UserQualifications item in _userService.GetQualifications())
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

                foreach (CurriculumViteaWorkExperiences item in _curriculumVitaeService.ListWorkExperiences(model.Id))
                {
                    var CVWEVM = new CurriculumViteaWorkExperienceViewModel()
                    {
                        Id = item.Id,
                        Company = item.Company.CompanyName,
                        JobTitle = item.Job.Description,
                        WorkExperienceDescription = item.WorkExperienceDescription,
                        Achievements = item.Achievments,
                        YearStarted = item.DateStarted.Year.ToString(),
                        YearEnded = item.DateEnded.Year.ToString()
                    };

                    IList<UserSkillViewModel> listOfUserSkills = new List<UserSkillViewModel>();
                    foreach (var InnerItem in item.CurriculumViteaWorkExperienceSkillSets.Select(a => a.IntegratorUserIndustryCategoryJobSkillSet))
                    {
                        listOfUserSkills.Add(new UserSkillViewModel()
                        {
                            Id = InnerItem.Id,
                            JobSkill = InnerItem.Description,
                            SkillLevel = Convert.ToDouble(InnerItem.SkillLevel)

                        });


                    }
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

        public EditUserQualificationViewModel prepareEditCurriuclumVitaeQualifications()
        {
            EditUserQualificationViewModel model = new EditUserQualificationViewModel();

            model.QualificationAverage = 50;

            foreach (QualificationLevels item in _qualificationLevelsRepository.Table.ToList())
            {
                model.QualificationLevels.Add(new SelectListItem()
                {
                    Text = item.QualificationLevel,
                    Value = item.Id.ToString()
                });
            }

            foreach (EductaionalInstitutions item in _eductaionalInstitutionRepository.Table.ToList())
            {
                model.EductaionalInstitutions.Add(new SelectListItem()
                {
                    Text = item.EductaionalInstitution,
                    Value = item.Id.ToString()
                });
            }
            foreach (UserQualifications item in _userService.GetQualifications())
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
        #endregion
    }
}
