using fluent_api.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fluent_api.Core.Entities.Concrete
{
    public class Supplier : BaseEntity
    {
        public string CompanyName { get;set;}
        public string ContactName { get;set;}
        public string ContactTitle { get;set;}
        public string Adress { get;set;}
        public string City { get;set;}
        public string Region { get;set;}
        public string Country { get;set;}
        public string PostalCode { get;set;}
        public string Phone { get;set;}

        public virtual List<Product> Products { get; set; }

    }
}
