using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.IndividualUser
{
    public partial class IntegratorUserIndustryCategoryJobSkillSetDbMapping : IntegratorEntityTypeConfiguration<IntegratorUserIndustryCategoryJobSkillSet>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IntegratorUserIndustryCategoryJobSkillSet> builder)
        {
            builder.ToTable("IntegratorUserIndustryCategoryJobSkillSets")
              .Property(x => x.Id).HasColumnName("IntegratorUserIndustryCategoryJobSkillSetID");
            builder.HasKey(x => x.Id);

            builder.Property(e => e.Description).IsUnicode(false);
            builder.Property(e => e.Description).HasMaxLength(1000);
            builder.Property(e => e.SkillLevel).HasColumnType("numeric(18, 2)");

            builder.HasOne(d => d.CoreKBIndustryCategoryJobSkillSet)
                .WithMany(p => p.IntegratorUserIndustryCategoryJobSkillSets)
                .HasForeignKey(d => d.CoreKBIndustryCategorySkillSetID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserIndustryCategoryJobSkillSets_IndustryCategorySkillSets");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.IntegratorUserIndustryCategoryJobSkillSets)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserIndustryCategoryJobSkillSets_Users");

            builder.HasOne(d => d.IntegratorUserIndustryCategoryJob)
                .WithMany(p => p.IntegratorUserIndustryCategoryJobSkillSets)
                .HasForeignKey(d => d.IntegratorUserIndustryCategoryJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserIndustryCategoryJobSkillSets_IntegratorUserIndustryCategoryJobs");

            base.Configure(builder);
        }
    }
}

