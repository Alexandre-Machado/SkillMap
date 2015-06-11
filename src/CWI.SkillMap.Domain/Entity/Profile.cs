using System.Collections.Generic;

namespace CWI.SkillMap.Domain.Entity
{
    public class Profile
    {
        public string Login { get; set; }

        public string Name { get; set; }

        public IEnumerable<Skill> Skills { get; set; }
    }
}
