using Integrator.Models.Domain.Address;
using Integrator.Models.Domain.Companies;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Companies
{
    public partial class CampanyDbMapping : IntegratorEntityTypeConfiguration<Company>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company")
                .Property(x => x.Id).HasColumnName("CompanyID");
            

            base.Configure(builder);
        }
    }
}