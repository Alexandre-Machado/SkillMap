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
            ViewBag.Count = ProfileService.GetAllProfiles().Count();
            ViewBag.Name = User.Identity.Name;
            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
