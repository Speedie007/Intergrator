using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreKbIndustrySectorDbMapping : IntegratorEntityTypeConfiguration<CoreKbIndustrySector>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbIndustrySector> builder)
        {
            builder.ToTable("CoreKbIndustrySectors")
                .Property(x => x.Id).HasColumnName("CoreKbIndustrySectorID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.IndustrySectorName)
                   .IsRequired()
                   .HasMaxLength(100)
                   .IsUnicode(false);

            builder.HasOne(d => d.CoreKbIndustry)
                .WithMany(p => p.CoreKbIndustrySectors)
                .HasForeignKey(d => d.CoreKbIndustryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CoreKbIndustrySectors_CoreKbIndustries");



            base.Configure(builder);
        }
    }
}