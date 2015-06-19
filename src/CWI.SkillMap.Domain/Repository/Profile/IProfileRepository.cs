namespace CWI.SkillMap.Domain.Repository
{
    using CWI.SkillMap.Domain.Entity;
    using System;
    using System.Threading.Tasks;

    public interface IProfileRepository : IDisposable
    {
        Task<Profile> GetProfileByLogin(string login);
    }
}
