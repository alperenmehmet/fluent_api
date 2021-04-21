using fluent_api.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.EntityTypeConfigurations.Concrete
{
    public class CustomerMap : EntityMap<Customer>
    {
        public CustomerMap()
        {
            ToTable("dbo.Customers");

            Property(x => x.CompanyName).IsOptional();
            Property(x => x.ContactName).IsOptional();
            Property(x => x.ContactTitle).IsOptional();
            Property(x => x.Adress).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.Region).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.Country).IsOptional();
            Property(x => x.Phone).IsOptional();
            Property(x => x.Fax).IsOptional();

            HasMany(x => x.Orders)
                .WithRequired(x => x.Customer)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(false);
        }
    }
}
