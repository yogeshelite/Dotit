using System;
using DotIt.AutoPicker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotIt.Persistance.Data
    {
    public partial class DotItPickerContext : DbContext
    {
        public DotItPickerContext()
        {
        }

        public DotItPickerContext(DbContextOptions<DotItPickerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Warehouseemployee> Warehouseemployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=192.168.1.150;Initial Catalog=DotItPicker;Persist Security Info=True;User ID=sa;Password=@password1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Warehouseemployee>(entity =>
            {
                entity.HasKey(e => e.Empid);

                entity.ToTable("WAREHOUSEEMPLOYEE");

                entity.Property(e => e.Empid).HasColumnName("EMPID");

                entity.Property(e => e.Adminlineperhour).HasColumnName("ADMINLINEPERHOUR");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Maxlines).HasColumnName("MAXLINES");

                entity.Property(e => e.Maxweight).HasColumnName("MAXWEIGHT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Pickdotit).HasColumnName("PICKDOTIT");

                entity.Property(e => e.Pickncco).HasColumnName("PICKNCCO");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasColumnName("ROLE")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });
        }
    }
}
