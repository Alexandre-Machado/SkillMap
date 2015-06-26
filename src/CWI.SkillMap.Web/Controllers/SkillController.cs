using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using CWI.SkillMap.Models.Skill;
using CWI.SkillMap.Domain.Service;

namespace CWI.SkillMap.Controllers
{
    [Route("skills")]
    public class SkillController : ControllerBase
    {
        public SkillController(IProfileService profileService)
        {
            ProfileService = profileService;
        }

        public IActionResult Index()
        {
            var model = new SkillViewModel { Skills = new List<SkillModel>() };

            return View(model);
        }
    }
}
