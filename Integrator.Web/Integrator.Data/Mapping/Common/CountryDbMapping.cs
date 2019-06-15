using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Common
{
    public partial class CountryDbMapping : IntegratorEntityTypeConfiguration<Country>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries")
                .Property(x => x.Id).HasColumnName("CountryID");

            builder.HasKey(x => x.Id);


            builder.Property(e => e.CountryCode)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.CountryName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            base.Configure(builder);
        }
    }
}