using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreKbJobSkillDbMapping : IntegratorEntityTypeConfiguration<CoreKbJobSkill>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbJobSkill> builder)
        {
            builder.ToTable("CoreKbJobSkills");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreKbJobSkillID");

            builder.HasOne(d => d.CoreJob)
                   .WithMany(p => p.CoreKbJobSkills)
                   .HasForeignKey(d => d.CoreKbJobID)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CoreKBJobSkills_CoreKBJobs");

            builder.HasOne(d => d.CoreSkill)
                .WithMany(p => p.CoreKbJobSkills)
                .HasForeignKey(d => d.CoreKbSkillID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CoreKBJobSoftSkills_CoreSoftSkills");
            base.Configure(builder);
        }
    }
}