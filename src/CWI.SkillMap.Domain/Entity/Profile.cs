using System;
using System.Collections.Generic;

namespace CWI.SkillMap.Domain.Entity
{
    public class Profile
    {
        public Guid ProfileID { get; set; }

        public string Login { get; set; }

        public string Name { get; set; }

        public IEnumerable<Skill> Skills { get; set; }
    }
}
