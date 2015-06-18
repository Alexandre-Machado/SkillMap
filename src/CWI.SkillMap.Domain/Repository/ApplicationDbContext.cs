using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Framework.OptionsModel;
using CWI.SkillMap.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CWI.SkillMap.Domain.Repository
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static bool _created;

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public ApplicationDbContext()
        {
            // Create the database and schema if it doesn't exist
            if (!_created)
            {
                Database.AsRelational().ApplyMigrations();
                _created = true;
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Profile>().Key(_ => _.ProfileID);
            builder.Entity<Skill>().Key(_ => _.SkillID);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // Visual Studio 2015 | Use the LocalDb 12 instance created by Visual Studio
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");

            // Visual Studio 2013 | Use the LocalDb 11 instance created by Visual Studio
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\v11.0;Database=Blogging;Trusted_Connection=True;");

            // Visual Studio 2012 | Use the SQL Express instance created by Visual Studio
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Blogging;Trusted_Connection=True;");
        }
    }
}
