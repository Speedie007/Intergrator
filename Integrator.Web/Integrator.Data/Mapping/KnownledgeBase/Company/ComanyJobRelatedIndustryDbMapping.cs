using Integrator.Models.Domain.KnowledgeBase.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Company
{
    public partial class ComanyJobRelatedIndustryDbMapping : IntegratorEntityTypeConfiguration<CompanyJobRelatedIndustry>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyJobRelatedIndustry> builder)
        {
            builder.ToTable("CompanyJobRelatedIndustries");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CompanyJobRelatedIndustryID");

            builder.HasOne(d => d.CompanyJob)
                   .WithMany(p => p.CompanyJobRelatedIndustries)
                   .HasForeignKey(d => d.CompanyJobID)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_ComanyJobRelatedIndustries_CompanyJobs");

            builder.HasOne(d => d.CoreKbIndustry)
                .WithMany(p => p.ComanyJobRelatedIndustries)
                .HasForeignKey(d => d.CoreKbIndustryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ComanyJobRelatedIndustries_CoreKbIndustries");

            base.Configure(builder);
        }
    }
}