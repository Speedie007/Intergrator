using Integrator.Models.Domain.KnowledgeBase.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Core
{
    public partial class LookupTableIndustryCategoryDbMapping : IntegratorEntityTypeConfiguration<CoreKBIndustryCategory>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CoreKBIndustryCategory> builder)
        {
            builder.ToTable("CoreKBIndustryCategories")
              .Property(x => x.Id).HasColumnName("IndustryCategoryID");

            builder.HasKey(x => x.Id);

            builder.HasOne(d => d.Industry)
                .WithMany(p => p.CoreKBIndustryCategories)
                .HasForeignKey(d => d.IndustryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IndustryCategories_Industries");

            base.Configure(builder);
        }
    }
}
