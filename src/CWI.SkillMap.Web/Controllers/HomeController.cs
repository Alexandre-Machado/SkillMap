using CWI.SkillMap.Domain.Model;
using CWI.SkillMap.Domain.Service;
using CWI.SkillMap.Web.ViewModels.Home;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.OptionsModel;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CWI.SkillMap.Controllers
{
    public class HomeController : ControllerBase
    {
        private IOptions<AppSettings> _appSettings;

        public HomeController(IProfileService profileService, IOptions<AppSettings> appSettings)
        {
            ProfileService = profileService;
            _appSettings = appSettings;
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel { Skills = new List<SkillModel>() };
            ViewBag.Count = ProfileService.GetAllProfiles().Count();
            ViewBag.Name = User.Identity.Name;
            return View(model);
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        [Route("profile-image/{domain}/{login}")]
        [ResponseCache(Duration = 3600)]
        public async Task<IActionResult> ProfileImage(string domain, string login)
        {
            using (var client = new WebClient())
            {
                var uri = string.Format(_appSettings.Options.SharePointImageUrl, domain, login);
                var data = await client.DownloadDataTaskAsync(uri);
                return File(data, "image/jpeg");
            }
        }
    }
}
