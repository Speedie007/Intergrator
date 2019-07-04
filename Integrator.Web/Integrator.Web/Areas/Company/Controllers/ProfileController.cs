using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Integrator.Web.Areas.Company.Controllers
{
    [Area("Company")]
    [Authorize]
    public class ProfileController : Controller
    {


        #region Cstor
        public ProfileController()
        {

        }
        #endregion
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CompanyBranches()
        {
            return View();
        }

        public IActionResult CompanyProfile()
        {
            return View();
        }
        public IActionResult CompanyJobs()
        {
            return View();
        }

        public IActionResult CompanyRepresentives()
        {
            return View();
        }

    }
}