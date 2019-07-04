using Integrator.Models.Domain.KnowledgeBase.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Company
{
    public partial class CompanyJobDbMapping : IntegratorEntityTypeConfiguration<CompanyJob>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyJob> builder)
        {
            builder.ToTable("CompanyJobs");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CompanyJobID");

            builder.Property(e => e.JobDescription)
                   .IsRequired()
                   .IsUnicode(false);

            builder.HasOne(d => d.Company)
                     .WithMany(p => p.CompanyJobs)
                     .HasForeignKey(d => d.CompanyID)
                     .OnDelete(DeleteBehavior.Restrict)
                     .HasConstraintName("FK_CompanyJobs_Companies");

            builder.HasOne(d => d.CoreKbJob)
                .WithMany(p => p.CompanyJobs)
                .HasForeignKey(d => d.CoreKbJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyJobs_CoreKBJobs");

            base.Configure(builder);
        }
    }
}