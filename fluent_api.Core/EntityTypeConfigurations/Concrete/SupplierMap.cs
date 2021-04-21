using fluent_api.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.EntityTypeConfigurations.Concrete
{
    public class SupplierMap : EntityMap<Supplier>
    {
        public SupplierMap()
        {
            ToTable("dbo.Suppliers");

            Property(x => x.CompanyName).IsOptional();
            Property(x => x.ContactName).IsOptional();
            Property(x => x.Adress).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.Region).IsOptional();
            Property(x => x.Country).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.Phone).IsOptional();

            HasMany(x => x.Products)
                .WithRequired(x => x.Supplier)
                .HasForeignKey(x => x.SupplierId)
                .WillCascadeOnDelete(false);
        }
    }
}
