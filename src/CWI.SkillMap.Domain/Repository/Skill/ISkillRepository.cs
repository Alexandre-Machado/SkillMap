namespace CWI.SkillMap.Domain.Repository
{
    using Entity;
    using System;

    public interface ISkillRepository : IDisposable, IRepository<Skill>
    {
        Skill GetSkillByID(Guid skillID);
    }
}
