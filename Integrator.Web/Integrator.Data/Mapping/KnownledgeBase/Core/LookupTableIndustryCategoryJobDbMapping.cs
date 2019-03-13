using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class LookupTableIndustryCategoryJobDbMapping : IntegratorEntityTypeConfiguration<LookupTableIndustryCategoryJob>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<LookupTableIndustryCategoryJob> builder)
        {
            builder.ToTable("LookupTableIndustryCategoryJobs")
              .Property(x => x.Id).HasColumnName("IndustryCategoryJobID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.JobTitle).IsUnicode(false);

            builder.HasOne(d => d.IndustryCategory)
                .WithMany(p => p.LookupTableIndustryCategoryJobs)
                .HasForeignKey(d => d.IndustryCategoryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IndustryCategoryJobs_IndustryCategories");

            base.Configure(builder);
        }
    }
}
