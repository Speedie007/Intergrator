using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
  public partial   class CompanyRelatedIndustryDbMapping : IntegratorEntityTypeConfiguration<CompanyRelatedIndustry>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyRelatedIndustry> builder)
        {
            builder.ToTable("CompanyRelatedIndustries");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CompanyRelatedIndustryID");



            builder.HasOne(d => d.Company)
                     .WithMany(p => p.CompanyRelatedIndustries)
                     .HasForeignKey(d => d.CompanyID)
                     .OnDelete(DeleteBehavior.Restrict)
                     .HasConstraintName("FK_CompanyRelatedIndustries_Company");

            builder.HasOne(d => d.CoreKbIndustry)
                .WithMany(p => p.CompanyRelatedIndustries)
                .HasForeignKey(d => d.CoreKbIndustryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyRelatedIndustries_CoreKbIndustries");


            base.Configure(builder);
        }
    }
}