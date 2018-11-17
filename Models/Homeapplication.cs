using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Market.Models
{
    public class Homeapplication
    {
        public int Id { get; set; }

        private string productTpye;

        public string GetProductTpye()
        {
            return productTpye;
        }

        public void SetProductTpye(string value) => productTpye = value;
        public int ProductAvaliable { get; set; }
        public int Category_ID { get; set; }
        public List<Category> Clist { get; set; }
    }
    }

