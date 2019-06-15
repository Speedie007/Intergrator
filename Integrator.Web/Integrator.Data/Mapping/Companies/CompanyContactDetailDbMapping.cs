using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
    //CompanyContactDetails
    public partial class CompanyContactDetailDbMapping : IntegratorEntityTypeConfiguration<CompanyContactDetail>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyContactDetail> builder)
        {
            builder.ToTable("CompanyContactDetails")
                .Property(x => x.Id).HasColumnName("CompanyContactDetailID");

            builder.HasKey(e => e.Id);


            builder.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyContactDetails)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CompanyContactDetails_Companies");

            builder.HasOne(d => d.ContactDetail)
                .WithMany(p => p.CompanyContactDetails)
                .HasForeignKey(d => d.ContactDetailID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyContactDetails_ContactDetails");

            base.Configure(builder);
        }
    }
}