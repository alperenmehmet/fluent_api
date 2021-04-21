using fluent_api.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.Entities.Concrete
{
    public class OrderDetail : BaseEntity
    {
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        //foreign key
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        //foreign key
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
