﻿using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
    //CompanyAddresses
    public partial class CompanyAddressDbMapping : IntegratorEntityTypeConfiguration<CompanyAddress>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyAddress> builder)
        {
            builder.ToTable("CompanyAddresses")
                .Property(x => x.Id).HasColumnName("CompanyAddressID");

            builder.HasKey(e => e.Id);

            builder.HasOne(d => d.Address)
                    .WithMany(p => p.CompanyAddresses)
                    .HasForeignKey(d => d.AddressID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CompanyAddresses_Addresses");

            builder.HasOne(d => d.Company)
                .WithMany(p => p.CompanyAddresses)
                .HasForeignKey(d => d.CompanyID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyAddresses_Companies");

            base.Configure(builder);
        }
    }
}