using CommerceApp.DataAccess.Abstract;
using CommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CommerceApp.DataAccess.Concreate.Memory
{
    public class MemoryProduct : IProductDal
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product() {ID=1,ProductName="IPhone X", ImageURL="1.jpg",Price=5999},
                new Product() {ID=2,ProductName="Samsung Galaxy S9", ImageURL="2.jpg",Price=5999},
                new Product() {ID=3,ProductName="Samsung Galaxy A30", ImageURL="3.jpg",Price=1799},

            };
            return products;
        }

        public Product GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
