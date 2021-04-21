using fluent_api.Core.Entities.Concrete;
using fluent_api.Core.EntityTypeConfigurations.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() => Database.Connection.ConnectionString = @"Server= ;Database=FluentApiECommerceDb;Integrated Security=True;";

        public DbSet <Category> Categories { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <Order> Orders { get; set; }
        public DbSet <OrderDetail> OrderDetails { get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet <Shipper> Shippers { get; set; }
        public DbSet <Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new SupplierMap());

            base.OnModelCreating(modelBuilder);
            base.SaveChanges();
        }
    }
}
