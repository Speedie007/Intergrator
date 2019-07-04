using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrator.Web.ViewComponents
{
    public class TestView : ViewComponent
    {
        public TestView()
        {

        }

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
