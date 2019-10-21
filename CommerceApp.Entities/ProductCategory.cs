using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceApp.Entities
{
   public class ProductCategory
    { 
        
        public int ProductID { get; set; } 
        public Product Product { get; set; }

        public int CategoryID { get; set; } 
        public Category Category { get; set; }
    }
}
