using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.ContactDetials
{
    public partial class ContactDetailDbMapping : IntegratorEntityTypeConfiguration<ContactDetail>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<ContactDetail> builder)
        {
            builder.ToTable("ContactDetails")
                .Property(x => x.Id).HasColumnName("ContactDetailID");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.ContactItem).IsUnicode(false);

            builder.HasOne(d => d.ContactDetailType)
                .WithMany(p => p.ContactDetails)
                .HasForeignKey(d => d.ContactDetailTypeID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ContactDetails_ContactDetailTypes");

            base.Configure(builder);
        }
    }
}