using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWI.SkillMap.Domain.Entity;

namespace CWI.SkillMap.Domain.Repository
{
    public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public Profile GetProfileByLogin(string login)
        {
            var query = context.Profiles.FirstOrDefault(_ => _.Login == login);
            return query;
        }
    }
}
