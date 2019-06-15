using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAtabasetables
{
    public partial class IntegratortabledesginContext : DbContext
    {
        public IntegratortabledesginContext()
        {
        }

        public IntegratortabledesginContext(DbContextOptions<IntegratortabledesginContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CompanyJobRepresentitives> CompanyJobRepresentitives { get; set; }
        public virtual DbSet<CompanyJobs> CompanyJobs { get; set; }
        public virtual DbSet<CompanyRelatedIndustries> CompanyRelatedIndustries { get; set; }
        public virtual DbSet<CompanyRelatedIndustryRepresentives> CompanyRelatedIndustryRepresentives { get; set; }
        public virtual DbSet<CompanyRepresentatives> CompanyRepresentatives { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=IntegratorTableDesgin;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<CompanyJobRepresentitives>(entity =>
            {
                entity.HasKey(e => e.CompanyJobRepresentitiveId);

                entity.Property(e => e.CompanyJobRepresentitiveId).HasColumnName("CompanyJobRepresentitiveID");

                entity.Property(e => e.CompanyJobId).HasColumnName("CompanyJobID");

                entity.Property(e => e.CompanyRepresentativeId).HasColumnName("CompanyRepresentativeID");

                entity.HasOne(d => d.CompanyJob)
                    .WithMany(p => p.CompanyJobRepresentitives)
                    .HasForeignKey(d => d.CompanyJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyJobRepresentitives_CompanyJobs");

                entity.HasOne(d => d.CompanyRepresentative)
                    .WithMany(p => p.CompanyJobRepresentitives)
                    .HasForeignKey(d => d.CompanyRepresentativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyJobRepresentitives_CompanyRepresentatives");
            });

            modelBuilder.Entity<CompanyJobs>(entity =>
            {
                entity.HasKey(e => e.CompanyJobId);

                entity.HasIndex(e => e.CompanyId);

                entity.HasIndex(e => e.CoreKbjobId)
                    .HasName("IX_CompanyJobs_CoreKbJobID");

                entity.Property(e => e.CompanyJobId).HasColumnName("CompanyJobID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CoreKbjobId).HasColumnName("CoreKBJobID");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyRelatedIndustries>(entity =>
            {
                entity.HasKey(e => e.CompanyRelatedIndustryId);

                entity.HasIndex(e => e.CompanyId);

                entity.HasIndex(e => e.CoreKbindustryId)
                    .HasName("IX_CompanyRelatedIndustries_CoreKbIndustryID");

                entity.Property(e => e.CompanyRelatedIndustryId).HasColumnName("CompanyRelatedIndustryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CoreKbindustryId).HasColumnName("CoreKBIndustryID");
            });

            modelBuilder.Entity<CompanyRelatedIndustryRepresentives>(entity =>
            {
                entity.HasKey(e => e.CompanyRelatedIndustryRepresentiveId);

                entity.Property(e => e.CompanyRelatedIndustryRepresentiveId).HasColumnName("CompanyRelatedIndustryRepresentiveID");

                entity.Property(e => e.CompanyRelatedIndustryId).HasColumnName("CompanyRelatedIndustryID");

                entity.Property(e => e.CompanyRepresentativeId).HasColumnName("CompanyRepresentativeID");

                entity.Property(e => e.DateAssigned)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CompanyRelatedIndustry)
                    .WithMany(p => p.CompanyRelatedIndustryRepresentives)
                    .HasForeignKey(d => d.CompanyRelatedIndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyRelatedIndustryRepresentives_CompanyRelatedIndustries");

                entity.HasOne(d => d.CompanyRepresentative)
                    .WithMany(p => p.CompanyRelatedIndustryRepresentives)
                    .HasForeignKey(d => d.CompanyRepresentativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyRelatedIndustryRepresentives_CompanyRepresentatives");
            });

            modelBuilder.Entity<CompanyRepresentatives>(entity =>
            {
                entity.HasKey(e => e.CompanyRepresentativeId);

                entity.HasIndex(e => e.CompanyId);

                entity.HasIndex(e => e.IntegratorUserId);

                entity.Property(e => e.CompanyRepresentativeId).HasColumnName("CompanyRepresentativeID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.IntegratorUserId).HasColumnName("IntegratorUserID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}