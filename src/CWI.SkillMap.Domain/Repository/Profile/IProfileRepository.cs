namespace CWI.SkillMap.Domain.Repository
{
    using Entity;
    using System;
    using System.Collections.Generic;

    public interface IProfileRepository : IDisposable, IRepository<Profile>
    {
        Profile GetProfileByLogin(string login);
    }
}
