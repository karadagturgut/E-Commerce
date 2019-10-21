using CommerceApp.DataAccess.Abstract;
using CommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CommerceApp.DataAccess.Concreate.EfCore
{
    public class EfCategoryDal : EfCoreGenericRepository<Category,ShopContext>,ICategoryDal
    {
        
    }
}
