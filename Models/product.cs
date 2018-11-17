using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Market.Models
{
    public class Product
    {
        public int P_ID { get; set; }
        public string P_Name { get; set; }
        public int Quantity { get; set; }
        public string Model { get; set; }
        public List<Category> Clist { get; set; }
    }
}
