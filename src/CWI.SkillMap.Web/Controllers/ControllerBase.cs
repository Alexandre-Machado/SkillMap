using Microsoft.AspNet.Mvc;
using CWI.SkillMap.Domain.Service;

namespace CWI.SkillMap.Controllers
{
    public class ControllerBase : Controller
    {
        public IProfileService ProfileService { get; set; }

        public ISkillService SkillService { get; set; }

        public IMasteryService MasteryService { get; set; }
    }
}
