using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace YAMS_Repository.YAMS_Repository
{
    public partial class YAMSContext : DbContext
    {
        public YAMSContext()
        {
        }

        public YAMSContext(DbContextOptions<YAMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=YAMS;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("Register");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("confirm_password");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.ToTable("UserTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
