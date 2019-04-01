using Integrator.Models.Domain.KnowledgeBase.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Company
{
    public partial class CompanyIndustryDbMapping : IntegratorEntityTypeConfiguration<CompanyIndustry>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyIndustry> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("CompanyIndustries")
               .Property(x => x.Id).HasColumnName("CompanyIndustryID");

            builder.Property(e => e.Description).IsUnicode(false);

            builder.HasOne(d => d.Company)
                .WithMany(p => p.CompanyIndustries)
                .HasForeignKey(d => d.CompanyID)
                .HasConstraintName("FK_CompanyIndustries_Companies");

            builder.HasOne(d => d.CoreKBIndustry)
                .WithMany(p => p.CompanyIndustries)
                .HasForeignKey(d => d.CoreKBIndustryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustries_Industries");

            base.Configure(builder);
        }
    }
}
