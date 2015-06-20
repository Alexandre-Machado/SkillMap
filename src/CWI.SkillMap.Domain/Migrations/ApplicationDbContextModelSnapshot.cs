using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using CWI.SkillMap.Domain.Repository;

namespace CWI.SkillMap.Domain.Migrations
{
    [ContextType(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
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
                
                builder.Entity("CWI.SkillMap.Domain.Entity.Skill", b =>
                    {
                        b.Property<string>("Group")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("Image")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<Guid?>("ParentSkillID")
                            .Annotation("OriginalValueIndex", 2)
                            .Annotation("ShadowIndex", 0);
                        b.Property<Guid?>("ProfileProfileID")
                            .Annotation("OriginalValueIndex", 3)
                            .Annotation("ShadowIndex", 1);
                        b.Property<Guid>("SkillID")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<string>("SkillName")
                            .Annotation("OriginalValueIndex", 5);
                        b.Key("SkillID");
                    });
                
                builder.Entity("CWI.SkillMap.Domain.Entity.Skill", b =>
                    {
                        b.ForeignKey("CWI.SkillMap.Domain.Entity.Skill", "ParentSkillID");
                        b.ForeignKey("CWI.SkillMap.Domain.Entity.Profile", "ProfileProfileID");
                    });
                
                return builder.Model;
            }
        }
    }
}
