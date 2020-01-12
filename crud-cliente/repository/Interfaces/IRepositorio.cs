using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace repository.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T FindById(params object[] key);
        T Fisrt(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Func<T, bool> predicate);
        bool Any(Expression<Func<T, bool>> predicate);
        void Dispose();
    }
}
