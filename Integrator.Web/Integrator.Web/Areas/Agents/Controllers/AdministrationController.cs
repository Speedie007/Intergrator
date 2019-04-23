using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integrator.Factories.KnowledgeBase.Core;
using Integrator.Models.ViewModels.KnowledgeBase;
using Microsoft.AspNetCore.Mvc;

namespace Integrator.Web.Areas.Agents.Controllers
{
    [Area("Agents")]
    public class AdministrationController : Controller
    {

        #region Fields

        private readonly ICoreKbSkillViewModelFactory _coreKbSkillViewModelFactory;
        
        #endregion


        #region Cstor
        public AdministrationController(
            ICoreKbSkillViewModelFactory coreKbSkillViewModelFactory)
        {
            this._coreKbSkillViewModelFactory = coreKbSkillViewModelFactory;
           
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
            EditCoreKbIndustryViewModel model = _coreKbSkillViewModelFactory.PrepareCoreKbIndusrtyViewModel();
            return View(model);
        }

    }
}