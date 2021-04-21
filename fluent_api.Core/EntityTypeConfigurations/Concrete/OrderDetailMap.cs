using fluent_api.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.EntityTypeConfigurations.Concrete
{
    public class OrderDetailMap : EntityMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("dbo.OrderDetails");

            Property(x => x.UnitPrice).IsOptional();
            Property(x => x.Quantity).IsOptional();
            Property(x => x.Discount).IsOptional();

            HasRequired(x => x.Product)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId)
                .WillCascadeOnDelete(false);
        }
    }
}
