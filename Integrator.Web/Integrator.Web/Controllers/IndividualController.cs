using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Factories.Users;
using Integrator.Models.ViewModels.Common;
using Integrator.Models.ViewModels.CurriculumVitaes;
using Integrator.Models.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace Integrator.Web.Controllers.Individuals
{
    public class IndividualController : Controller
    {

        #region Fields
        private readonly IUserViewModelFactory _userViewModelFactory;




        #endregion

        #region Cstor
        public IndividualController(IUserViewModelFactory userViewModelFactory)
        {
            this._userViewModelFactory = userViewModelFactory;
        }
        #endregion

        public IActionResult DashBoard()
        {
            return View();
        }


        #region Profile

        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditProfile()
        {
            return View();
        }
        public IActionResult EditProfile(string x)
        {
            return View();
        }
        #endregion

        #region CurriculumVitae

        [HttpGet]
        public IActionResult CurriculumVitae()
        {
            //From demo and development purposes
            /*
             * Todo must implement CV factory to populate the model
             * */

            CurriculumVitaeViewModel model = new CurriculumVitaeViewModel()
            {
                Id = 1,
                UserPicture = new byte[10],
                UserFirstName = "Brendan",
                UserLastName = "Wood",
                CurrentJobTitle = "Senior IT Lecturer",
                UserCareerSummary = "Summarise your career here. [Content]. You can download this free resume/CV template here. [Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content][Content].",
                ContactDetails = new List<UserContactDetailViewModel>() {
                     new UserContactDetailViewModel()
                     {
                          Id = 1,
                            ContactDetailType = "Email",
                             ContactDetailValue = "Brendanw@mweb.co.za",
                              DateLastUpdated = DateTime.Now
                     },
                     new UserContactDetailViewModel()
                     {
                          Id = 2,
                            ContactDetailType = "Cell",
                             ContactDetailValue = "0823349956",
                              DateLastUpdated = DateTime.Now
                     }
                },
                UserInterests = new List<UserInterestViewModel>()
                 {
                     new UserInterestViewModel()
                     {
                          Id = 1,
                           Interest = "Golf",
                            InterestLevel = 70.0
                     }
                 },
                UserLanguages = new List<UserLanguageViewModel>(){
                     new UserLanguageViewModel()
                     {
                          Id = 1,
                           CanSpeakAndWrite = true,
                            IsPrimaryLanguage = true,
                             Language = "English"
                     },
                     new UserLanguageViewModel()
                     {
                          Id = 2,
                           CanSpeakAndWrite = true,
                            IsPrimaryLanguage = false,
                             Language = "Afrikaans"
                     }
                },
                UserJobSummary = new List<UserJobSummaryViewModel>() {
                      new UserJobSummaryViewModel()
                      {
                           Id = 1,
                            IsPrimaryJobFunction = true,
                             JobTitle = "Senior Lecturer",
                              JobSkillSets = new List<UserSkillViewModel>()
                              {
                                  new UserSkillViewModel(){
                                       Id = 1,
                                        JobSkill = "Windows Server 2000",
                                         SkillLevel = 70.0
                                  },
                                  new UserSkillViewModel()
                                  {
                                      Id = 2,
                                       JobSkill = "Window Internet Information Server",
                                        SkillLevel = 40.0
                                  }
                              }
                      },
                      new UserJobSummaryViewModel()
                      {
                           Id = 2,
                            IsPrimaryJobFunction = true,
                             JobTitle = "System Administrator",
                              JobSkillSets = new List<UserSkillViewModel>()
                              {
                                  new UserSkillViewModel(){
                                       Id = 1,
                                        JobSkill = "Linux Server",
                                         SkillLevel = 90.0
                                  },
                                  new UserSkillViewModel()
                                  {
                                      Id = 2,
                                       JobSkill = "Window Internet Information Server",
                                        SkillLevel = 86.0
                                  }
                              }
                      }
                 },
                UserQualifications = new List<UserQualificationViewModel>()
                 {
                     new UserQualificationViewModel()
                     {
                          Id= 1,
                           EductaionalInstitution = "North West University",
                            QualificationLevel = "Honours",
                             QualificationTitle = "Bsc Honours Information Technology",
                              YearStartedQualification = "2016",
                               YearCompletedQualification = "2017"
                     },
                     new UserQualificationViewModel()
                     {
                          Id= 2,
                           EductaionalInstitution = "North West University",
                            QualificationLevel = "Degree",
                             QualificationTitle = "Bsc Information Technology",
                              YearStartedQualification = "2003",
                               YearCompletedQualification = "2008"
                     }
                 },
                UserAwards = new List<UserAwardViewModel>()
                 {
                    new UserAwardViewModel()
                    {
                         AwardTitle = "Employee Of The Month",
                          AwardDescription = "Award desc goes here, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo."
                    }
                 },
                UserWorkExperiences = new List<CurriculumViteaWorkExperienceViewModel>()
                 {
                     new CurriculumViteaWorkExperienceViewModel()
                     {
                         Company = "DamelinVaal",
                           JobTitle = "Senior IT Lecturer",
                            YearStarted = "2001",
                            YearEnded = "2003",
                             WorkExperienceDescription = "Role description goes here. Providfe Summary of the Work Description and job functions etc.",
                             Achievements = "{Optional Item}Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.",
                              SkillsEmployed = new List<string>()
                              {
                                  "Windows Server 2000",
                                   "Window Internet Information Server"
                              }
                     }
                 }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CurriculumVitae(string x)
        {
            return View();
        }

        #endregion

        #region Registation
        [HttpGet]
        public IActionResult Register()
        {
            var model = _userViewModelFactory.PrepareRegistrationLoginModel();
            return View(model);
        }
        [HttpGet]
        public IActionResult Register1()
        {
            var model = _userViewModelFactory.PrepareRegistrationLoginModel();
            return View(model);
        }
        #endregion


    }
}