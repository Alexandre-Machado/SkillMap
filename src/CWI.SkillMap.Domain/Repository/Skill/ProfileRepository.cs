using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWI.SkillMap.Domain.Entity;

namespace CWI.SkillMap.Domain.Repository
{
    public class SkillRepository : BaseRepository<Skill>, ISkillRepository
    {
        public SkillRepository(ApplicationDbContext _context)
        {
            context = _context;
        }
        
        public Skill GetSkillByID(Guid skillID)
        {
            var query = context.Skills.FirstOrDefault(_ => _.SkillID == skillID);
            return query;
        }
    }
}
