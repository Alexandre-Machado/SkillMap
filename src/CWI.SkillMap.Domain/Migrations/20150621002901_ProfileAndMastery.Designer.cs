using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using CWI.SkillMap.Domain.Repository;

namespace CWI.SkillMap.Domain.Migrations
{
    [ContextType(typeof(ApplicationDbContext))]
    partial class ProfileAndMastery
    {
        public override string Id
        {
            get { return "20150621002901_ProfileAndMastery"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta4-12943"; }
        }
        
        public override IModel Target
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("CWI.SkillMap.Domain.Entity.Mastery", b =>
                    {
                        b.Property<int>("MasteryID")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("Name")
                            .Annotation("OriginalValueIndex", 1);
                        b.Key("MasteryID");
                    });
                
                builder.Entity("CWI.SkillMap.Domain.Entity.Profile", b =>
                    {
                        b.Property<string>("Email")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("Login")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("Name")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<Guid>("ProfileID")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 3);
                        b.Key("ProfileID");
                    });
                
                builder.Entity("CWI.SkillMap.Domain.Entity.ProfileSkill", b =>
                    {
                        b.Property<int?>("MasteryMasteryID")
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("ShadowIndex", 0);
                        b.Property<Guid?>("ProfileProfileID")
                            .Annotation("OriginalValueIndex", 1)
                            .Annotation("ShadowIndex", 1);
                        b.Property<Guid>("ProfileSkillID")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<Guid?>("SkillSkillID")
                            .Annotation("OriginalValueIndex", 3)
                            .Annotation("ShadowIndex", 2);
                        b.Key("ProfileSkillID");
                    });
                
                builder.Entity("CWI.SkillMap.Domain.Entity.Skill", b =>
                    {
                        b.Property<string>("Group")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("Image")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<Guid?>("ParentSkillID")
                            .Annotation("OriginalValueIndex", 2)
                            .Annotation("ShadowIndex", 0);
                        b.Property<Guid>("SkillID")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<string>("SkillName")
                            .Annotation("OriginalValueIndex", 4);
                        b.Key("SkillID");
                    });
                
                builder.Entity("CWI.SkillMap.Domain.Entity.ProfileSkill", b =>
                    {
                        b.ForeignKey("CWI.SkillMap.Domain.Entity.Mastery", "MasteryMasteryID");
                        b.ForeignKey("CWI.SkillMap.Domain.Entity.Profile", "ProfileProfileID");
                        b.ForeignKey("CWI.SkillMap.Domain.Entity.Skill", "SkillSkillID");
                    });
                
                builder.Entity("CWI.SkillMap.Domain.Entity.Skill", b =>
                    {
                        b.ForeignKey("CWI.SkillMap.Domain.Entity.Skill", "ParentSkillID");
                    });
                
                return builder.Model;
            }
        }
    }
}
