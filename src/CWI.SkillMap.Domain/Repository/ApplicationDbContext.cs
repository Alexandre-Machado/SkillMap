using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using CWI.SkillMap.Domain.Entity;
using CWI.SkillMap.Domain.Migrations;

namespace CWI.SkillMap.Domain.Repository
{
    public class ApplicationDbContext : DbContext
    {
        private static bool _created;

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public ApplicationDbContext()
        {
            // Create the database and schema if it doesn't exist
            if (!_created)
            {
                //Database.AsRelational().ApplyMigrations();
                //_created = true;

                Seed.Run(this);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Profile>().Key(_ => _.ProfileID);
            builder.Entity<Profile>().Property(_ => _.ProfileID);
            builder.Entity<Skill>().Key(_ => _.SkillID);
            builder.Entity<ProfileSkill>().Key(_ => _.ProfileSkillID);
            builder.Entity<Mastery>().Key(_ => _.MasteryID);

        }
        protected override void OnConfiguring(EntityOptionsBuilder options)
        {
            //options.UseInMemoryStore(persist: true);

            //options.UseSqlServer();

            //options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Blogging;integrated security=True;");
        }
    }
}
