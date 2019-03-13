using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Integrator.Web.Controllers.Administration
{
    public class AdministrationController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}