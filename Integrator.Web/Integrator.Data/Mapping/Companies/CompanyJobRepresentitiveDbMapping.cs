using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
    public partial class CompanyJobRepresentitiveDbMapping : IntegratorEntityTypeConfiguration<CompanyJobRepresentitive>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyJobRepresentitive> builder)
        {
            builder.ToTable("CompanyJobRepresentitives")
                .Property(x => x.Id).HasColumnName("CompanyJobRepresentitiveID");

            builder.HasKey(e => e.Id);

            builder.HasOne(d => d.CompanyJob)
                   .WithMany(p => p.CompanyJobRepresentitives)
                   .HasForeignKey(d => d.CompanyJobID)
                   .OnDelete(DeleteBehavior.Restrict)
                   .HasConstraintName("FK_CompanyJobRepresentitives_CompanyJobs");

            builder.HasOne(d => d.CompanyRepresentative)
                .WithMany(p => p.CompanyJobRepresentitives)
                .HasForeignKey(d => d.CompanyRepresentativeID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyJobRepresentitives_CompanyRepresentatives");


            base.Configure(builder);
        }
    }
}