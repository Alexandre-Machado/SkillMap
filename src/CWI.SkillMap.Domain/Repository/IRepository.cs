namespace CWI.SkillMap.Domain.Repository
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
