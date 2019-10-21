using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceApp.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public List<ProductCategory> ProductCategory { get; set; }
    }
}
