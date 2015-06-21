using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace CWI.SkillMap.Domain.Migrations
{
    public partial class ProfileAndMastery : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.DropForeignKey(name: "FK_Skill_Profile_ProfileProfileID", table: "Skill");
            migration.DropColumn(name: "ProfileProfileID", table: "Skill");
            migration.CreateTable(
                name: "Mastery",
                columns: table => new
                {
                    MasteryID = table.Column(type: "int", nullable: false),
                    Name = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mastery", x => x.MasteryID);
                });
            migration.CreateTable(
                name: "ProfileSkill",
                columns: table => new
                {
                    MasteryMasteryID = table.Column(type: "int", nullable: true),
                    ProfileProfileID = table.Column(type: "uniqueidentifier", nullable: true),
                    ProfileSkillID = table.Column(type: "uniqueidentifier", nullable: false),
                    SkillSkillID = table.Column(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSkill", x => x.ProfileSkillID);
                    table.ForeignKey(
                        name: "FK_ProfileSkill_Mastery_MasteryMasteryID",
                        columns: x => x.MasteryMasteryID,
                        referencedTable: "Mastery",
                        referencedColumn: "MasteryID");
                    table.ForeignKey(
                        name: "FK_ProfileSkill_Profile_ProfileProfileID",
                        columns: x => x.ProfileProfileID,
                        referencedTable: "Profile",
                        referencedColumn: "ProfileID");
                    table.ForeignKey(
                        name: "FK_ProfileSkill_Skill_SkillSkillID",
                        columns: x => x.SkillSkillID,
                        referencedTable: "Skill",
                        referencedColumn: "SkillID");
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Mastery");
            migration.DropTable("ProfileSkill");
            migration.AddColumn(
                name: "ProfileProfileID",
                table: "Skill",
                type: "uniqueidentifier",
                nullable: true);
            migration.AddForeignKey(
                name: "FK_Skill_Profile_ProfileProfileID",
                table: "Skill",
                column: "ProfileProfileID",
                referencedTable: "Profile",
                referencedColumn: "ProfileID");
        }
    }
}
