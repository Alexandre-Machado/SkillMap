using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWI.SkillMap.Domain.Entity
{
    public class Mastery
    {
        public int MasteryID { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }

        public string Description { get; set; }
    }
}
