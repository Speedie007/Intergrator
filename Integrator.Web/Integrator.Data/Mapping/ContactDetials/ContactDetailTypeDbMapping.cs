using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.ContactDetials
{
    public partial class ContactDetailTypeDbMapping : IntegratorEntityTypeConfiguration<ContactDetailType>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<ContactDetailType> builder)
        {
            builder.ToTable("ContactDetailTypes")
                .Property(x => x.Id).HasColumnName("ContactDetailTypeID");

            builder.Property(e => e.aContactDetailType).IsUnicode(false)
                .HasColumnName("ContactDetailType");

            builder.HasData(new ContactDetailType()
            {
                 Id = 1,
                  aContactDetailType ="Cell Number"
            },
            new ContactDetailType()
            {
                Id = 2,
                aContactDetailType = "Office Number"
            },
            new ContactDetailType()
            {
                Id = 3,
                aContactDetailType = "Email Address"
            },
            new ContactDetailType()
            {
                Id = 4,
               aContactDetailType = "WebSite"
            });

            base.Configure(builder);
        }
    }
}