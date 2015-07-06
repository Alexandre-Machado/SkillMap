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
            if (!db.Set<Mastery>().Any())
                db.AddRange(
                    new Mastery { Code = 10, Name = "Iniciante" },
                    new Mastery { Code = 20, Name = "Competente" },
                    new Mastery { Code = 30, Name = "Proeficiente" },
                    new Mastery { Code = 40, Name = "Experiente" },
                    new Mastery { Code = 50, Name = "Mestre" });

            db.SaveChanges();
        }
    }
}
