using Integrator.Models.Domain.KnowledgeBase.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Company
{
   public partial  class CompanyIndustryCategoryJobDbMappings : IntegratorEntityTypeConfiguration<CompanyIndustryCategoryJob>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyIndustryCategoryJob> builder)
        {
            builder.ToTable("CompanyIndustryCategoryJobs")
               .Property(x => x.Id).HasColumnName("CompanyIndustryCategoryJobID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Description).IsUnicode(false);

            builder.HasOne(d => d.Company)
                .WithMany(p => p.CompanyIndustryCategoryJobs)
                .HasForeignKey(d => d.CompanyID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustryCategoryJobs_Companies");

            builder.HasOne(d => d.CompanyIndustryCategory)
                .WithMany(p => p.CompanyIndustryCategoryJobs)
                .HasForeignKey(d => d.CompanyIndustryCategoryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustryCategoryJobs_CompanyIndustryCategories");

            builder.HasOne(d => d.IndustryCategoryJob)
                .WithMany(p => p.CompanyIndustryCategoryJobs)
                .HasForeignKey(d => d.IndustryCategoryJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustryCategoryJobs_IndustryCategoryJobs");


            base.Configure(builder);
        }
    }
}