using Integrator.Models.Domain.KnowledgeBase.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Company
{
    public partial class CompanyIndustryCategoryDbMapping : IntegratorEntityTypeConfiguration<CompanyIndustryCategory>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyIndustryCategory> builder)
        {
            builder.ToTable("CompanyIndustryCategories")
               .Property(x => x.Id).HasColumnName("CompanyIndustryCategoryID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Description).IsUnicode(false);

            builder.HasOne(d => d.Company)
                .WithMany(p => p.CompanyIndustryCategories)
                .HasForeignKey(d => d.CompanyID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustryCategories_Companies");

            builder.HasOne(d => d.CompanyIndustry)
                .WithMany(p => p.CompanyIndustryCategories)
                .HasForeignKey(d => d.CompanyIndustryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustryCategories_CompanyIndustries");

            builder.HasOne(d => d.CoreKBIndustryCategory)
                .WithMany(p => p.CompanyIndustryCategories)
                .HasForeignKey(d => d.CoreKBIndustryCategoryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustryCategories_IndustryCategories");

            base.Configure(builder);
        }
    }
}
