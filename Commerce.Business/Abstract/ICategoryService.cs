using CommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Commerce.Business.Abstract
{
    interface ICategoryService
    {
        Category GetByID(int id);
        List<Category> GetAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
