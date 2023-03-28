using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UserAPI.Models
{
    public partial class UserContext : DbContext
    {
        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\Local;Database=User;Integrated Security=True; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.Mname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MName");

                entity.Property(e => e.Saddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SAddress");

                entity.Property(e => e.SemailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEmailAddress");

                entity.Property(e => e.Sgrade)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SGrade");

                entity.Property(e => e.Slocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sstandard).HasColumnName("SStandard");

                entity.Property(e => e.StotalMarks).HasColumnName("STotalMarks");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.Mname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MName");

                entity.Property(e => e.Taddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TAddress");

                entity.Property(e => e.TemailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TEmailAddress");

                entity.Property(e => e.Tlocation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tstandard)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TStandard");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
