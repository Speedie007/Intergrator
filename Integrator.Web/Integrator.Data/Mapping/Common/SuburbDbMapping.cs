using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Common
{
    public partial class SuburbDbMapping : IntegratorEntityTypeConfiguration<Suburb>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Suburb> builder)
        {
            builder.ToTable("Suburbs")
                .Property(x => x.Id).HasColumnName("SuburbID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.SuburbName)
                   .HasMaxLength(100)
                   .IsUnicode(false);

            builder.HasOne(d => d.City)
                .WithMany(p => p.Suburbs)
                .HasForeignKey(d => d.CityID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Suburbs_Cities");

            base.Configure(builder);
        }
    }
}