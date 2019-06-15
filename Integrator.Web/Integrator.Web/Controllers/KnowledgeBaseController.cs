using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Common;
using Integrator.Factories.KnowledgeBase.Core;
using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.ViewModels.Common.DropDownList;
using Integrator.Services.KnowledgeBase.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Integrator.Web.Controllers
{
    public class KnowledgeBaseController : Controller
    {

        #region Fields


        private readonly ICoreKnowledgeBaseService _coreKnowledgeBaseService;
        #endregion


        #region Cstor
        public KnowledgeBaseController(
            ICoreKnowledgeBaseService coreKnowledgeBaseService)
        {

            this._coreKnowledgeBaseService = coreKnowledgeBaseService;
        }
        #endregion

        #region Ajax Method Calls
        #region Skills
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetSkillCategoryiesBySkillType([FromBody] DropDownRequest model)
        {
            var cboOptions = (from a in _coreKnowledgeBaseService.ListSkillCategoriesBySkillType(model.ID)
                              orderby a.CoreSkillCategoryName
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
                              orderby a.CoreSkill
                              select new
                              {
                                  ID = a.Id,
                                  // Options = "<div></div>",

                                  Skill = CommonHelper.CapitaliseAllWords(a.CoreSkill),
                                  SkillCategoryID = a.CoreSkillCategoryID
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
                CoreSkillCategoryName = CommonHelper.CapitaliseAllWords(model.TEXT)
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
                CoreSkill = CommonHelper.CapitaliseAllWords(model.TEXT)
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
                CoreKbIndustryName = CommonHelper.CapitaliseAllWords(model.TEXT),
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
                CoreKbIndustryCategoryName = CommonHelper.CapitaliseAllWords(model.TEXT)
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
                              orderby a.CoreKbIndustryName
                              select new
                              {
                                  ID = a.Id,
                                  //Options = "<div></div>",
                                  Industry = CommonHelper.CapitaliseAllWords(a.CoreKbIndustryName),
                                  IndustryCategoryID = a.CoreKbIndustryCategoryID
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