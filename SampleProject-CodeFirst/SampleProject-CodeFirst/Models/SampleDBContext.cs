using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SampleProject_CodeFirst.Models
{
    public partial class SampleDBContext : DbContext
    {
        public SampleDBContext()
        {
        }

        public SampleDBContext(DbContextOptions<SampleDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sample> Sample { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sample>(entity =>
            {
                entity.ToTable("sample");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
