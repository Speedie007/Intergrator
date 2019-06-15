using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
    public partial class CompanyRepresentativeDbMappings : IntegratorEntityTypeConfiguration<CompanyRepresentative>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyRepresentative> builder)
        {
            builder.ToTable("CompanyRepresentatives")
                .Property(x => x.Id).HasColumnName("CompanyRepresentativeID");

            builder.HasKey(e => e.Id);


            builder.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyRepresentatives)
                    .HasForeignKey(d => d.CompanyID)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CompanyRepresentatives_Companies");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.CompanyRepresentatives)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyRepresentatives_IntegratorUsers");

            base.Configure(builder);
        }
    }
}