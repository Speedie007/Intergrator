using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Common
{
    public partial class InterestDbMapping : IntegratorEntityTypeConfiguration<Interests>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Interests> builder)
        {
            builder.ToTable("Interests")
                .Property(x => x.Id).HasColumnName("InterestID");

            builder.Property(e => e.Interest)
                   .IsRequired()
                   .HasMaxLength(250)
                   .IsUnicode(false);

            builder.HasData(new Interests()
            {
                Id = 1,
                Interest = "Climbing"
            },
            new Interests()
            {
                Id = 2,
                Interest = "Snowboarding"
            }, new Interests()
            {
                Id = 3,
                Interest = "Cooking"
            });

            base.Configure(builder);
        }
    }
}