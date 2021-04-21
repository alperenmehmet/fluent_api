using fluent_api.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.EntityTypeConfigurations.Concrete
{
    public class ProductMap : EntityMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");

            Property(x => x.Name).IsOptional();
            Property(x => x.Description).IsOptional();
            Property(x => x.UnitPrice).IsOptional();
            Property(x => x.UnitsInStock).IsOptional();

            HasRequired(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId)
                .WillCascadeOnDelete(false);

            HasMany(x => x.OrderDetails)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Supplier)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.SupplierId)
                .WillCascadeOnDelete(false);
        }
    }
}
