
using Integrator.Models.Domain.Addresses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Addresses
{
    public partial class AddressDbMapping : IntegratorEntityTypeConfiguration<Address>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses")
                .Property(x => x.Id).HasColumnName("AddressID");

            builder.HasKey(x => x.Id);

            builder.ToTable("Addresses")
                .HasDiscriminator<AddressTypes>("AddressType")
                .HasValue<StreetAddress>(AddressTypes.StreetAddress)
            .HasValue<POBoxAddress>(AddressTypes.POBoxAddress)
            .HasValue<ComplexAddress>(AddressTypes.ComplexAddress);

            builder.HasOne(d => d.City)
                   .WithMany(p => p.Addresses)
                   .HasForeignKey(d => d.CityID)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_Addresses_Cities");

            builder.HasOne(d => d.Country)
                .WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Addresses_Countries");

            builder.HasOne(d => d.Suburb)
                .WithMany(p => p.Addresses)
                .HasForeignKey(d => d.SuburbID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Addresses_Suburbs");

            base.Configure(builder);
        }
    }
}