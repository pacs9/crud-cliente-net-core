using domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace repository
{
    public class Repositorio<T> : IRepositorio<T>, IDisposable where T : class
    {
        private readonly Contexto Contexto;

        protected Repositorio()
        {
            Contexto = new Contexto();
        }

        public void Insert(T entity)
        {
            Contexto.Set<T>().Add(entity);
            Contexto.SaveChanges();
        }

        public void Delete(Func<T, bool> predicate)
        {
            Contexto.Set<T>().Where(predicate).ToList().ForEach(delete => Contexto.Set<T>().Remove(delete));
            Contexto.SaveChanges();
        }

        public T FindById(params object[] key)
        {
            return Contexto.Set<T>().Find(key);
        }

        public T Fisrt(Expression<Func<T, bool>> predicate)
        {
            return Contexto.Set<T>().FirstOrDefault(predicate);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Contexto.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return Contexto.Set<T>();
        }

        public void Update(T entity)
        {
            Contexto.Entry(entity).State = EntityState.Modified;
            Contexto.SaveChanges();
        }

        public void Dispose()
        {
            if (Contexto != null)
            {
                Contexto.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}
