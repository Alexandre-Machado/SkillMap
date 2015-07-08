using CWI.SkillMap.Domain.Service;
using CWI.SkillMap.Web.ViewModels.Mastery;
using Microsoft.AspNet.Mvc;

namespace CWI.SkillMap.Controllers
{
    [Route("levels")]
    public class MasteryController : ControllerBase
    {
        public MasteryController(IMasteryService masteryService)
        {
            MasteryService = masteryService;
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                Masteries = MasteryService.GetAllMasteries()
            };

            return View(model);
        }
    }
}
