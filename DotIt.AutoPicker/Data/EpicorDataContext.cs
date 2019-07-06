using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Data
{
    public class EpicorDataContext : DbContext
    {
        public EpicorDataContext( DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DotitSQL;Initial Catalog=Epicor10;Persist Security Info=True;User ID=DotitReader;Password=mFaS2Nbk-2ZA");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            //modelBuilder.Entity<Part>(entity =>
            //{
            //    entity.HasKey(e => e.Empid);

            //    entity.ToTable("WAREHOUSEEMPLOYEE");

            //    entity.Property(e => e.Empid).HasColumnName("EMPID");

            //    entity.Property(e => e.Adminlineperhour).HasColumnName("ADMINLINEPERHOUR");

            //    entity.Property(e => e.Email)
            //        .IsRequired()
            //        .HasColumnName("EMAIL")
            //        .HasMaxLength(80)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Maxlines).HasColumnName("MAXLINES");

            //    entity.Property(e => e.Maxweight).HasColumnName("MAXWEIGHT");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasColumnName("NAME")
            //        .HasMaxLength(80)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Pickdotit).HasColumnName("PICKDOTIT");

            //    entity.Property(e => e.Pickncco).HasColumnName("PICKNCCO");

            //    entity.Property(e => e.Role)
            //        .IsRequired()
            //        .HasColumnName("ROLE")
            //        .HasMaxLength(3)
            //        .IsUnicode(false);
            //});
        }
        public override DatabaseFacade Database => base.Database;

        public override ChangeTracker ChangeTracker => base.ChangeTracker;

        public override IModel Model => base.Model;

        public override EntityEntry<TEntity> Add<TEntity>(TEntity entity)
        {
            return base.Add(entity);
        }

        public override EntityEntry Add(object entity)
        {
            return base.Add(entity);
        }

        public override Task<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.AddAsync(entity, cancellationToken);
        }

        public override Task<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.AddAsync(entity, cancellationToken);
        }

        public override void AddRange(params object[] entities)
        {
            base.AddRange(entities);
        }

        public override void AddRange(IEnumerable<object> entities)
        {
            base.AddRange(entities);
        }

        public override Task AddRangeAsync(params object[] entities)
        {
            return base.AddRangeAsync(entities);
        }

        public override Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.AddRangeAsync(entities, cancellationToken);
        }

        public override EntityEntry<TEntity> Attach<TEntity>(TEntity entity)
        {
            return base.Attach(entity);
        }

        public override EntityEntry Attach(object entity)
        {
            return base.Attach(entity);
        }

        public override void AttachRange(params object[] entities)
        {
            base.AttachRange(entities);
        }

        public override void AttachRange(IEnumerable<object> entities)
        {
            base.AttachRange(entities);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public override EntityEntry<TEntity> Entry<TEntity>(TEntity entity)
        {
            return base.Entry(entity);
        }

        public override EntityEntry Entry(object entity)
        {
            return base.Entry(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override object Find(Type entityType,  params object[] keyValues)
        {
            return base.Find(entityType, keyValues);
        }

        public override TEntity Find<TEntity>( params object[] keyValues)
        {
            return base.Find<TEntity>(keyValues);
        }

        public override Task<object> FindAsync(Type entityType,  params object[] keyValues)
        {
            return base.FindAsync(entityType, keyValues);
        }

        public override Task<object> FindAsync(Type entityType,  object[] keyValues, CancellationToken cancellationToken)
        {
            return base.FindAsync(entityType, keyValues, cancellationToken);
        }

        public override Task<TEntity> FindAsync<TEntity>( params object[] keyValues)
        {
            return base.FindAsync<TEntity>(keyValues);
        }

        public override Task<TEntity> FindAsync<TEntity>( object[] keyValues, CancellationToken cancellationToken)
        {
            return base.FindAsync<TEntity>(keyValues, cancellationToken);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override DbQuery<TQuery> Query<TQuery>()
        {
            return base.Query<TQuery>();
        }

        public override EntityEntry<TEntity> Remove<TEntity>(TEntity entity)
        {
            return base.Remove(entity);
        }

        public override EntityEntry Remove(object entity)
        {
            return base.Remove(entity);
        }

        public override void RemoveRange(params object[] entities)
        {
            base.RemoveRange(entities);
        }

        public override void RemoveRange(IEnumerable<object> entities)
        {
            base.RemoveRange(entities);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override DbSet<TEntity> Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override EntityEntry<TEntity> Update<TEntity>(TEntity entity)
        {
            return base.Update(entity);
        }

        public override EntityEntry Update(object entity)
        {
            return base.Update(entity);
        }

        public override void UpdateRange(params object[] entities)
        {
            base.UpdateRange(entities);
        }

        public override void UpdateRange(IEnumerable<object> entities)
        {
            base.UpdateRange(entities);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
