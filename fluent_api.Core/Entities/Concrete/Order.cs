using fluent_api.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.Entities.Concrete
{
    public class Order : BaseEntity
    {
        public DateTime? OrderDate { get; }
        public DateTime? RequiredDate { get; }
        public DateTime? ShippedDate { get; }
        public int ShipVia { get; set; }
        public float Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAdress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

        //foreign key shipper
        public int ShipperId { get; set; }
        public virtual Shipper Shipper { get; set; }

        //foreign key customer
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
