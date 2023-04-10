using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App.Base.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public T Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);

            _dbContext.SaveChanges();

            return entity;
        }
        public void Delete(T entity)
        {
          _dbSet.Remove(entity);

            _dbContext.SaveChanges();

        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            predicate ??= x => true;

            return _dbSet.Find(predicate);
        }

        public T FindById(long id) => _dbSet.Find(id);
        

        public IEnumerable<T> GetList(Expression<Func<T, bool>> predicate)
        {
            predicate ??= x => true;

            return _dbSet.Where(predicate).ToList();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
