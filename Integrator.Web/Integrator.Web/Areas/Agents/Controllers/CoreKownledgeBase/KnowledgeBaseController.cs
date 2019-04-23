using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Common;
using Integrator.Factories.KnowledgeBase.Core;
using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.ViewModels.Common.DropDownList;
using Integrator.Models.ViewModels.KnowledgeBase;
using Integrator.Services.KnowledgeBase.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Integrator.Web.Areas.Agents.Controllers.CoreKownledgeBase
{
    [Area("Agents")]
    public class KnowledgeBaseController : Controller
    {
        #region Fields

        private readonly ICoreKbSkillViewModelFactory _coreKbSkillViewModelFactory;
        private readonly ICoreKnowledgeBaseService _coreKnowledgeBaseService;
        #endregion

        #region Cstor
        public KnowledgeBaseController(
            ICoreKbSkillViewModelFactory coreKbSkillViewModelFactory,
            ICoreKnowledgeBaseService coreKnowledgeBaseService)
        {
            this._coreKbSkillViewModelFactory = coreKbSkillViewModelFactory;
            this._coreKnowledgeBaseService = coreKnowledgeBaseService;
        }
        #endregion

        [HttpGet]
        public IActionResult Skills()
        {
            EditCoreKbSkillViewModel model = _coreKbSkillViewModelFactory.PrepareCoreKbSkillViewModel();


            return View(model);
        }


        [HttpGet]
        public IActionResult Industry()
        {
            var model = _coreKbSkillViewModelFactory.PrepareCoreKbIndusrtyViewModel();
            return View(model);
        }


        #region Ajax Method Calls
        #region Skills
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetSkillCategoryiesBySkillType([FromBody] DropDownRequest model)
        {
            var cboOptions = (from a in _coreKnowledgeBaseService.ListSkillCategoriesBySkillType(model.ID)
                              select new SelectListItem
                              {
                                  Value = a.Id.ToString(),
                                  Text = a.CoreSkillCategoryName
                              }).ToList();

            // return Json(new SelectList(cboOptions, "CoreSkillCategoryID", "CoreSkillCategoryName"));
            return Json(cboOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetSkillsByCategory([FromBody] DropDownRequest model)
        {
            var cboOptions = (from a in _coreKnowledgeBaseService.ListSkillsByCategory(model.ID)
                              select new
                              {
                                  ID = a.Id,
                                  Options = "<div></div>",
                                  Skill = a.CoreSkill
                              }).ToList();

            // return Json(new SelectList(cboOptions, "CoreSkillCategoryID", "CoreSkillCategoryName"));
            return Json(cboOptions);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSkillCategory([FromBody] DropDownRequest model)
        {
            var _Entity = new CoreSkillCategory()
            {
                CoreKbSkillTypeID = model.ID,
                CoreSkillCategoryName = model.TEXT
            };
            _coreKnowledgeBaseService.AddSkillCategory(_Entity);

            // return Json(new SelectList(cboOptions, "CoreSkillCategoryID", "CoreSkillCategoryName"));
            return Json(_Entity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSkill([FromBody] DropDownRequest model)
        {
            var _Entity = new CoreKbSkill()
            {
                CoreSkillCategoryID = model.ID,
                CoreSkill = model.TEXT
            };
            _coreKnowledgeBaseService.AddSkill(_Entity);

            // return Json(new SelectList(cboOptions, "CoreSkillCategoryID", "CoreSkillCategoryName"));
            return Json(_Entity);
        }
        #endregion

        #region Industry
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddIndusrty([FromBody] DropDownRequest model)
        {
            var entity = new CoreKbIndustry()
            {
                CoreKbIndustryName = model.TEXT,
                 CoreKbIndustryCategoryID = model.ID
            };
            try
            {
                _coreKnowledgeBaseService.AddIndustry(entity);
            }
            catch (IntegratorException e)
            {
                throw e.InnerException;
            }


            return Json(entity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddIndusrtyCategroy([FromBody] DropDownRequest model)
        {
            var entity = new CoreKbIndustryCategory()
            {
                CoreKbIndustryCategoryName = model.TEXT
            };
            try
            {
                _coreKnowledgeBaseService.AddIndusrtyCategory(entity);
            }
            catch (IntegratorException e)
            {
                throw e.InnerException;
            }


            return Json(entity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetIndustryByCategroy([FromBody] DropDownRequest model)
        {
            IEnumerable<object> cboOptions;
            try
            {
                 cboOptions = (from a in _coreKnowledgeBaseService.ListIndustriesByCategory(model.ID)
                                  select new
                                  {
                                      ID = a.Id,
                                      Options = "<div></div>",
                                      Skill = a.CoreKbIndustryName
                                  }).ToList();

            }
            catch (IntegratorException e)
            {
                throw e.InnerException;
            }


            return Json(cboOptions);
        }
        #endregion

        #endregion


    }

}