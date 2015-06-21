using CWI.SkillMap.Domain.Entity;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWI.SkillMap.Domain.Migrations
{
    public static class Seed
    {
        public static void Run(DbContext db)
        {
            if (!db.Set<Profile>().Any())
                db.Add(new Profile
                {
                    Name = "Alexandre Machado",
                    Email = "alexandre@machado.cc",
                    Login = "cwinet\alexandrelima"
                });
        }
    }
}
