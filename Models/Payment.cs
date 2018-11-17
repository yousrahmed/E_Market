using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Market.Models
{
    public class Payment
    {
        public int Card_id { get; set;}
        public string C_name { get; set; }
        public string C_address { get; set; }
        public int P_Quantity { get; set; }
    }
}
