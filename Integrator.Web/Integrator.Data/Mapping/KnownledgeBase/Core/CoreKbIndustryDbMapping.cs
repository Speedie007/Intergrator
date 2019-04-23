using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class CoreKbIndustryDbMapping : IntegratorEntityTypeConfiguration<CoreKbIndustry>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKbIndustry> builder)
        {
            builder.ToTable("CoreKbIndustries");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CoreKbIndustryID");


            builder.Property(e => e.CoreKbIndustryName)
                               .IsRequired()
                               .HasColumnName("CoreKBIndustryName")
                               .HasMaxLength(150)
                               .IsUnicode(false);

            builder.HasOne(d => d.CoreKbIndustryCategory)
                .WithMany(p => p.CoreKbIndustries)
                .HasForeignKey(d => d.CoreKbIndustryCategoryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CoreKbIndustrySectors_CoreKBIdustryCategories");

            builder.HasData(new CoreKbIndustry()
            {
                Id = 1,
                CoreKbIndustryCategoryID = 1,
                CoreKbIndustryName = "Farming and Ranching"
            },
            new CoreKbIndustry()
            {
                Id = 2,
                CoreKbIndustryCategoryID = 1,
                CoreKbIndustryName = "Fishing"
            },
            new CoreKbIndustry()
            {
                Id = 3,
                CoreKbIndustryCategoryID = 1,
                CoreKbIndustryName = "Hunting "
            },
            new CoreKbIndustry()
            {
                Id = 4,
                CoreKbIndustryCategoryID = 1,
                CoreKbIndustryName = "Forestry"
            },
             new CoreKbIndustry()
             {
                 Id = 5,
                 CoreKbIndustryCategoryID = 1,
                 CoreKbIndustryName = "Mining and Quarrying"
             });

            base.Configure(builder);
        }
    }
}