using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAtabasetables
{
    public partial class IntegratordbContext : DbContext
    {
        public IntegratordbContext()
        {
        }

        public IntegratordbContext(DbContextOptions<IntegratordbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IntegratorUserInterests> IntegratorUserInterests { get; set; }
        public virtual DbSet<IntegratorUsers> IntegratorUsers { get; set; }
        public virtual DbSet<Interests> Interests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=IntegratorDb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<IntegratorUserInterests>(entity =>
            {
                

                
            });

            modelBuilder.Entity<IntegratorUsers>(entity =>
            {
                

              
            });

            modelBuilder.Entity<Interests>(entity =>
            {
               

               

                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}