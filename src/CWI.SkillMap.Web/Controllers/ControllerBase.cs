using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using CWI.SkillMap.Domain.Service;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CWI.SkillMap.Controllers
{
    public class ControllerBase : Controller
    {
        public IProfileService ProfileService { get; set; }
    }
}
