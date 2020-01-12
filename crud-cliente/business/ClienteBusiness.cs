using AutoMapper;
using business.Interfaces;
using domain;
using repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using view_model;

namespace business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly Repositorio<Cliente> _repositorio;
        IMapper _mapper;
        
        public ClienteBusiness(Contexto contexto, IMapper mapper)
        {
            _repositorio = new Repositorio<Cliente>(contexto);
            _mapper = mapper;
        }

        public IList<ClienteViewModel> GetAll()
        {
            return _mapper.Map<IList<ClienteViewModel>>(_repositorio.GetAll());
        }

        public IQueryable<ClienteViewModel> Get(Expression<Func<Cliente, bool>> predicate)
        {                        
            return _mapper.Map<IQueryable<ClienteViewModel>>(_repositorio.Get(predicate));
        }

        public ClienteViewModel FindById(params object[] key)
        {
            return _mapper.Map<ClienteViewModel>(_repositorio.FindById(key));
        }

        public ClienteViewModel Fisrt(Expression<Func<Cliente, bool>> predicate)
        {
            return _mapper.Map<ClienteViewModel>(_repositorio.Fisrt(predicate));
        }

        public void Delete(Func<Cliente, bool> predicate)
        {
            _repositorio.Delete(predicate);            
        }

        public void Insert(ClienteViewModel cliente)
        {
            _repositorio.Insert(_mapper.Map<Cliente>(cliente));
        }

        public void Update(ClienteViewModel cliente)
        {
            _repositorio.Update(_mapper.Map<Cliente>(cliente));
        }

        public bool Any(Expression<Func<Cliente, bool>> predicate)
        {
            return _repositorio.Any(predicate);
        }
    }
}
