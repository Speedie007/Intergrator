using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Common
{
    public partial class InterestLevelDbMapping : IntegratorEntityTypeConfiguration<InterestLevels>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<InterestLevels> builder)
        {
            builder.ToTable("InterestLevels")
                .Property(x => x.Id).HasColumnName("InterestLevelID");

            builder.Property(e => e.InterestLevel)
                   .IsRequired()
                   .HasMaxLength(25)
                   .IsUnicode(false)
                   .HasDefaultValueSql("('High')");

            builder.HasData(new InterestLevels() {
                 Id= 1,
                  InterestLevel = "High"
            },
            new InterestLevels()
            {
                Id = 2,
                InterestLevel = "Average"
            },
            new InterestLevels()
            {
                Id = 3,
                InterestLevel = "Low"
            });

            base.Configure(builder);
        }
    }
}