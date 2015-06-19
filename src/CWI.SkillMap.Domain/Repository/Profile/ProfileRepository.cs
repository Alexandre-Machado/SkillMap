using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWI.SkillMap.Domain.Entity;

namespace CWI.SkillMap.Domain.Repository
{
    public class ProfileRepository : BaseRepository, IProfileRepository
    {
        public ProfileRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public Task<Profile> GetProfileByLogin(string login)
        {
            throw new NotImplementedException();
        }
    }
}
