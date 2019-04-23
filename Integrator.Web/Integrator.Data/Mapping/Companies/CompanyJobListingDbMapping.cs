using Integrator.Models.Domain.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
   public partial  class CompanyJobListingDbMapping : IntegratorEntityTypeConfiguration<CompanyJobListing>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyJobListing> builder)
        {
            builder.ToTable("CompanyJobListings");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("CompanyJobListingID");



            builder.Property(e => e.DateEnded)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.DateStarted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.CompanyJob)
                .WithMany(p => p.CompanyJobListings)
                .HasForeignKey(d => d.CompanyJobID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyJobListings_CompanyJobs");


            base.Configure(builder);
        }
    }
}