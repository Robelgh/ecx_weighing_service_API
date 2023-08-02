using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.common;
using Domain;

namespace Persistence
{
    public class ECXDBContext : DbContext
    {
        public ECXDBContext(DbContextOptions<ECXDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECXDBContext).Assembly);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entity in ChangeTracker.Entries<baseModel>())
            {
                entity.Entity.UpdatedDate = DateTime.Now;
                if (entity.State == EntityState.Added)
                {
                    entity.Entity.CreatedDate = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public DbSet<AgriculturalModel> agricultural { get; set; }
        public DbSet<NonAgriculturalModel>nonagricultural { get; set; }
        public DbSet<TruckModel> truck { get; set; }


    }
}
