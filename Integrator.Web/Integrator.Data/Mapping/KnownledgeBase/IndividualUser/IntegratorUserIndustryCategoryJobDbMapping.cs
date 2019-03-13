using Integrator.Models.Domain.KnowledgeBase.IndividualUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.IndividualUser
{
    public partial class IntegratorUserIndustryCategoryJobDbMapping : IntegratorEntityTypeConfiguration<IntegratorUserIndustryCategoryJob>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IntegratorUserIndustryCategoryJob> builder)
        {
            builder.ToTable("IntegratorUserIndustryCategoryJobs")
              .Property(x => x.Id).HasColumnName("IntegratorUserIndustryCategoryJobID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Description).IsUnicode(false);

            builder.HasOne(d => d.IndustryCategoryJob)
                .WithMany(p => p.IntegratorUserIndustryCategoryJobs)
                .HasForeignKey(d => d.IndustryCategoryJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserIndustryCategoryJobs_IndustryCategoryJobs");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.IntegratorUserIndustryCategoryJobs)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserIndustryCategoryJobs_Users");

            builder.HasOne(d => d.IntegratorUserIndustryCategory)
                .WithMany(p => p.IntegratorUserIndustryCategoryJobs)
                .HasForeignKey(d => d.IntegratorUserIndustryCategoryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserIndustryCategoryJobs_IntegratorUserIndustryCategories");

            base.Configure(builder);
        }
    }
}
