namespace CWI.SkillMap.Models.Skill
{
    using Mastery;
    using System.Collections.Generic;

    public class SkillViewModel
    {
        public List<SkillModel> Skills { get; set; }

        public List<MasteryModel> Masteries { get; set; }
    }
}
