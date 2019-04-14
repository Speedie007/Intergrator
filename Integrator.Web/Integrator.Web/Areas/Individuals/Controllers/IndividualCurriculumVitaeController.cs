using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Factories.CurriculumVitae;
using Integrator.Models.Domain.Common;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.ViewModels.Common;
using Integrator.Models.ViewModels.CurriculumVitaes;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.Common;
using Integrator.Services.CurriculumVitae;
using Integrator.Services.Users;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Integrator.Web.Areas.Individuals.Controllers
{
    [Area("Individuals")]
    public class IndividualCurriculumVitaeController : Controller
    {
        #region Fields
        private readonly ICurriculumVitaeViewModelFactory _curriculumVitaeViewModelFactory;
        private readonly ICurriculumVitaeService _CurriculumVitaeService;
        private readonly IUserService _userService;
        private readonly IEducationInstitutionService _educationInstitutionService;
        private IEntityCRUDResponse _entityCRUDResponse;
        private readonly IInterestService _interestService;

        #endregion

        #region Cstor
        public IndividualCurriculumVitaeController(
                ICurriculumVitaeViewModelFactory curriculumVitaeViewModelFactory,
                ICurriculumVitaeService curriculumVitaeService,
                IUserService userService,
                IEducationInstitutionService educationInstitutionService,
                IEntityCRUDResponse entityCRUDResponse,
                IInterestService interestService
            )
        {
            this._curriculumVitaeViewModelFactory = curriculumVitaeViewModelFactory;
            this._CurriculumVitaeService = curriculumVitaeService;
            this._userService = userService;
            this._educationInstitutionService = educationInstitutionService;
            this._entityCRUDResponse = entityCRUDResponse;
            this._interestService = interestService;
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
            CurriculumVitaeViewModel model1 = new CurriculumVitaeViewModel();
            _curriculumVitaeViewModelFactory.PerpareCurriculumVitaeViewModel(model1, true);
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
                              YearStartedQualification = DateTime.Now.Year.ToString(),
                               YearCompletedQualification = DateTime.Now.Year.ToString()
                     },
                     new UserQualificationViewModel()
                     {
                          Id= 2,
                           EductaionalInstitution = "North West University",
                            QualificationLevel = "Degree",
                             QualificationTitle = "Bsc Information Technology",
                              YearStartedQualification = DateTime.Now.Year.ToString(),
                               YearCompletedQualification = DateTime.Now.Year.ToString()
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
                              SkillsEmployed = new List<UserSkillViewModel>()
                              {
                                   new UserSkillViewModel()
                                   {
                                        Id = 1,
                                         JobSkill = "Windows Server 2000",
                                          SkillLevel = 75.5
                                   },
                                   new UserSkillViewModel()
                                   {
                                        Id = 2,
                                         JobSkill = "Window Internet Information Server",
                                          SkillLevel = 25.0
                                   }

                              }
                     }
                 }
            };
            return View(model1);
        }

        [HttpPost]
        public IActionResult CurriculumVitae(string x)
        {
            return View();
        }

        #endregion

        #region Edit Curriculum Vitae Components

        #region Edit CV Picture
        [HttpGet]
        public IActionResult CurriculumVitaePicture()
        {

            return View();
        }
        #endregion


        #region Edit CV Work Experience  
        [HttpGet]
        public IActionResult CurriculumVitaeWorkExperiences()
        {

            return View();
        }
        #endregion


        #region Edit CV Career Summary
        [HttpGet]
        public IActionResult CurriculumVitaeCareerSummary()
        {
            CurriculumVitaeViewModel model = new CurriculumVitaeViewModel();
            _curriculumVitaeViewModelFactory.PerpareCurriculumVitaeViewModel(model, false);
            return View(model);
        }
        /// <summary>
        /// Ajax Call whch send the Career Summary and updates the database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UpdateCurriculumVitaeCareerSummary([FromBody] CurriculumVitaeViewModel request)
        {

            var bSuccessfull = _CurriculumVitaeService.UpdateUserCurriculumVitea(new CurriculumVitea()
            {
                Id = request.Id,
                DateLastUpdated = DateTime.Now,
                CareerSummary = request.UserCareerSummary,
                IntegratorUserID = _userService.GetUserID()
            });

            return new JsonResult($"{{Success:{bSuccessfull}}}");

        }
        #endregion
        #region Edit CV Education

        /// <summary>
        /// Displays the Form to Edit and update the Current User Qualifications.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CurriculumVitaeEducation()
        {
            var model = _curriculumVitaeViewModelFactory.prepareEditCurriuclumVitaeQualifications();
            return View(model);
        }

        /// <summary>
        /// Updates the User Qualification by adding the new Qualification Details added by the user.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CurriculumVitaeEducation(EditUserQualificationViewModel model)
        {
            if (ModelState.IsValid)
            {
                _entityCRUDResponse = _userService.AddUserQualification(new UserQualifications()
                {
                    QualificationTitle = model.QualificationTitle,
                    IntegratorUserID = _userService.GetUserID(),
                    QualificationLevelID = model.QualificationLevelID,
                    YearStartedQualification = new DateTime(Convert.ToInt32(model.YearStartedQualification), 1, 1),
                    YearCompletedQualification = new DateTime(Convert.ToInt32(model.YearCompletedQualification), 1, 1),
                    EductaionalInstitutionID = model.EductaionalInstitutionID,
                    QualificationAverage = model.QualificationAverage

                });

            }

            if (_entityCRUDResponse.Success)
            {
                return RedirectToAction("CurriculumVitaeEducation");
            }
            else
            {
                //Todo: Redirect To Error Page and Log Errors
                return RedirectToAction("CurriculumVitaeEducation");
            }
        }

        [HttpPost]
        public IActionResult RemoveUserQualification([FromBody] UserQualificationViewModel request)
        {
            _entityCRUDResponse = _userService.DeleteUserQualification(new UserQualifications()
            {
                Id = request.Id
            });

            return new JsonResult(_entityCRUDResponse);
        }

        /// <summary>
        /// Handels Ajax Call which adds new Education institution
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EdutcationalInstitution([FromBody] EductionalInstitutionViewModel request)
        {
            _entityCRUDResponse = _educationInstitutionService.AddEducationInstitution(new EductaionalInstitutions()
            {
                Id = request.Id,
                EductaionalInstitution = request.EductaionalInstitution
            });

            return new JsonResult(_entityCRUDResponse);
        }
        #endregion
        #region Edit CV Awards
        [HttpGet]
        public IActionResult CurriculumVitaeAwards()
        {

            return View();
        }
        #endregion
        #region Edit CV Languages  
        [HttpGet]
        public IActionResult CurriculumVitaLanguages()
        {
            var model = _curriculumVitaeViewModelFactory.PrepareEditCurriculumVitaeLanguages();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddUserCurriculumVitaeLanguage([FromBody] EditUserLanguageViewModel request)
        {

            _entityCRUDResponse = _userService.AddUserLanguage(new IntegratorUserLanguages()
            {
                
                LanguageID = request.LanguageID,
                IntegratorUserID = _userService.GetUserID(),
                IsPrimaryLanguage = request.IsPrimaryLanguage,
                LanguageProficiencyLevel = request.LanguageProficiencyLevel,
                CanSpeakAndWrite = request.CanSpeakAndWrite
            });

            return new JsonResult(_entityCRUDResponse);
        }
        [HttpPost]
        public IActionResult RemoveUserCurriculumVitaeLanguage([FromBody] UserInterestViewModel request)
        {

            _entityCRUDResponse = _userService.DeleteUserLanguage(new IntegratorUserLanguages()
            {
                Id = request.Id
            });

            return new JsonResult(_entityCRUDResponse);
        }
        
        #endregion
        #region Edit CV Interests
        [HttpGet]
        public IActionResult CurriculumVitaeInterests()
        {
            var model = _curriculumVitaeViewModelFactory.prepareEditCurriculumVitaeInterests();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddNewCurriculumVitaeInterests([FromBody] UserInterestViewModel request)
        {

            _entityCRUDResponse = _interestService.AddInterest(new Interest()
            {
                Id = request.Id,
                AnInterest = request.Interest
            });

            return new JsonResult(_entityCRUDResponse);
        }
        [HttpPost]
        public IActionResult AddUserCurriculumVitaeInterests([FromBody] EditUserInterestViewModel request)
        {

            _entityCRUDResponse = _userService.AddUserInterest(new IntegratorUserInterest()
            {
                Id = request.Id,
                InterestLevel = request.InterestLevel,
                IntegratorUserID = _userService.GetUserID(),
                InterestID = request.InterestID
            });

            return new JsonResult(_entityCRUDResponse);
        }
        [HttpPost]
        public IActionResult RemoveUserCurriculumVitaeInterests([FromBody] UserInterestViewModel request)
        {

            _entityCRUDResponse = _userService.DeleteUserInterest(new IntegratorUserInterest()
            {
                Id = request.Id
            });

            return new JsonResult(_entityCRUDResponse);
        }

        #endregion

        #endregion
    }
}