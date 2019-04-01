using Integrator.Models.Domain.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Files
{
    public partial class IntegratorFileDbMapping : IntegratorEntityTypeConfiguration<IntegratorFiles>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IntegratorFiles> builder)
        {
            builder.ToTable("IntegratorFiles")
                .Property(x => x.Id).HasColumnName("FileID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.ContentType)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.DateCreated).HasColumnType("datetime");

            builder.Property(e => e.FileExtension)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            base.Configure(builder);
        }
    }
}