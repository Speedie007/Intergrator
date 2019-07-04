using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
    public partial class CompanyRelatedIndustrySectorDbMapping : IntegratorEntityTypeConfiguration<CompanyRelatedIndustrySector>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyRelatedIndustrySector> builder)
        {
            builder.ToTable("CompanyRelatedIndustrySectors")
                .Property(x => x.Id).HasColumnName("CompanyRelatedIndustrySectorID");

            builder.HasKey(e => e.Id);

            builder.HasOne(d => d.CompanyRelatedIndustry)
                   .WithMany(p => p.CompanyRelatedIndustrySectors)
                   .HasForeignKey(d => d.CompanyRelatedIndustryID)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CompanyRelatedIndustrySectors_CompanyRelatedIndustries");

            builder.HasOne(d => d.CoreKbIndustrySector)
                .WithMany(p => p.CompanyRelatedIndustrySectors)
                .HasForeignKey(d => d.CoreKbIndustrySectorID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyRelatedIndustrySectors_CoreKbIndustrySectors");

            base.Configure(builder);
        }
    }
}