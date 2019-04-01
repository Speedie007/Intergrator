using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Users
{
    public partial class IntegratorUserContactDetailDbMapping : IntegratorEntityTypeConfiguration<IntegratorUserContactDetails>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IntegratorUserContactDetails> builder)
        {
            builder.ToTable("IntegratorUserContactDetails")
                .Property(x => x.Id).HasColumnName("IntegratorUserContactDetailID");

            builder.Property(e => e.DateLastUpdated).HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.ContactDetail)
                .WithMany(p => p.IntegratorUserContactDetails)
                .HasForeignKey(d => d.ContactDetailID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserContactDetails_ContactDetails");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.IntegratorUserContactDetails)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_IntegratorUserContactDetails_IntegratorUsers");

            base.Configure(builder);
        }
    }
}