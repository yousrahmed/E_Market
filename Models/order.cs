using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Market.Models
{
    public class Order
    {
        
        public int P_ID { get; set; }
        public string P_Name { get; set; }
        public int Quantity { get; set; }
        public string Model { get; set; }
        public List<Product> Plist { get; set; }
        public List<Customer> Clist { get; set; }
    }
}
