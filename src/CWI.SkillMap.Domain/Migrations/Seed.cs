namespace CWI.SkillMap.Domain.Migrations
{
    using Entity;
    using Microsoft.Data.Entity;
    using System.Linq;

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
            if (!db.Set<Skill>().Any())
                db.AddRange(
                    new Skill { SkillName = "ASP.NET" },
                    new Skill { SkillName = "Ruby" },
                    new Skill { SkillName = "JavaScript" }
                    );

            db.SaveChanges();
        }
    }
}
