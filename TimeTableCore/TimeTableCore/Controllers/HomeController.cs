using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TimeTableCore.Common;

namespace TimeTableCore.Controllers
{
    public class HomeController : BaseController
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetObjectAsJson("USER_SESSION", null);
            return RedirectToAction("Index");
        }

    }
}
