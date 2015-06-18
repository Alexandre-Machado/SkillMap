using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using CWI.SkillMap.Domain.Service;

namespace CWI.SkillMap.Controllers
{
    public class HomeController : ControllerBase
    {
        public HomeController(IProfileService profileService)
        {
            ProfileService = profileService;
        }

        public IActionResult Index()
        {
            var prof = ProfileService.CurrentProfile();
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
