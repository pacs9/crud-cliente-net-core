using domain;
using Microsoft.EntityFrameworkCore;
using repository.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace repository
{
    public class Repositorio<T> : IRepositorio<T>, IDisposable where T : class
    {
        private readonly Contexto _contexto;

        public Repositorio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Insert(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();
        }

        public void Delete(Func<T, bool> predicate)
        {
            _contexto.Set<T>().Where(predicate).ToList().ForEach(delete => _contexto.Set<T>().Remove(delete));
            _contexto.SaveChanges();
        }

        public T FindById(params object[] key)
        {
            return _contexto.Set<T>().Find(key);
        }

        public T Fisrt(Expression<Func<T, bool>> predicate)
        {
            return _contexto.Set<T>().FirstOrDefault(predicate);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _contexto.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _contexto.Set<T>();
        }

        public void Update(T entity)
        {
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return _contexto.Set<T>().Any(predicate);
        }        

        public void Dispose()
        {
            if (_contexto != null)
            {
                _contexto.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}
