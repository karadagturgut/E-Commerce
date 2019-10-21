using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CommerceApp.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        T GetByID(int ID);
        T GetOne(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter=null);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
