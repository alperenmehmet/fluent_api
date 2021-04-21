using fluent_api.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public float UnitsInStock { get; set; }

        //foreign key category
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

        //foreign key supplier
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        
    }
}
