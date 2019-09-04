using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dotit.AutoPickerApi.Persistance.Data.Doitit
{
    public partial class DotItExtensionContext : DbContext
    {
        public DotItExtensionContext()
        {
        }

        public DotItExtensionContext(DbContextOptions<DotItExtensionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pickerorder> Pickerorder { get; set; }
        public virtual DbSet<Pickorderdetail> Pickorderdetail { get; set; }
        public virtual DbSet<Warehouseemployee> Warehouseemployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DotItSql;Initial Catalog=DotItExtension;Persist Security Info=False;User ID=DotItReader;Password=mFaS2Nbk-2ZA");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Pickerorder>(entity =>
            {
                entity.HasKey(e => new { e.Ordernum, e.Company });

                entity.ToTable("PICKERORDER");

                entity.Property(e => e.Ordernum).HasColumnName("ORDERNUM");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Dcduserid)
                    .HasColumnName("DCDUSERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("ORDERDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pickdate)
                    .HasColumnName("PICKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pickstatus)
                    .HasColumnName("PICKSTATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reasionpickfail)
                    .HasColumnName("REASIONPICKFAIL")
                    .HasMaxLength(4000);

                entity.Property(e => e.Recorddate)
                    .HasColumnName("RECORDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordupdatedon)
                    .HasColumnName("RECORDUPDATEDON")
                    .HasColumnType("datetime");

                entity.Property(e => e.Totalitems).HasColumnName("TOTALITEMS");

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<Pickorderdetail>(entity =>
            {
                entity.HasKey(e => new { e.Orderno, e.Company, e.Partnum });

                entity.ToTable("PICKORDERDETAIL");

                entity.Property(e => e.Orderno).HasColumnName("ORDERNO");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Partnum)
                    .HasColumnName("PARTNUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Binnum)
                    .HasColumnName("BINNUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Damageqty).HasColumnName("DAMAGEQTY");

                entity.Property(e => e.Ium)
                    .HasColumnName("IUM")
                    .HasMaxLength(6);

                entity.Property(e => e.Linedesc).HasColumnName("LINEDESC");

                entity.Property(e => e.Orderline).HasColumnName("ORDERLINE");

                entity.Property(e => e.Orderqty)
                    .HasColumnName("ORDERQTY")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Pickstatus).HasColumnName("PICKSTATUS");

                entity.Property(e => e.Totalprice)
                    .HasColumnName("TOTALPRICE")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Unitprice)
                    .HasColumnName("UNITPRICE")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Warehouseemployee>(entity =>
            {
                entity.HasKey(e => e.Dcduserid);

                entity.ToTable("WAREHOUSEEMPLOYEE");

                entity.Property(e => e.Dcduserid)
                    .HasColumnName("DCDUSERID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Adminlineperhour).HasColumnName("ADMINLINEPERHOUR");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(8);

                entity.Property(e => e.Emailaddress)
                    .HasColumnName("EMAILADDRESS")
                    .HasMaxLength(50);

                entity.Property(e => e.Empid).HasColumnName("EMPID");

                entity.Property(e => e.Grouplist)
                    .IsRequired()
                    .HasColumnName("GROUPLIST");

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("LASTLOGIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Maxlines).HasColumnName("MAXLINES");

                entity.Property(e => e.Maxweight).HasColumnName("MAXWEIGHT");

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pickername)
                    .IsRequired()
                    .HasColumnName("PICKERNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Pickforcompany)
                    .HasColumnName("PICKFORCOMPANY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recorddate)
                    .HasColumnName("RECORDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordupdatedate)
                    .HasColumnName("RECORDUPDATEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userheight)
                    .HasColumnName("USERHEIGHT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weightcapacity).HasColumnName("WEIGHTCAPACITY");
            });
        }
    }
}
