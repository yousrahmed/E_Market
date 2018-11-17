using System;

namespace E_Market.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int Category_ID { get; set; }
        }
        public class Product
        {
            public int P_ID { get; set; }
            public string P_Name { get; set; }
            public int Quantity { get; set; }
            public string Model { get; set; }
        }
        public class Category
        {
            public int Category_ID { get; set; }
            public string Name { get; set; }
            public int Department { get; set; }
            public string Storge { get; set; }
        }
        }

    }