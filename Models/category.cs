using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Market.Models
{
    public class Category

    {
        [Required]
        public int Category_ID { get; set; }
        [StringLength(50, ErrorMessage = "limited")]
        public string Name { get; set; }
        public int Department{ get; set; }
        public string Storge { get; set; }
        public List<Customer> Clist { get; set; }
        public List<Product> Plist { get; set; }

    }
}
