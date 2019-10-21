using CommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Commerce.Business.Abstract
{
    public interface IProductService 
    {
        Product GetByID(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
