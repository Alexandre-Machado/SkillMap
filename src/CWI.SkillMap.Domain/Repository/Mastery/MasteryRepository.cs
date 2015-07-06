using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWI.SkillMap.Domain.Entity;

namespace CWI.SkillMap.Domain.Repository
{
    public class MasteryRepository : BaseRepository<Mastery>, IMasteryRepository
    {
        public MasteryRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public override IEnumerable<Mastery> GetAll()
        {
            return context.Set<Mastery>().OrderBy(_ => _.Code);
        }

        public Mastery GetMasteryByID(int masteryID)
        {
            return context.Set<Mastery>().SingleOrDefault(_ => _.MasteryID == masteryID);
        }
    }
}
