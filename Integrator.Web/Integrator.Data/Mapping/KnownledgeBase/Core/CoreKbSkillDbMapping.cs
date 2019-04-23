using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreKbSkillDbMapping : IntegratorEntityTypeConfiguration<CoreKbSkill>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbSkill> builder)
        {
            builder.ToTable("CoreKbSkills");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreKbSkillID");

            builder.Property(e => e.CoreSkill)
                   .IsRequired()
                   .HasMaxLength(150)
                   .IsUnicode(false);

            builder.HasOne(d => d.CoreSkillCategory)
                .WithMany(p => p.CoreKbSkills)
                .HasForeignKey(d => d.CoreSkillCategoryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CoreKBSkills_CoreSkillCategories");


            base.Configure(builder);
        }
    }
}