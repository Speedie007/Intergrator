using Integrator.Models.Domain.KnowledgeBase.IndividualUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Users
{
    public partial class IntergratorUserAddressDbMapping : IntegratorEntityTypeConfiguration<IndividualAddress>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<IndividualAddress> builder)
        {
            builder.ToTable("IndividualAddresses")
                .Property(x => x.Id).HasColumnName("IndividualAddressID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.DateCreated)
                  .HasColumnName("DateCreated")
                  .HasColumnType("datetime")
                  .HasDefaultValueSql("(getdate())");


            builder.HasOne(d => d.Address)
                .WithMany(p => p.CustomerAddresses)
                .HasForeignKey(d => d.AddressID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CustomerAddresses_Addresses");

            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.CustomerAddresses)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_CustomerAddresses_IntegratorUsers");

            base.Configure(builder);
        }
    }
}