using Integrator.Models.Domain.Agents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data.Mapping.Agents
{
    public partial class AgentAreaDbMapping : IntegratorEntityTypeConfiguration<AgentArea>
    {/// <summary>
     /// Configures the entity
     /// </summary>
     /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<AgentArea> builder)
        {
            builder.ToTable("AgentAreas")
                .Property(x => x.Id).HasColumnName("AgentAreaID");

            builder.HasKey(x => x.Id);

            builder.Property(e => e.DateAssigned)
                       .HasColumnType("datetime")
                       .HasDefaultValueSql("(getdate())");


            builder.HasOne(d => d.IntegratorUser)
                .WithMany(p => p.AgentAreas)
                .HasForeignKey(d => d.IntegratorUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AgentAreas_IntegratorUsers");

            builder.HasOne(d => d.Suburb)
                .WithMany(p => p.AgentAreas)
                .HasForeignKey(d => d.SuburbID)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_AgentAreas_Suburbs");

            base.Configure(builder);
        }
    }
}