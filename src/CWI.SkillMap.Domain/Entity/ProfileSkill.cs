using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWI.SkillMap.Domain.Entity
{
    public class ProfileSkill
    {
        public Guid ProfileSkillID { get; set; }

        public Profile Profile { get; set; }

        public Skill Skill { get; set; }

        public Mastery Mastery { get; set; }
    }
}
