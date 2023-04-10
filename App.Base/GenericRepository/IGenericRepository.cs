using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Base.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        T FindById(long id);
        T Find(Expression<Func<T, bool>> predicate);
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetList(Expression<Func<T, bool>> predicate);

    }
}
