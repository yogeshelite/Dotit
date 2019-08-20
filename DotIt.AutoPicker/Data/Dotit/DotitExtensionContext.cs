using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotIt.AutoPicker.Data.DotIt
{
    public partial class DotitExtensionContext : DbContext
    {
        public DotitExtensionContext()
        {
        }

        public DotitExtensionContext(DbContextOptions<DotitExtensionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accountuser> Accountuser { get; set; }
        public virtual DbSet<Appconfig> Appconfig { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Dotitnccopartxfef> Dotitnccopartxfef { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Itemcategory> Itemcategory { get; set; }
        public virtual DbSet<Itemlocation> Itemlocation { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Jobmessage> Jobmessage { get; set; }
        public virtual DbSet<Jobordbox> Jobordbox { get; set; }
        public virtual DbSet<Joborderrelease> Joborderrelease { get; set; }
        public virtual DbSet<Jobordertype> Jobordertype { get; set; }
        public virtual DbSet<Jobordline> Jobordline { get; set; }
        public virtual DbSet<Keypair> Keypair { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<Partxref> Partxref { get; set; }
        public virtual DbSet<Pickerorder> Pickerorder { get; set; }
        public virtual DbSet<Pickorderdetail> Pickorderdetail { get; set; }
        public virtual DbSet<Price> Price { get; set; }
        public virtual DbSet<Pricecategory> Pricecategory { get; set; }
        public virtual DbSet<Punchhswag> Punchhswag { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Swagsweep> Swagsweep { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Usersession> Usersession { get; set; }
        public virtual DbSet<Warehouseemployee> Warehouseemployee { get; set; }
        public virtual DbSet<Websales> Websales { get; set; }
        public virtual DbSet<YextDetail> YextDetail { get; set; }
        public virtual DbSet<YextHeader> YextHeader { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DotItSql;Initial Catalog=DotitExtension;Persist Security Info=False;User ID=DotItReader;Password=mFaS2Nbk-2ZA");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Accountuser>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__ACCOUNTU__7B9E7F357030538E");

                entity.ToTable("ACCOUNTUSER");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.E10password)
                    .HasColumnName("E10PASSWORD")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.E10userid)
                    .HasColumnName("E10USERID")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Partnerid).HasColumnName("PARTNERID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Appconfig>(entity =>
            {
                entity.HasKey(e => e.Configid)
                    .HasName("PK__APPCONFI__C1DFC8E440AF4F30");

                entity.ToTable("APPCONFIG");

                entity.Property(e => e.Configid).HasColumnName("CONFIGID");

                entity.Property(e => e.Appid).HasColumnName("APPID");

                entity.Property(e => e.Configcode)
                    .IsRequired()
                    .HasColumnName("CONFIGCODE")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Configdesc)
                    .IsRequired()
                    .HasColumnName("CONFIGDESC")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Configtestvalue)
                    .IsRequired()
                    .HasColumnName("CONFIGTESTVALUE")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Configtype)
                    .IsRequired()
                    .HasColumnName("CONFIGTYPE")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Configvalue)
                    .IsRequired()
                    .HasColumnName("CONFIGVALUE")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Exposeconfig).HasColumnName("EXPOSECONFIG");

                entity.Property(e => e.Isencrypted).HasColumnName("ISENCRYPTED");

                entity.HasOne(d => d.App)
                    .WithMany(p => p.Appconfig)
                    .HasForeignKey(d => d.Appid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AppConfig");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("APPLICATION");

                entity.Property(e => e.Applicationid).HasColumnName("APPLICATIONID");

                entity.Property(e => e.Currentversion)
                    .IsRequired()
                    .HasColumnName("CURRENTVERSION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Enddate)
                    .HasColumnName("ENDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isinticket).HasColumnName("ISINTICKET");

                entity.Property(e => e.Serverid).HasColumnName("SERVERID");

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.Serverid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ServerApplication");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Categorydescription)
                    .IsRequired()
                    .HasColumnName("CATEGORYDESCRIPTION")
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.Property(e => e.Categorytitle)
                    .IsRequired()
                    .HasColumnName("CATEGORYTITLE")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dotitnccopartxfef>(entity =>
            {
                entity.HasKey(e => e.Xfefid)
                    .HasName("PK__DOTITNCC__E8EEDE80BB2DC24F");

                entity.ToTable("DOTITNCCOPARTXFEF");

                entity.Property(e => e.Xfefid).HasColumnName("XFEFID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Dotitpartnumber)
                    .IsRequired()
                    .HasColumnName("DOTITPARTNUMBER")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Nccopartnumber)
                    .IsRequired()
                    .HasColumnName("NCCOPARTNUMBER")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Sellprice)
                    .HasColumnName("SELLPRICE")
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("ITEM");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Itemdescription)
                    .IsRequired()
                    .HasColumnName("ITEMDESCRIPTION")
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.Property(e => e.Itemtitle)
                    .IsRequired()
                    .HasColumnName("ITEMTITLE")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Itemcategory>(entity =>
            {
                entity.HasKey(e => e.Itemcatid)
                    .HasName("PK__ITEMCATE__150B3C996FA87FF2");

                entity.ToTable("ITEMCATEGORY");

                entity.Property(e => e.Itemcatid).HasColumnName("ITEMCATID");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Itemcategory)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATITEMCAT");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Itemcategory)
                    .HasForeignKey(d => d.Itemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITEMITEMCAT");
            });

            modelBuilder.Entity<Itemlocation>(entity =>
            {
                entity.HasKey(e => e.Itemlocid)
                    .HasName("PK__ITEMLOCA__450557774BEDA873");

                entity.ToTable("ITEMLOCATION");

                entity.Property(e => e.Itemlocid).HasColumnName("ITEMLOCID");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Itemlocation)
                    .HasForeignKey(d => d.Itemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITEMITEMLOC");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Itemlocation)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCITEMLOC");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("JOB");

                entity.Property(e => e.Jobid).HasColumnName("JOBID");

                entity.Property(e => e.Custid)
                    .IsRequired()
                    .HasColumnName("CUSTID")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Custname)
                    .IsRequired()
                    .HasColumnName("CUSTNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Custnum).HasColumnName("CUSTNUM");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isautopackout).HasColumnName("ISAUTOPACKOUT");

                entity.Property(e => e.Iscalcboxes).HasColumnName("ISCALCBOXES");

                entity.Property(e => e.Ischargekitting).HasColumnName("ISCHARGEKITTING");

                entity.Property(e => e.Ischargeshipping).HasColumnName("ISCHARGESHIPPING");

                entity.Property(e => e.Isgenpacklistlabels).HasColumnName("ISGENPACKLISTLABELS");

                entity.Property(e => e.Isgenshippinglabels).HasColumnName("ISGENSHIPPINGLABELS");

                entity.Property(e => e.Isholdorder).HasColumnName("ISHOLDORDER");

                entity.Property(e => e.Iskitcommish).HasColumnName("ISKITCOMMISH");

                entity.Property(e => e.Isonebillingcustomer).HasColumnName("ISONEBILLINGCUSTOMER");

                entity.Property(e => e.Isshipordercomplete).HasColumnName("ISSHIPORDERCOMPLETE");

                entity.Property(e => e.Jobcreationdate)
                    .HasColumnName("JOBCREATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Jobcreator)
                    .IsRequired()
                    .HasColumnName("JOBCREATOR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Jobmodifieddate)
                    .HasColumnName("JOBMODIFIEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Jobmodifier)
                    .IsRequired()
                    .HasColumnName("JOBMODIFIER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Jobname)
                    .IsRequired()
                    .HasColumnName("JOBNAME")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Kitdollars)
                    .HasColumnName("KITDOLLARS")
                    .HasColumnType("money");

                entity.Property(e => e.Kittingfee)
                    .HasColumnName("KITTINGFEE")
                    .HasColumnType("money");

                entity.Property(e => e.Orders).HasColumnName("ORDERS");

                entity.Property(e => e.Ordersize)
                    .HasColumnName("ORDERSIZE")
                    .HasColumnType("money");

                entity.Property(e => e.Ordertype).HasColumnName("ORDERTYPE");

                entity.Property(e => e.Ourrate)
                    .HasColumnName("OURRATE")
                    .HasColumnType("money");

                entity.Property(e => e.Shipbydate)
                    .HasColumnName("SHIPBYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Shipdollars)
                    .HasColumnName("SHIPDOLLARS")
                    .HasColumnType("money");

                entity.Property(e => e.Shipvia)
                    .IsRequired()
                    .HasColumnName("SHIPVIA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Subfolder)
                    .IsRequired()
                    .HasColumnName("SUBFOLDER")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrdertypeNavigation)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.Ordertype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ot_j");
            });

            modelBuilder.Entity<Jobmessage>(entity =>
            {
                entity.ToTable("JOBMESSAGE");

                entity.Property(e => e.Jobmessageid).HasColumnName("JOBMESSAGEID");

                entity.Property(e => e.Jobboxid).HasColumnName("JOBBOXID");

                entity.Property(e => e.Jobid).HasColumnName("JOBID");

                entity.Property(e => e.Joblineid).HasColumnName("JOBLINEID");

                entity.Property(e => e.Joborid).HasColumnName("JOBORID");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("MESSAGE")
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.Property(e => e.Messagecode).HasColumnName("MESSAGECODE");

                entity.Property(e => e.Messagetype).HasColumnName("MESSAGETYPE");

                entity.HasOne(d => d.Jobbox)
                    .WithMany(p => p.Jobmessage)
                    .HasForeignKey(d => d.Jobboxid)
                    .HasConstraintName("fk_jb_jm");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Jobmessage)
                    .HasForeignKey(d => d.Jobid)
                    .HasConstraintName("fk_j_jm");

                entity.HasOne(d => d.Jobline)
                    .WithMany(p => p.Jobmessage)
                    .HasForeignKey(d => d.Joblineid)
                    .HasConstraintName("fk_jl_jm");

                entity.HasOne(d => d.Jobor)
                    .WithMany(p => p.Jobmessage)
                    .HasForeignKey(d => d.Joborid)
                    .HasConstraintName("fk_jo_jm");
            });

            modelBuilder.Entity<Jobordbox>(entity =>
            {
                entity.HasKey(e => e.Jobboxid)
                    .HasName("PK__JOBORDBO__CFABE8979064FEE6");

                entity.ToTable("JOBORDBOX");

                entity.Property(e => e.Jobboxid).HasColumnName("JOBBOXID");

                entity.Property(e => e.Boxcubicin)
                    .HasColumnName("BOXCUBICIN")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Boxheight).HasColumnName("BOXHEIGHT");

                entity.Property(e => e.Boxlength).HasColumnName("BOXLENGTH");

                entity.Property(e => e.Boxweight)
                    .HasColumnName("BOXWEIGHT")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Boxwidth).HasColumnName("BOXWIDTH");

                entity.Property(e => e.E10boxnumber).HasColumnName("E10BOXNUMBER");

                entity.Property(e => e.Joborid).HasColumnName("JOBORID");

                entity.Property(e => e.Packnumber)
                    .IsRequired()
                    .HasColumnName("PACKNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shippingstatus)
                    .IsRequired()
                    .HasColumnName("SHIPPINGSTATUS")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Trackingnumber)
                    .IsRequired()
                    .HasColumnName("TRACKINGNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Jobor)
                    .WithMany(p => p.Jobordbox)
                    .HasForeignKey(d => d.Joborid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_jo_rb");
            });

            modelBuilder.Entity<Joborderrelease>(entity =>
            {
                entity.HasKey(e => e.Joborid)
                    .HasName("PK__JOBORDER__90C7B6F7867E59B2");

                entity.ToTable("JOBORDERRELEASE");

                entity.Property(e => e.Joborid).HasColumnName("JOBORID");

                entity.Property(e => e.Customerid)
                    .IsRequired()
                    .HasColumnName("CUSTOMERID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Customernumber).HasColumnName("CUSTOMERNUMBER");

                entity.Property(e => e.E10ordernum).HasColumnName("E10ORDERNUM");

                entity.Property(e => e.E10release).HasColumnName("E10RELEASE");

                entity.Property(e => e.Invoices)
                    .IsRequired()
                    .HasColumnName("INVOICES")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Isaddressverified).HasColumnName("ISADDRESSVERIFIED");

                entity.Property(e => e.Iscalculateboxes).HasColumnName("ISCALCULATEBOXES");

                entity.Property(e => e.Ischargekitting).HasColumnName("ISCHARGEKITTING");

                entity.Property(e => e.Ischargeshipping).HasColumnName("ISCHARGESHIPPING");

                entity.Property(e => e.Isorderheld).HasColumnName("ISORDERHELD");

                entity.Property(e => e.Isots).HasColumnName("ISOTS");

                entity.Property(e => e.Jobid).HasColumnName("JOBID");

                entity.Property(e => e.Jobponumber)
                    .IsRequired()
                    .HasColumnName("JOBPONUMBER")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Kittingfee)
                    .HasColumnName("KITTINGFEE")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Needbydate)
                    .HasColumnName("NEEDBYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ordercreated)
                    .HasColumnName("ORDERCREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ordermodified)
                    .HasColumnName("ORDERMODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ordermodifiedby)
                    .IsRequired()
                    .HasColumnName("ORDERMODIFIEDBY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ordersize)
                    .HasColumnName("ORDERSIZE")
                    .HasColumnType("money");

                entity.Property(e => e.Ourrate)
                    .HasColumnName("OURRATE")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Packnumbers)
                    .IsRequired()
                    .HasColumnName("PACKNUMBERS")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Ponumber)
                    .IsRequired()
                    .HasColumnName("PONUMBER")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Publicrate)
                    .HasColumnName("PUBLICRATE")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Shipbydate)
                    .HasColumnName("SHIPBYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Shipdollars)
                    .HasColumnName("SHIPDOLLARS")
                    .HasColumnType("money");

                entity.Property(e => e.Shipmethod)
                    .IsRequired()
                    .HasColumnName("SHIPMETHOD")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Shiptonumber)
                    .IsRequired()
                    .HasColumnName("SHIPTONUMBER")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Staddrline1)
                    .IsRequired()
                    .HasColumnName("STADDRLINE1")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Staddrline2)
                    .IsRequired()
                    .HasColumnName("STADDRLINE2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Staddrline3)
                    .IsRequired()
                    .HasColumnName("STADDRLINE3")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Stcity)
                    .IsRequired()
                    .HasColumnName("STCITY")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Stcompany)
                    .IsRequired()
                    .HasColumnName("STCOMPANY")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Stcontact)
                    .IsRequired()
                    .HasColumnName("STCONTACT")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Stcontactemail)
                    .IsRequired()
                    .HasColumnName("STCONTACTEMAIL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Stcontactphone)
                    .IsRequired()
                    .HasColumnName("STCONTACTPHONE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Stcountry)
                    .IsRequired()
                    .HasColumnName("STCOUNTRY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Stpostal)
                    .IsRequired()
                    .HasColumnName("STPOSTAL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Ststate)
                    .IsRequired()
                    .HasColumnName("STSTATE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Trackingnumbers)
                    .IsRequired()
                    .HasColumnName("TRACKINGNUMBERS")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Joborderrelease)
                    .HasForeignKey(d => d.Jobid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_j_jo");
            });

            modelBuilder.Entity<Jobordertype>(entity =>
            {
                entity.HasKey(e => e.Ordertypeid)
                    .HasName("PK__JOBORDER__B6E8989E27F03BDE");

                entity.ToTable("JOBORDERTYPE");

                entity.Property(e => e.Ordertypeid).HasColumnName("ORDERTYPEID");

                entity.Property(e => e.Ordertype)
                    .IsRequired()
                    .HasColumnName("ORDERTYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Jobordline>(entity =>
            {
                entity.HasKey(e => e.Joblineid)
                    .HasName("PK__JOBORDLI__7299ECAB7F0E2152");

                entity.ToTable("JOBORDLINE");

                entity.Property(e => e.Joblineid).HasColumnName("JOBLINEID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("COMMENT")
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.E10linenum).HasColumnName("E10LINENUM");

                entity.Property(e => e.Ispartvalid).HasColumnName("ISPARTVALID");

                entity.Property(e => e.Isqtyonhand).HasColumnName("ISQTYONHAND");

                entity.Property(e => e.Jobboxid).HasColumnName("JOBBOXID");

                entity.Property(e => e.Joborid).HasColumnName("JOBORID");

                entity.Property(e => e.Linecreated)
                    .HasColumnName("LINECREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Linemodified)
                    .HasColumnName("LINEMODIFIED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Linemodifiedby)
                    .IsRequired()
                    .HasColumnName("LINEMODIFIEDBY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Orderqty).HasColumnName("ORDERQTY");

                entity.Property(e => e.Partnum)
                    .IsRequired()
                    .HasColumnName("PARTNUM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.Jobbox)
                    .WithMany(p => p.Jobordline)
                    .HasForeignKey(d => d.Jobboxid)
                    .HasConstraintName("fk_rb_rl");

                entity.HasOne(d => d.Jobor)
                    .WithMany(p => p.Jobordline)
                    .HasForeignKey(d => d.Joborid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_jo_rl");
            });

            modelBuilder.Entity<Keypair>(entity =>
            {
                entity.HasKey(e => e.Keyid)
                    .HasName("PK__KEYPAIR__28BF303AA00D85C5");

                entity.ToTable("KEYPAIR");

                entity.Property(e => e.Keyid)
                    .HasColumnName("KEYID")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Valueid)
                    .IsRequired()
                    .HasColumnName("VALUEID")
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("LOCATION");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Locationdescription)
                    .IsRequired()
                    .HasColumnName("LOCATIONDESCRIPTION")
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.Property(e => e.Locationtitle)
                    .IsRequired()
                    .HasColumnName("LOCATIONTITLE")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("PARTNER");

                entity.Property(e => e.Partnerid).HasColumnName("PARTNERID");

                entity.Property(e => e.Partnername)
                    .IsRequired()
                    .HasColumnName("PARTNERNAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Partxref>(entity =>
            {
                entity.HasKey(e => e.Pxrefid)
                    .HasName("PK__PARTXREF__481D8BF2A0BD1E50");

                entity.ToTable("PARTXREF");

                entity.Property(e => e.Pxrefid).HasColumnName("PXREFID");

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnName("FOLDER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Outsidepartnum)
                    .IsRequired()
                    .HasColumnName("OUTSIDEPARTNUM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Partnum)
                    .IsRequired()
                    .HasColumnName("PARTNUM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Shipvia)
                    .IsRequired()
                    .HasColumnName("SHIPVIA")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

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
                    .IsRequired()
                    .HasColumnName("DCDUSERID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("ORDERDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pickstatus)
                    .IsRequired()
                    .HasColumnName("PICKSTATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReasionPickFail)
                    .IsRequired()   
                    .HasColumnName("REASIONPICKFAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                

                entity.Property(e => e.Recorddate)
                    .HasColumnName("RECORDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordupdatedon)
                    .HasColumnName("RECORDUPDATEDON")
                    .HasColumnType("datetime");

                entity.Property(e => e.PickDate)
                   .HasColumnName("PICKDATE")
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
                    .HasMaxLength(50);

                entity.Property(e => e.Binnum)
                    .HasColumnName("BINNUM")
                    .HasMaxLength(10);

                entity.Property(e => e.Damageqty).HasColumnName("DAMAGEQTY");

                entity.Property(e => e.Pickstatus).HasColumnName("PICKSTATUS");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("PRICE");

                entity.Property(e => e.Priceid).HasColumnName("PRICEID");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Price1)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(12, 3)");

                entity.Property(e => e.Pricecatid).HasColumnName("PRICECATID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Price)
                    .HasForeignKey(d => d.Itemid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITEMPRICE");

                entity.HasOne(d => d.Pricecat)
                    .WithMany(p => p.Price)
                    .HasForeignKey(d => d.Pricecatid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRICECATPRICE");
            });

            modelBuilder.Entity<Pricecategory>(entity =>
            {
                entity.HasKey(e => e.Pricecatid)
                    .HasName("PK__PRICECAT__05376E6202573093");

                entity.ToTable("PRICECATEGORY");

                entity.Property(e => e.Pricecatid).HasColumnName("PRICECATID");

                entity.Property(e => e.Pricecatdescription)
                    .IsRequired()
                    .HasColumnName("PRICECATDESCRIPTION")
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.Property(e => e.Pricecattitle)
                    .IsRequired()
                    .HasColumnName("PRICECATTITLE")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Punchhswag>(entity =>
            {
                entity.ToTable("PUNCHHSWAG");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Deladdr)
                    .IsRequired()
                    .HasColumnName("DELADDR")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Delattn)
                    .IsRequired()
                    .HasColumnName("DELATTN")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Delcity)
                    .IsRequired()
                    .HasColumnName("DELCITY")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Delcountry)
                    .IsRequired()
                    .HasColumnName("DELCOUNTRY")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Delemail)
                    .IsRequired()
                    .HasColumnName("DELEMAIL")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Delname)
                    .IsRequired()
                    .HasColumnName("DELNAME")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Deloriginaladdr)
                    .IsRequired()
                    .HasColumnName("DELORIGINALADDR")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Delphone)
                    .IsRequired()
                    .HasColumnName("DELPHONE")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Delpostal)
                    .IsRequired()
                    .HasColumnName("DELPOSTAL")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Delstate)
                    .IsRequired()
                    .HasColumnName("DELSTATE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Delvalidated).HasColumnName("DELVALIDATED");

                entity.Property(e => e.Dotitpart)
                    .IsRequired()
                    .HasColumnName("DOTITPART")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.E10ordernumber).HasColumnName("E10ORDERNUMBER");

                entity.Property(e => e.Endiciatransid).HasColumnName("ENDICIATRANSID");

                entity.Property(e => e.Fbloc)
                    .IsRequired()
                    .HasColumnName("FBLOC")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fblocname)
                    .IsRequired()
                    .HasColumnName("FBLOCNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fbpointsredeemed).HasColumnName("FBPOINTSREDEEMED");

                entity.Property(e => e.Fbpointsreq).HasColumnName("FBPOINTSREQ");

                entity.Property(e => e.Fbredeemdate)
                    .IsRequired()
                    .HasColumnName("FBREDEEMDATE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Fbredeempartid)
                    .IsRequired()
                    .HasColumnName("FBREDEEMPARTID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fbredeemsize)
                    .IsRequired()
                    .HasColumnName("FBREDEEMSIZE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Fbredemptioncode)
                    .IsRequired()
                    .HasColumnName("FBREDEMPTIONCODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fbstorenum)
                    .IsRequired()
                    .HasColumnName("FBSTORENUM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Isresidential).HasColumnName("ISRESIDENTIAL");

                entity.Property(e => e.Istest).HasColumnName("ISTEST");

                entity.Property(e => e.Orderstatus)
                    .IsRequired()
                    .HasColumnName("ORDERSTATUS")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Origip)
                    .IsRequired()
                    .HasColumnName("ORIGIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ourrate)
                    .HasColumnName("OURRATE")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Packnum).HasColumnName("PACKNUM");

                entity.Property(e => e.Publicrate)
                    .HasColumnName("PUBLICRATE")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Shipdate)
                    .IsRequired()
                    .HasColumnName("SHIPDATE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Shipvia)
                    .IsRequired()
                    .HasColumnName("SHIPVIA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sweepid).HasColumnName("SWEEPID");

                entity.Property(e => e.Trackingnumber)
                    .IsRequired()
                    .HasColumnName("TRACKINGNUMBER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Tranreceivedate)
                    .IsRequired()
                    .HasColumnName("TRANRECEIVEDATE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("USERID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(7, 2)");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("SERVER");

                entity.Property(e => e.Serverid).HasColumnName("SERVERID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Swagsweep>(entity =>
            {
                entity.HasKey(e => e.Ssid)
                    .HasName("PK__SWAGSWEE__A0D712A31191AFA3");

                entity.ToTable("SWAGSWEEP");

                entity.Property(e => e.Ssid).HasColumnName("SSID");

                entity.Property(e => e.Sscomplete).HasColumnName("SSCOMPLETE");

                entity.Property(e => e.Ssdate)
                    .IsRequired()
                    .HasColumnName("SSDATE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sspart)
                    .IsRequired()
                    .HasColumnName("SSPART")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sspath)
                    .IsRequired()
                    .HasColumnName("SSPATH")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Ssqty).HasColumnName("SSQTY");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("TICKET");

                entity.Property(e => e.Ticketid).HasColumnName("TICKETID");

                entity.Property(e => e.Applicationid).HasColumnName("APPLICATIONID");

                entity.Property(e => e.Assigneduser).HasColumnName("ASSIGNEDUSER");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnName("DETAILS")
                    .IsUnicode(false);

                entity.Property(e => e.Reportinguser).HasColumnName("REPORTINGUSER");

                entity.Property(e => e.Resolution)
                    .IsRequired()
                    .HasColumnName("RESOLUTION")
                    .IsUnicode(false);

                entity.Property(e => e.Resolutiondate)
                    .HasColumnName("RESOLUTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Serverid).HasColumnName("SERVERID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasColumnName("SUMMARY")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.Applicationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ApplicationTicket");

                entity.HasOne(d => d.AssigneduserNavigation)
                    .WithMany(p => p.TicketAssigneduserNavigation)
                    .HasForeignKey(d => d.Assigneduser)
                    .HasConstraintName("fk_AsgUserTicket");

                entity.HasOne(d => d.ReportinguserNavigation)
                    .WithMany(p => p.TicketReportinguserNavigation)
                    .HasForeignKey(d => d.Reportinguser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_RepUserTicket");

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.Serverid)
                    .HasConstraintName("fk_ServerTicket");
            });

            modelBuilder.Entity<Usersession>(entity =>
            {
                entity.HasKey(e => e.Sessionguid)
                    .HasName("PK__USERSESS__9CBE26B6E5EC5B34");

                entity.ToTable("USERSESSION");

                entity.Property(e => e.Sessionguid)
                    .HasColumnName("SESSIONGUID")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Callingipaddr)
                    .HasColumnName("CALLINGIPADDR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expired).HasColumnName("EXPIRED");

                entity.Property(e => e.Islongtermtoken).HasColumnName("ISLONGTERMTOKEN");

                entity.Property(e => e.Partnerid).HasColumnName("PARTNERID");

                entity.Property(e => e.Sessiondate)
                    .HasColumnName("SESSIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sessionexpiredate)
                    .HasColumnName("SESSIONEXPIREDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sessionvalidduration).HasColumnName("SESSIONVALIDDURATION");

                entity.Property(e => e.Testing).HasColumnName("TESTING");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Usersession)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_userusersession");
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

                entity.Property(e => e.active).HasColumnName("ACTIVE");

                entity.Property(e => e.Adminlineperhour).HasColumnName("ADMINLINEPERHOUR");

                entity.Property(e => e.Company)
                    .HasColumnName("COMPANY")
                    .HasMaxLength(8);

                entity.Property(e => e.Emailaddress)
                    .HasColumnName("EMAILADDRESS")
                    .HasMaxLength(50);

                //entity.Property(e => e.Empid).HasColumnName("EMPID");

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

                entity.Property(e => e.Recorddate)
                    .HasColumnName("RECORDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordupdatedate)
                    .HasColumnName("RECORDUPDATEDATE")
                    .HasColumnType("datetime");
                entity.Property(e => e.UserHeight)
                   .HasColumnName("USERHEIGHT")
                   .HasColumnType("varchar").HasMaxLength(10);
                entity.Property(e => e.WeightCapacity)
                   .HasColumnName("WEIGHTCAPACITY")
                   .HasColumnType("int");
            });

            modelBuilder.Entity<Websales>(entity =>
            {
                entity.HasKey(e => e.Wsid)
                    .HasName("PK__WEBSALES__8265E4BAA10AA556");

                entity.ToTable("WEBSALES");

                entity.Property(e => e.Wsid).HasColumnName("WSID");

                entity.Property(e => e.Custgroup)
                    .HasColumnName("CUSTGROUP")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Custname)
                    .HasColumnName("CUSTName")
                    .HasMaxLength(124)
                    .IsUnicode(false);

                entity.Property(e => e.Saledate)
                    .HasColumnName("SALEDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Sales).HasColumnName("SALES");

                entity.Property(e => e.Transactions).HasColumnName("TRANSACTIONS");
            });

            modelBuilder.Entity<YextDetail>(entity =>
            {
                entity.HasKey(e => e.Epicorordernum)
                    .HasName("PK__YEXT_DET__FBB2916D42F9D0CB");

                entity.ToTable("YEXT_DETAIL");

                entity.Property(e => e.Epicorordernum)
                    .HasColumnName("EPICORORDERNUM")
                    .ValueGeneratedNever();

                entity.Property(e => e.Entryperson)
                    .HasColumnName("ENTRYPERSON")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Isonline).HasColumnName("ISONLINE");

                entity.Property(e => e.Orderdate)
                    .HasColumnName("ORDERDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orderqty).HasColumnName("ORDERQTY");

                entity.Property(e => e.Partnum)
                    .IsRequired()
                    .HasColumnName("PARTNUM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Yextid).HasColumnName("YEXTID");

                entity.HasOne(d => d.Yext)
                    .WithMany(p => p.YextDetail)
                    .HasForeignKey(d => d.Yextid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeaderDetail");
            });

            modelBuilder.Entity<YextHeader>(entity =>
            {
                entity.HasKey(e => e.Yextid)
                    .HasName("PK__YEXT_HEA__AB96CCC56AD31A0F");

                entity.ToTable("YEXT_HEADER");

                entity.Property(e => e.Yextid).HasColumnName("YEXTID");

                entity.Property(e => e.Createdate)
                    .HasColumnName("CREATEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby)
                    .HasColumnName("CREATEDBY")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Epicorcustnum).HasColumnName("EPICORCUSTNUM");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isautorenew).HasColumnName("ISAUTORENEW");

                entity.Property(e => e.Magentocustnum).HasColumnName("MAGENTOCUSTNUM");

                entity.Property(e => e.Magentoemail)
                    .HasColumnName("MAGENTOEMAIL")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Modifiedby)
                    .HasColumnName("MODIFIEDBY")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Modifieddate)
                    .HasColumnName("MODIFIEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nextfee)
                    .HasColumnName("NEXTFEE")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Renewaldate)
                    .HasColumnName("RENEWALDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Yextcustnum)
                    .IsRequired()
                    .HasColumnName("YEXTCUSTNUM")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Yextssotoken)
                    .IsRequired()
                    .HasColumnName("YEXTSSOTOKEN")
                    .HasMaxLength(36)
                    .IsUnicode(false);
            });
        }
    }
}
