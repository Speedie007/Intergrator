using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreKbindustryJobBdMapping : IntegratorEntityTypeConfiguration<CoreKbIndustryJob>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbIndustryJob> builder)
        {
            builder.ToTable("CoreKbIndustryJobs");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreKbIndustryJobID");

            builder.HasOne(d => d.CoreKbIndustry)
                   .WithMany(p => p.CoreKbIndustryJobs)
                   .HasForeignKey(d => d.CoreKbIndustryID)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CoreKBIndustrySectorJobs_CoreKbIndustrySectors");

            builder.HasOne(d => d.CoreKbJob)
                .WithMany(p => p.CoreKbIndustryJobs)
                .HasForeignKey(d => d.CoreKbJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CoreKBIndustrySectorJobs_CoreKBJobs");

            base.Configure(builder);
        }
    }
}