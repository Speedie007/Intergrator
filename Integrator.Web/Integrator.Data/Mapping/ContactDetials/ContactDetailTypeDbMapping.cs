using Integrator.Models.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.ContactDetials
{
    public partial class ContactDetailTypeDbMapping : IntegratorEntityTypeConfiguration<ContactDetailTypes>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<ContactDetailTypes> builder)
        {
            builder.ToTable("ContactDetailTypes")
                .Property(x => x.Id).HasColumnName("ContactDetailTypeID");

            builder.Property(e => e.ContactDetailType).IsUnicode(false);

            builder.HasData(new ContactDetailTypes()
            {
                 Id = 1,
                  ContactDetailType ="Cell Number"
            },
            new ContactDetailTypes()
            {
                Id = 2,
                ContactDetailType = "Office Number"
            },
            new ContactDetailTypes()
            {
                Id = 3,
                ContactDetailType = "Email Address"
            },
            new ContactDetailTypes()
            {
                Id = 4,
                ContactDetailType = "WebSite"
            });

            base.Configure(builder);
        }
    }
}