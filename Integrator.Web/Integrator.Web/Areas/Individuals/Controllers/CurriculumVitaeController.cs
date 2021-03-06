﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Common;
using Integrator.Factories.CurriculumVitae;
using Integrator.Models.Domain.Common;
using Integrator.Models.Domain.Companies;
using Integrator.Models.Domain.CurriculumVitaes;
using Integrator.Models.Domain.Files;
using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Integrator.Models.ViewModels.Common;
using Integrator.Models.ViewModels.Common.DropDownList;
using Integrator.Models.ViewModels.Common.Files;
using Integrator.Models.ViewModels.CurriculumVitaes;
using Integrator.Models.ViewModels.Users;
using Integrator.Services.Common;
using Integrator.Services.Companies;
using Integrator.Services.CurriculumVitae;
using Integrator.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Integrator.Services.KnowledgeBase.Users;
namespace Integrator.Web.Areas.Individuals.Controllers
{
    [Area("Individuals")]
    [Authorize]
    public class CurriculumVitaeController : Controller
    {

        #region Fields
        private readonly ICurriculumVitaeViewModelFactory _curriculumVitaeViewModelFactory;
        private readonly ICurriculumVitaeService _curriculumVitaeService;
        private readonly IUserService _userService;
        private readonly IEducationInstitutionService _educationInstitutionService;
        private IEntityCRUDResponse _entityCRUDResponse;
        private readonly IInterestService _interestService;
        private readonly ICompanyService _companyService;
        private readonly IUserKnowledgeBaseService _userKnowledgeBaseService;

        #endregion

        #region Cstor
        public CurriculumVitaeController(
                ICurriculumVitaeViewModelFactory curriculumVitaeViewModelFactory,
                ICurriculumVitaeService curriculumVitaeService,
                IUserService userService,
                IEducationInstitutionService educationInstitutionService,
                IEntityCRUDResponse entityCRUDResponse,
                IInterestService interestService,
                ICompanyService companyService,
                IUserKnowledgeBaseService userKnowledgeBaseService
            )
        {
            this._curriculumVitaeViewModelFactory = curriculumVitaeViewModelFactory;
            this._curriculumVitaeService = curriculumVitaeService;
            this._userService = userService;
            this._educationInstitutionService = educationInstitutionService;
            this._entityCRUDResponse = entityCRUDResponse;
            this._interestService = interestService;
            this._companyService = companyService;
            this._userKnowledgeBaseService = userKnowledgeBaseService;
        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {

            //From demo and development purposes
            /*
             * Todo must implement CV factory to populate the model
             * */
            CurriculumVitaeViewModel model = new CurriculumVitaeViewModel();
            _curriculumVitaeViewModelFactory.PerpareCurriculumVitaeViewModel(model, true);
            return View(model);
        }

        #region Edit Curriculum Vitae Components

        #region Edit CV Picture

        public IActionResult NewPicture()
        {
            EditUserPictureViewModel model = _curriculumVitaeViewModelFactory.PrepareEditCurriculumViteaPictures();
            return View(model);
        }
        public IActionResult SetUserDefaultProfilePicture([FromBody] UserProifileImageUploadRequest request)
        {
            _userService.SetUserProfilePictureAsDefault(request.Id);
            return new JsonResult("");
        }
        [HttpGet]
        public IActionResult Picture()
        {
            var model = _curriculumVitaeViewModelFactory.PrepareEditCurriculumViteaPictures();
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Picture([FromForm] EditUserPictureViewModel model)
        {
            IntegratorFile NewProfilePicture = new IntegratorFile();

            NewProfilePicture.FileName = Path.GetFileNameWithoutExtension(model.UserProfileImage.FileName);
            NewProfilePicture.FileExtension = Path.GetExtension(model.UserProfileImage.FileName);
            NewProfilePicture.FileSize = model.UserProfileImage.Length;
            NewProfilePicture.ContentType = model.UserProfileImage.ContentType;
            NewProfilePicture.DateCreated = DateTime.Now;
            NewProfilePicture.UserPicture = new UserPicture()
            {
                IntegratorUserID = _userService.GetUserID(),
                IsCurrentProfilePicture = true
            };

            Image OriginalImage = null;

            using (var memoryStream = new MemoryStream())
            {



                await model.UserProfileImage.CopyToAsync(memoryStream);

                OriginalImage = new Bitmap(memoryStream);


                Image destinationImage = new Bitmap(480, 480);

                using (Graphics g = Graphics.FromImage(destinationImage))
                {
                    g.DrawImage(
                                OriginalImage,
                                new Rectangle(0, 0, 480, 480),
                                new Rectangle(model.sourceX, model.sourceY, model.sourceWidth, model.sourceHeight),
                                GraphicsUnit.Pixel
                            );
                }

                byte[] CroppedImage;
                using (var ms = new MemoryStream())
                {
                    destinationImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    CroppedImage = ms.ToArray();
                }

                NewProfilePicture.FileSize = CroppedImage.Length;



                NewProfilePicture.InegratorFileBlob = new InegratorFileBlob()
                {
                    FileBlob = CroppedImage
                };
            }
            _userService.AddUserProfilePicture(NewProfilePicture);
            return RedirectToAction("Picture");
        }




        #endregion


        #region Edit CV Work Experience  
        [HttpGet]
        public IActionResult WorkExperiences()
        {
            var model = _curriculumVitaeViewModelFactory.prepareEditCurriuclumVitaeWorkExperiences();
            return View(model);
        }
        #endregion


        #region Edit CV Career Summary
        [HttpGet]
        public IActionResult CareerSummary()
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
        public IActionResult UpdateCareerSummary([FromBody] CurriculumVitaeViewModel request)
        {

            var bSuccessfull = _curriculumVitaeService.UpdateUserCurriculumVitea(new CurriculumVitea()
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
        public IActionResult Education()
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
        public IActionResult Education(EditUserQualificationViewModel model)
        {
            if (ModelState.IsValid)
            {
                _entityCRUDResponse = _userService.AddUserQualification(new UserQualification()
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
                return RedirectToAction("Education");
            }
            else
            {
                //Todo: Redirect To Error Page and Log Errors
                return RedirectToAction("Education");
            }
        }

        [HttpPost]
        public IActionResult RemoveUserQualification([FromBody] UserQualificationViewModel request)
        {
            _entityCRUDResponse = _userService.DeleteUserQualification(new UserQualification()
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
        public IActionResult Awards()
        {
            EditUserAwardViewModel model = _curriculumVitaeViewModelFactory.PrepareEditCurriculumVitaeAwards();
            return View(model);
        }
        [HttpPost]
        public IActionResult Awards(UserAwardViewModel request)
        {
            _userService.AddUserAward(new IntegratorUserAwards()
            {
                AwardTitle = request.AwardTitle,
                AwardDescription = request.AwardDescription,
                IntegratorUserID = _userService.GetUserID()
            });
            return RedirectToActionPermanent("Awards");
        }

        [HttpPost]
        public IActionResult DeleteAwards([FromForm] int Id)
        {
            _userService.DeleteUserAward(new IntegratorUserAwards()
            {
                Id = Id
            });
            return RedirectToActionPermanent("Awards");
        }
        #endregion
        #region Edit CV Languages  
        [HttpGet]
        public IActionResult Languages()
        {
            var model = _curriculumVitaeViewModelFactory.PrepareEditCurriculumVitaeLanguages();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddUserLanguage([FromBody] EditUserLanguageViewModel request)
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
        public IActionResult RemoveUserLanguage([FromBody] UserInterestViewModel request)
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
        public IActionResult Interests()
        {
            EditUserInterestViewModel model = _curriculumVitaeViewModelFactory.prepareEditCurriculumVitaeInterests();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddNewInterests([FromBody] UserInterestViewModel request)
        {

            _entityCRUDResponse = _interestService.AddInterest(new Interest()
            {
                Id = request.Id,
                AnInterest = request.Interest
            });

            return new JsonResult(_entityCRUDResponse);
        }
        [HttpPost]
        public IActionResult AddUserInterests([FromBody] EditUserInterestViewModel request)
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
        public IActionResult RemoveUserInterests([FromBody] UserInterestViewModel request)
        {

            _entityCRUDResponse = _userService.DeleteUserInterest(new IntegratorUserInterest()
            {
                Id = request.Id
            });

            return new JsonResult(_entityCRUDResponse);
        }

        #endregion

        #endregion

        #region Async Ajax Methods
        #region Work Experince 


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveCurriculumVitaeWorkExperienceEntry([FromBody] DropDownRequest model)
        {
            _userKnowledgeBaseService.RemoveUserJob(model.ID);

            return Json("Success");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetCurriculumVitaeWorkExperienceEntry([FromBody] DropDownRequest model)
        {
            var Rtn = _curriculumVitaeViewModelFactory.prepareEditSingleCurriuclumVitaeWorkExperiences(model.ID);
            return Json(Rtn);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCurriculumVitaeWorkExperienceEntry([FromBody] EditUserCurriculumViteaWorkExperienceViewModel model)
        {
            var UserCurriculumVitae = _curriculumVitaeService.GetCurriculumVitea(_userService.GetUserID());
            UserJob NewUserJob = new UserJob()
            {
                CompanyID = Convert.ToInt32(model.CompanyID),
                CoreKbJobID = Convert.ToInt32(model.CoreKbJobID),
                DateStarted = new DateTime(Convert.ToInt32(model.YearStarted), 1, 1),
                DateEnded = new DateTime(Convert.ToInt32(model.YearEnded), 1, 1),
                IntegratorUserID = _userService.GetUserID(),
                CurriculumViteaID = UserCurriculumVitae.Id,
                Achievments = model.Achievements,
                WorkExperienceDescription = model.WorkExperienceDescription,
                IsCurrentJob = false
            };

            //List<UserJobRelatedIndustry> LinkedUserJobRelatedIndustries = new List<UserJobRelatedIndustry>();
            foreach (InternalReturnItem item in model.ListOfUserRelatedIndustries)
            {

                NewUserJob.UserJobRelatedIndustries.Add(new UserJobRelatedIndustry()
                {
                    CoreKbIndustryID = Convert.ToInt32(item.DataItemID),
                    LevelOfIndustryInvolvement = Convert.ToInt32(item.DataItemLevel)

                });
            }
            // List<UserJobSkill> LinkedUserJobskills = new List<UserJobSkill>();
            foreach (InternalReturnItem item in model.ListOfUserSkills)
            {

                NewUserJob.UserJobSkills.Add(new UserJobSkill()
                {

                    CoreKbSkillID = Convert.ToInt32(item.DataItemID),
                    UserJobSkillLevel = Convert.ToInt32(item.DataItemLevel)
                });
            }
            _userService.AddUserJob(NewUserJob);

            // return Json(new SelectList(cboOptions, "CoreSkillCategoryID", "CoreSkillCategoryName"));
            var AddedUserJob = _userService.GetUserJob(NewUserJob.Id);

            return Json(new
            {
                Id = AddedUserJob.Id,
                CompanyName = AddedUserJob.Company.CompanyName,
                JobTitle = AddedUserJob.CoreKbJob.CoreKbJobTitle,
                YearStarted = AddedUserJob.DateStarted.Year,
                YearEnded = AddedUserJob.DateEnded.Year
            });
        }
        #endregion
        #region Company Methods
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCompanyToDatabase([FromBody] DropDownRequest model)
        {

            var _Entity = new Integrator.Models.Domain.Companies.Company()
            {
                CompanyName = CommonHelper.CapitaliseAllWords(model.TEXT)
            };
            _companyService.AddCompany(_Entity);

            // return Json(new SelectList(cboOptions, "CoreSkillCategoryID", "CoreSkillCategoryName"));
            return Json(_Entity);
        }
        #endregion
        #region Industry Mehtods
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult GetIndustryByCategroy([FromBody] DropDownRequest model)
        //{
        //    IEnumerable<object> cboOptions;
        //    try
        //    {
        //        cboOptions = (from a in _coreKnowledgeBaseService.ListIndustriesByCategory(model.ID)
        //                      select new
        //                      {
        //                          ID = a.Id,
        //                          Options = "<div></div>",
        //                          Skill = a.CoreKbIndustryName
        //                      }).ToList();

        //    }
        //    catch (IntegratorException e)
        //    {
        //        throw e.InnerException;
        //    }


        //    return Json(cboOptions);
        //}
        #endregion
        #endregion
    }
}