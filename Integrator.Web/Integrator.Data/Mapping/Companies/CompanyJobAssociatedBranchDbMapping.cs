using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
    public partial class CompanyJobAssociatedBranchDbMapping : IntegratorEntityTypeConfiguration<CompanyJobAssociatedBranch>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyJobAssociatedBranch> builder)
        {
            builder.ToTable("CompanyJobAssociatedBranches")
                .Property(x => x.Id).HasColumnName("CompanyJobAssociatedBranchID");

            builder.HasKey(e => e.Id);

            builder.HasOne(d => d.CompanyBranch)
                   .WithMany(p => p.CompanyJobAssociatedBranches)
                   .HasForeignKey(d => d.CompanyBranchID)
                   .OnDelete(DeleteBehavior.Cascade)
                   .HasConstraintName("FK_CompanyJobAssociatedBranches_CompanyBranches");

            builder.HasOne(d => d.CompanyJob)
                .WithMany(p => p.CompanyJobAssociatedBranches)
                .HasForeignKey(d => d.CompanyJobID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CompanyJobAssociatedBranches_CompanyJobs");


            base.Configure(builder);
        }
    }
}