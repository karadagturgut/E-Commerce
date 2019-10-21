using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceApp.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<ProductCategory> ProductCategory { get; set; }
    }
}
