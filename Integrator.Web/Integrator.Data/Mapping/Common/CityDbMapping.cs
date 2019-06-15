using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Common
{
    public partial class CityDbMapping : IntegratorEntityTypeConfiguration<City>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities")
                .Property(x => x.Id).HasColumnName("CityID");

            builder.HasKey(x=>x.Id);

            builder.Property(e => e.CityName)
                  .IsRequired()
                  .HasMaxLength(100)
                  .IsUnicode(false);



            builder.HasOne(d => d.Country)
                .WithMany(p => p.Cities)
                .HasForeignKey(d => d.CountryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Cities_Countries");

            base.Configure(builder);
        }
    }
}