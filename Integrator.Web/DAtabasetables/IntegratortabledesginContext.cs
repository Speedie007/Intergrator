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

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<CompanyAddresses> CompanyAddresses { get; set; }
        public virtual DbSet<CompanyContactDetails> CompanyContactDetails { get; set; }
        public virtual DbSet<CompanyRepresentatives> CompanyRepresentatives { get; set; }
        public virtual DbSet<ContactDetails> ContactDetails { get; set; }
        public virtual DbSet<IntegratorUsers> IntegratorUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BLJSHVF;Initial Catalog=IntegratorTableDesgin;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.HasIndex(e => e.IntegratorUserId);

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.IntegratorUserId).HasColumnName("IntegratorUserID");

                entity.Property(e => e.PoboxNumber).HasColumnName("POBoxNumber");

                entity.HasOne(d => d.IntegratorUser)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.IntegratorUserId);
            });

            modelBuilder.Entity<Companies>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(150);
            });

            modelBuilder.Entity<CompanyAddresses>(entity =>
            {
                entity.HasKey(e => e.CompanyAddressId);

                entity.Property(e => e.CompanyAddressId).HasColumnName("CompanyAddressID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CompanyAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyAddresses_Addresses");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyAddresses)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyAddresses_Companies");
            });

            modelBuilder.Entity<CompanyContactDetails>(entity =>
            {
                entity.HasKey(e => e.CompanyContactDetailId);

                entity.Property(e => e.CompanyContactDetailId).HasColumnName("CompanyContactDetailID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactDetailId).HasColumnName("ContactDetailID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyContactDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyContactDetails_Companies");

                entity.HasOne(d => d.ContactDetail)
                    .WithMany(p => p.CompanyContactDetails)
                    .HasForeignKey(d => d.ContactDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyContactDetails_ContactDetails");
            });

            modelBuilder.Entity<CompanyRepresentatives>(entity =>
            {
                entity.HasKey(e => e.CompanyRepresentativeId);

                entity.Property(e => e.CompanyRepresentativeId).HasColumnName("CompanyRepresentativeID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.IntegratorUserId).HasColumnName("IntegratorUserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyRepresentatives)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyRepresentatives_Companies");

                entity.HasOne(d => d.IntegratorUser)
                    .WithMany(p => p.CompanyRepresentatives)
                    .HasForeignKey(d => d.IntegratorUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyRepresentatives_IntegratorUsers");
            });

            modelBuilder.Entity<ContactDetails>(entity =>
            {
                entity.HasKey(e => e.ContactDetailId);

                entity.HasIndex(e => e.ContactDetailTypeId);

                entity.Property(e => e.ContactDetailId).HasColumnName("ContactDetailID");

                entity.Property(e => e.ContactDetailTypeId).HasColumnName("ContactDetailTypeID");

                entity.Property(e => e.ContactItem)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntegratorUsers>(entity =>
            {
                entity.HasKey(e => e.IntegratorUserId);

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.IntegratorUserId).HasColumnName("IntegratorUserID");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}