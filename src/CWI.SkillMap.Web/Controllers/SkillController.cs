using CWI.SkillMap.Domain.Service;
using CWI.SkillMap.Web.ViewModels.Skill;
using Microsoft.AspNet.Mvc;

namespace CWI.SkillMap.Controllers
{
    [Route("skills")]
    public class SkillController : ControllerBase
    {
        public SkillController(IProfileService profileService, ISkillService skillService, IMasteryService masteryService)
        {
            ProfileService = profileService;
            SkillService = skillService;
            MasteryService = masteryService;
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                Skills = SkillService.GetAllSkills(),
                Masteries = MasteryService.GetAllMasteries()
            };

            return View(model);
        }
    }
}
