using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integrator.Data.Interfaces;
using Integrator.Models.Domain.KnowledgeBase.Core;
using Integrator.Models.ViewModels.KnowledgeBase;
using Integrator.Services.KnowledgeBase.Core;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Integrator.Factories.KnowledgeBase.Core
{
    public partial class CoreKbSkillViewModelFactory : ICoreKbSkillViewModelFactory
    {
        #region Fields
        private readonly ICoreKnowledgeBaseService _coreKnowledgeBaseService;
        #endregion

        #region Cstor
        public CoreKbSkillViewModelFactory(ICoreKnowledgeBaseService coreKnowledgeBaseService)
        {
            this._coreKnowledgeBaseService = coreKnowledgeBaseService;
        }


        #endregion
        public EditCoreKbIndustryViewModel PrepareCoreKbIndusrtyViewModel()
        {
            EditCoreKbIndustryViewModel model = new EditCoreKbIndustryViewModel();

            foreach (var item in _coreKnowledgeBaseService.ListIndustryCategories()){
                model.ListOfIndustryCategories.Add(new SelectListItem()
                {
                    Text = item.CoreKbIndustryCategoryName,
                    Value = item.Id.ToString()
                });
            }

            return model;
        }
        public EditCoreKbSkillViewModel PrepareCoreKbSkillViewModel()
        {
            var model = new EditCoreKbSkillViewModel();



            //model.ListOfSkillTypes.Insert(0, new SelectListItem()
            //{
            //    Text = "Select Skill Type",
            //    Value = "0"
            //});
            foreach (var item in _coreKnowledgeBaseService.ListSkillTypes())
            {
                model.ListOfSkillTypes.Add(new SelectListItem()
                {
                    Text = item.CoreKbSkillTypeName,
                    Value = item.Id.ToString()
                });


            }
            //model.ListOfSkillCategories.Insert(0, new SelectListItem()
            //{
            //    Text = "Select Category",
            //    Value = "0"
            //});


            return model;
        }
    }
}
