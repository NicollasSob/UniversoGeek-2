using Microsoft.EntityFrameworkCore;
using UniversoGeek.Infra.Data.Mapping;

namespace UniversoGeek.Infra.Data.Context
{
    public class UniversoGeekDbContext : DbContext
    {
        public UniversoGeekDbContext(DbContextOptions<UniversoGeekDbContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new OrderItemMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new VoucherMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
