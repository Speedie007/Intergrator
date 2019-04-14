using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Common
{
    public partial class InterestDbMapping : IntegratorEntityTypeConfiguration<Interest>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Interest> builder)
        {
            builder.ToTable("Interests")
                .Property(x => x.Id).HasColumnName("InterestID");

            builder.Property(e => e.AnInterest)
                   .IsRequired()
                   .HasMaxLength(250)
                   .IsUnicode(false);
                

            builder.HasData(new Interest()
            {
                Id = 1,
                AnInterest = "Climbing"
            },
            new Interest()
            {
                Id = 2,
                AnInterest = "Snowboarding"
            }, new Interest()
            {
                Id = 3,
                AnInterest = "Cooking"
            });

            base.Configure(builder);
        }
    }
}