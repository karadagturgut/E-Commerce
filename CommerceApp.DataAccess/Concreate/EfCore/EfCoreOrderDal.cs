using CommerceApp.DataAccess.Abstract;
using CommerceApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommerceApp.DataAccess.Concreate.EfCore
{
   public class EfCoreOrderDal:EfCoreGenericRepository<Order,ShopContext>,IOrderDal
    {
    }
}
