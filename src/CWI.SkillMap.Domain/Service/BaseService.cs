using CWI.SkillMap.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWI.SkillMap.Domain.Service
{
    public class BaseService
    {
        public IProfileRepository profileRepository { get; set; }
    }
}
