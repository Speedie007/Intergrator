using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreKbIndustryCategoryDbMapping : IntegratorEntityTypeConfiguration<CoreKbIndustryCategory>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbIndustryCategory> builder)
        {
            builder.ToTable("CoreKbIndustryCategories");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreKbIndustryCategoryID");

            
            builder.Property(e => e.CoreKbIndustryCategoryName)
                .HasColumnName("CoreKBIndustryCategory")
                .HasMaxLength(100);

            builder.HasData(new CoreKbIndustryCategory()
            {
                 Id = 1,
                 CoreKbIndustryCategoryName = "Agriculture, Forestry, Fishing and Hunting"
            }, new CoreKbIndustryCategory()
            {
                Id = 2,
                CoreKbIndustryCategoryName = "Mining, Quarrying, and Oil and Gas Extraction"
            }, new CoreKbIndustryCategory()
            {
                Id = 3,
                CoreKbIndustryCategoryName = "Utilities"
            }, new CoreKbIndustryCategory()
            {
                Id = 4,
                CoreKbIndustryCategoryName = "Construction"
            }, new CoreKbIndustryCategory()
            {
                Id = 5,
                CoreKbIndustryCategoryName = "Manufacturing"
            }, new CoreKbIndustryCategory()
            {
                Id = 6,
                CoreKbIndustryCategoryName = "Wholesale Trade"
            }, new CoreKbIndustryCategory()
            {
                Id = 7,
                CoreKbIndustryCategoryName = "Retail Trade"
            }, new CoreKbIndustryCategory()
            {
                Id = 8,
                CoreKbIndustryCategoryName = "Transportation and Warehousing"
            }, new CoreKbIndustryCategory()
            {
                Id = 9,
                CoreKbIndustryCategoryName = "Information"
            }, new CoreKbIndustryCategory()
            {
                Id = 10,
                CoreKbIndustryCategoryName = "Finance and Insurance"
            }, new CoreKbIndustryCategory()
            {
                Id = 11,
                CoreKbIndustryCategoryName = "Real Estate and Rental and Leasing"
            }, new CoreKbIndustryCategory()
            {
                Id = 12,
                CoreKbIndustryCategoryName = "Professional, Scientific, and Technical Services"
            }, new CoreKbIndustryCategory()
            {
                Id = 13,
                CoreKbIndustryCategoryName = "Management of Companies and Enterprises"
            }, new CoreKbIndustryCategory()
            {
                Id = 14,
                CoreKbIndustryCategoryName = "Administrative, Support, Waste Management and Remediation Services"
            }, new CoreKbIndustryCategory()
            {
                Id = 15,
                CoreKbIndustryCategoryName = "Educational Services"
            }, new CoreKbIndustryCategory()
            {
                Id = 16,
                CoreKbIndustryCategoryName = "Health Care and Social Assistance"
            }, new CoreKbIndustryCategory()
            {
                Id = 17,
                CoreKbIndustryCategoryName = "Arts, Entertainment, and Recreation"
            }, new CoreKbIndustryCategory()
            {
                Id = 18,
                CoreKbIndustryCategoryName = "Accommodation and Food Services"
            }, new CoreKbIndustryCategory()
            {
                Id = 19,
                CoreKbIndustryCategoryName = "Other Services (Except Public Administration)"
            }, new CoreKbIndustryCategory()
            {
                Id = 20,
                CoreKbIndustryCategoryName = "Public Administration"
            });

            base.Configure(builder);
        }
    }
}