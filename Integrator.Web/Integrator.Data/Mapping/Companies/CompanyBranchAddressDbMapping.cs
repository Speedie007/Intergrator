using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
    class CompanyBranchAddressDbMapping : IntegratorEntityTypeConfiguration<CompanyBranchAddress>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyBranchAddress> builder)
        {
            builder.ToTable("CompanyBranchAddresses")
                .Property(x => x.Id).HasColumnName("CompanyBranchAddressID");

            builder.HasKey(e => e.Id);

            builder.HasOne(d => d.Address)
                    .WithMany(p => p.CompanyBranchAddresses)
                    .HasForeignKey(d => d.AddressID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CompanyBranchAddresses_Addresses");

            builder.HasOne(d => d.CompanyBranch)
                .WithMany(p => p.CompanyBranchAddresses)
                .HasForeignKey(d => d.CompanyBranchID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyBranchAddresses_CompanyBranches");


            base.Configure(builder);
        }
    }
}