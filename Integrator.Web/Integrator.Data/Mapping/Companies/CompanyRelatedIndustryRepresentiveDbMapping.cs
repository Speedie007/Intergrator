using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
   public partial  class CompanyRelatedIndustryRepresentiveDbMapping : IntegratorEntityTypeConfiguration<CompanyRelatedIndustryRepresentive>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyRelatedIndustryRepresentive> builder)
        {
            builder.ToTable("CompanyRelatedIndustryRepresentives")
                .Property(x => x.Id).HasColumnName("CompanyRelatedIndustryRepresentiveID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.DateAssigned)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.CompanyRelatedIndustry)
                .WithMany(p => p.CompanyRelatedIndustryRepresentives)
                .HasForeignKey(d => d.CompanyRelatedIndustryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyRelatedIndustryRepresentives_CompanyRelatedIndustries");

            builder.HasOne(d => d.CompanyRepresentative)
                .WithMany(p => p.CompanyRelatedIndustryRepresentives)
                .HasForeignKey(d => d.CompanyRepresentativeID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyRelatedIndustryRepresentives_CompanyRepresentatives");



            base.Configure(builder);
        }
    }
}