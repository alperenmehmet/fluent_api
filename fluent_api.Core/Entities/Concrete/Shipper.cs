using fluent_api.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.Entities.Concrete
{
    public class Shipper : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
