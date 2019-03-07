using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Integrator.Web.Controllers.Users
{ 
    public class UserController : Controller
    {

        #region Login / logout
        [HttpGet]
        public virtual IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public virtual IActionResult AuthenticateUser()
        {

            return View();
        }
        #endregion



    }
}