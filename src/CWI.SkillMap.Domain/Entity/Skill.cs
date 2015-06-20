using System;

namespace CWI.SkillMap.Domain.Entity
{
    public class Skill
    {
        public Guid SkillID { get; set; }

        public string SkillName { get; set; }

        public string Image { get; set; }

        public string Group { get; set; }

        public Skill Parent { get; set; }
    }
}
