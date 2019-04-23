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
                 CoreKbIndustryCategoryName = "Agriculture and Mining"
            }, new CoreKbIndustryCategory()
            {
                Id = 2,
                CoreKbIndustryCategoryName = "Business Services"
            }, new CoreKbIndustryCategory()
            {
                Id = 3,
                CoreKbIndustryCategoryName = "Education"
            }, new CoreKbIndustryCategory()
            {
                Id = 4,
                CoreKbIndustryCategoryName = "Consumer Services"
            }, new CoreKbIndustryCategory()
            {
                Id = 5,
                CoreKbIndustryCategoryName = "Education"
            }, new CoreKbIndustryCategory()
            {
                Id = 6,
                CoreKbIndustryCategoryName = "Energy and Utilities"
            });

            base.Configure(builder);
        }
    }
}