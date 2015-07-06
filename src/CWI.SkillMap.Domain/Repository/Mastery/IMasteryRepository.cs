namespace CWI.SkillMap.Domain.Repository
{
    using Entity;
    using System;

    public interface IMasteryRepository : IDisposable, IRepository<Mastery>
    {
        Mastery GetMasteryByID(int masteryID);
    }
}
