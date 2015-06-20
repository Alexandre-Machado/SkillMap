using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace CWI.SkillMap.Domain.Migrations
{
    public partial class FirstMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateSequence(
                name: "DefaultSequence",
                type: "bigint",
                startWith: 1L,
                incrementBy: 10);
            migration.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Email = table.Column(type: "nvarchar(max)", nullable: true),
                    Login = table.Column(type: "nvarchar(max)", nullable: true),
                    Name = table.Column(type: "nvarchar(max)", nullable: true),
                    ProfileID = table.Column(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.ProfileID);
                });
            migration.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Group = table.Column(type: "nvarchar(max)", nullable: true),
                    Image = table.Column(type: "nvarchar(max)", nullable: true),
                    ParentSkillID = table.Column(type: "uniqueidentifier", nullable: true),
                    ProfileProfileID = table.Column(type: "uniqueidentifier", nullable: true),
                    SkillID = table.Column(type: "uniqueidentifier", nullable: false),
                    SkillName = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillID);
                    table.ForeignKey(
                        name: "FK_Skill_Skill_ParentSkillID",
                        columns: x => x.ParentSkillID,
                        referencedTable: "Skill",
                        referencedColumn: "SkillID");
                    table.ForeignKey(
                        name: "FK_Skill_Profile_ProfileProfileID",
                        columns: x => x.ProfileProfileID,
                        referencedTable: "Profile",
                        referencedColumn: "ProfileID");
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropSequence("DefaultSequence");
            migration.DropTable("Profile");
            migration.DropTable("Skill");
        }
    }
}
