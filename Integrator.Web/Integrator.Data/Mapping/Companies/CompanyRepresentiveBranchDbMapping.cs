using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
    public partial class CompanyRepresentiveBranchDbMapping : IntegratorEntityTypeConfiguration<CompanyRepresentiveBranch>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyRepresentiveBranch> builder)
        {
            builder.ToTable("CompanyRepresentiveBranches")
                .Property(x => x.Id).HasColumnName("CompanyRepresentiveBranchID");

            builder.HasKey(e => e.Id);


            builder.HasOne(d => d.CompanyBranch)
                     .WithMany(p => p.CompanyRepresentiveBranches)
                     .HasForeignKey(d => d.CompanyBranchID)
                     .OnDelete(DeleteBehavior.Cascade)
                     .HasConstraintName("FK_CompnayRepresentiveBanches_CompanyBranches");

            builder.HasOne(d => d.CompanyRepresentative)
                .WithMany(p => p.CompanyRepresentiveBranches)
                .HasForeignKey(d => d.CompanyRepresentativeID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CompnayRepresentiveBanches_CompanyRepresentatives");

            base.Configure(builder);
        }
    }
}