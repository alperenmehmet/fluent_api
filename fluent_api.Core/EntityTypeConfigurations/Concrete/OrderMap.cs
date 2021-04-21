using fluent_api.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.EntityTypeConfigurations.Concrete
{
    public class OrderMap : EntityMap<Order>
    {
        public OrderMap()
        {
            ToTable("dbo.Orders");

            Property(x => x.OrderDate).IsOptional();
            Property(x => x.RequiredDate).IsOptional();
            Property(x => x.ShippedDate).IsOptional();
            Property(x => x.ShipVia).IsOptional();
            Property(x => x.Freight).IsOptional();
            Property(x => x.ShipName).IsOptional();
            Property(x => x.ShipAdress).IsOptional();
            Property(x => x.ShipCity).IsOptional();
            Property(x => x.ShipRegion).IsOptional();
            Property(x => x.ShipPostalCode).IsOptional();
            Property(x => x.ShipCountry).IsOptional();

            HasMany(x => x.OrderDetails)
                .WithRequired(x => x.Order)
                .HasForeignKey(x => x.OrderId)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Shipper)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.ShipperId)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(false);

        }
    }
}
