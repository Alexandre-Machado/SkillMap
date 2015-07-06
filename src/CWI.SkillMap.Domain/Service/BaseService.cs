namespace CWI.SkillMap.Domain.Service
{
    using Repository;

    public class BaseService
    {
        public IProfileRepository profileRepository { get; set; }

        public ISkillRepository skillRepository { get; set; }

        public IMasteryRepository masteryRepository { get; set; }
    }
}
