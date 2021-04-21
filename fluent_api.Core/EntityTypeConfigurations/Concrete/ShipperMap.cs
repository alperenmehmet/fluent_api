using fluent_api.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.EntityTypeConfigurations.Concrete
{
    public class ShipperMap : EntityMap<Shipper>
    {
        public ShipperMap()
        {
            ToTable("dbo.Shippers");

            Property(x => x.CompanyName).IsOptional();
            Property(x => x.Phone).IsOptional();

            HasMany(x => x.Orders)
                .WithRequired(x => x.Shipper)
                .HasForeignKey(x => x.ShipperId)
                .WillCascadeOnDelete(false);
        }
    }
}
