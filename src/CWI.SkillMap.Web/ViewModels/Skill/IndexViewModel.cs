namespace CWI.SkillMap.Web.ViewModels.Skill
{
    using CWI.SkillMap.Domain.Model;
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public List<SkillModel> Skills { get; set; }

        public List<MasteryModel> Masteries { get; set; }
    }
}
