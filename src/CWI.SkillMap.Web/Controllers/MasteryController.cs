using System.Linq;
using Microsoft.AspNet.Mvc;
using CWI.SkillMap.Models.Skill;
using CWI.SkillMap.Domain.Service;
using CWI.SkillMap.Domain.Model;

namespace CWI.SkillMap.Controllers
{
    [Route("mastery")]
    public class MasteryController : ControllerBase
    {
        public MasteryController(IProfileService profileService, ISkillService skillService)
        {
            ProfileService = profileService;
            SkillService = skillService;
        }

        public IActionResult Index()
        {
            var model = new SkillViewModel
            {
                Skills = SkillService.GetAllSkills().Select(_ => new SkillModel { Name = _.Name }).ToList()
            };

            return View(model);
        }
    }
}
