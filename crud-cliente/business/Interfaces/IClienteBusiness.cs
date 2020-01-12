using domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using view_model;

namespace business.Interfaces
{
    interface IClienteBusiness
    {
        IList<ClienteViewModel> GetAll();
        IQueryable<ClienteViewModel> Get(Expression<Func<Cliente, bool>> predicate);
        ClienteViewModel FindById(params object[] key);
        ClienteViewModel Fisrt(Expression<Func<Cliente, bool>> predicate);
        void Insert(ClienteViewModel cliente);
        void Update(ClienteViewModel cliente);
        void Delete(Func<Cliente, bool> predicate);
        bool Any(Expression<Func<Cliente, bool>> predicate);
    }
}
