using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
   public partial  class CompnayJobRelatedIndustrySectorDbMapping : IntegratorEntityTypeConfiguration<CompanyJobRelatedIndustrySector>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyJobRelatedIndustrySector> builder)
        {
            builder.ToTable("CompanyJobRelatedIndustrySectors")
                .Property(x => x.Id).HasColumnName("CompanyJobRelatedIndustrySectorID");

            builder.HasKey(e => e.Id);


            builder.HasOne(d => d.CompanyJob)
                    .WithMany(p => p.CompanyJobRelatedIndustrySectors)
                    .HasForeignKey(d => d.CompanyJobID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CompnayJobRelatedIndustrySectors_CompanyJobs");

            builder.HasOne(d => d.CompanyRelatedIndustrySector)
                .WithMany(p => p.CompanyJobRelatedIndustrySectors)
                .HasForeignKey(d => d.CompanyRelatedIndustrySectorID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompnayJobRelatedIndustrySectors_CompanyRelatedIndustrySectors");

            base.Configure(builder);
        }
    }
}