﻿using Integrator.Models.Domain.KnowledgeBase.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.KnownledgeBase.Company
{
    public partial class CompanyIndustryDbMapping : IntegratorEntityTypeConfiguration<CompanyIndustry>
    {

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<CompanyIndustry> builder)
        {

            builder.ToTable("Company")
               .Property(x => x.Id).HasColumnName("CompanyID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Description).IsUnicode(false);

            builder.HasOne(d => d.Company)
                .WithMany(p => p.CompanyIndustries)
                .HasForeignKey(d => d.CompanyID)
                .HasConstraintName("FK_CompanyIndustries_Companies");

            builder.HasOne(d => d.Industry)
                .WithMany(p => p.CompanyIndustries)
                .HasForeignKey(d => d.IndustryID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CompanyIndustries_Industries");

            base.Configure(builder);
        }
    }
}
