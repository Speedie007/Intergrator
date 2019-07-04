using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrator.Web.Areas.Company.Component
{
    public class CompanyRelatedIndustryAndJobsViewComponent : ViewComponent
    {
        #region Cstor
        public CompanyRelatedIndustryAndJobsViewComponent()
        {

        }
        #endregion

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
