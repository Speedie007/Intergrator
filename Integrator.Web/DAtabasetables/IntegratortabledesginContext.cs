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

        public virtual DbSet<CompanyJobs> CompanyJobs { get; set; }
        public virtual DbSet<CompanyRelatedIndustries> CompanyRelatedIndustries { get; set; }
        public virtual DbSet<CompanyRelatedIndustrySectors> CompanyRelatedIndustrySectors { get; set; }
        public virtual DbSet<CompnayJobRelatedIndustrySectors> CompnayJobRelatedIndustrySectors { get; set; }
        public virtual DbSet<CoreKbIndustries> CoreKbIndustries { get; set; }
        public virtual DbSet<CoreKbIndustrySectors> CoreKbIndustrySectors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<CompanyJobs>(entity =>
            {
                entity.HasKey(e => e.CompanyJobId);

                entity.HasIndex(e => e.CoreKbJobId);

                entity.Property(e => e.CompanyJobId).HasColumnName("CompanyJobID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CoreKbJobId).HasColumnName("CoreKbJobID");

                entity.Property(e => e.JobDescription)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyRelatedIndustries>(entity =>
            {
                entity.HasKey(e => e.CompanyRelatedIndustryId);

                entity.HasIndex(e => e.CoreKbIndustryId);

                entity.Property(e => e.CompanyRelatedIndustryId).HasColumnName("CompanyRelatedIndustryID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CoreKbIndustryId).HasColumnName("CoreKbIndustryID");

                entity.HasOne(d => d.CoreKbIndustry)
                    .WithMany(p => p.CompanyRelatedIndustries)
                    .HasForeignKey(d => d.CoreKbIndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyRelatedIndustries_CoreKbIndustries");
            });

            modelBuilder.Entity<CompanyRelatedIndustrySectors>(entity =>
            {
                entity.HasKey(e => e.CompanyRelatedIndustrySectorId);

                entity.Property(e => e.CompanyRelatedIndustrySectorId).HasColumnName("CompanyRelatedIndustrySectorID");

                entity.Property(e => e.CompanyRelatedIndustryId).HasColumnName("CompanyRelatedIndustryID");

                entity.Property(e => e.CoreKbIndustrySectorId).HasColumnName("CoreKbIndustrySectorID");

                entity.HasOne(d => d.CompanyRelatedIndustry)
                    .WithMany(p => p.CompanyRelatedIndustrySectors)
                    .HasForeignKey(d => d.CompanyRelatedIndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyRelatedIndustrySectors_CompanyRelatedIndustries");

                entity.HasOne(d => d.CoreKbIndustrySector)
                    .WithMany(p => p.CompanyRelatedIndustrySectors)
                    .HasForeignKey(d => d.CoreKbIndustrySectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyRelatedIndustrySectors_CoreKbIndustrySectors");
            });

            modelBuilder.Entity<CompnayJobRelatedIndustrySectors>(entity =>
            {
                entity.HasKey(e => e.CompnayJobRelatedIndustrySectorId);

                entity.Property(e => e.CompnayJobRelatedIndustrySectorId).HasColumnName("CompnayJobRelatedIndustrySectorID");

                entity.Property(e => e.CompanyJobId).HasColumnName("CompanyJobID");

                entity.Property(e => e.CompanyRelatedIndustrySectorId).HasColumnName("CompanyRelatedIndustrySectorID");

                entity.HasOne(d => d.CompanyJob)
                    .WithMany(p => p.CompnayJobRelatedIndustrySectors)
                    .HasForeignKey(d => d.CompanyJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompnayJobRelatedIndustrySectors_CompanyJobs");

                entity.HasOne(d => d.CompanyRelatedIndustrySector)
                    .WithMany(p => p.CompnayJobRelatedIndustrySectors)
                    .HasForeignKey(d => d.CompanyRelatedIndustrySectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompnayJobRelatedIndustrySectors_CompanyRelatedIndustrySectors");
            });

            modelBuilder.Entity<CoreKbIndustries>(entity =>
            {
                entity.HasKey(e => e.CoreKbIndustryId);

                entity.HasIndex(e => e.CoreKbIndustryCategoryId);

                entity.Property(e => e.CoreKbIndustryId).HasColumnName("CoreKbIndustryID");

                entity.Property(e => e.CoreKbIndustryCategoryId).HasColumnName("CoreKbIndustryCategoryID");

                entity.Property(e => e.CoreKbindustryName)
                    .IsRequired()
                    .HasColumnName("CoreKBIndustryName")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CoreKbIndustrySectors>(entity =>
            {
                entity.HasKey(e => e.CoreKbIndustrySectorId);

                entity.Property(e => e.CoreKbIndustrySectorId).HasColumnName("CoreKbIndustrySectorID");

                entity.Property(e => e.CoreKbIndustryId).HasColumnName("CoreKbIndustryID");

                entity.Property(e => e.IndustrySectorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CoreKbIndustry)
                    .WithMany(p => p.CoreKbIndustrySectors)
                    .HasForeignKey(d => d.CoreKbIndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreKbIndustrySectors_CoreKbIndustries");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}