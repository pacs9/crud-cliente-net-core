using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using domain;
using business;
using view_model;
using AutoMapper;

namespace crud_cliente.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteBusiness _business;

        public ClienteController(Contexto contexto, IMapper mapper)
        {
            _business = new ClienteBusiness(contexto, mapper);
        }

        // GET: Cliente
        public IActionResult Index()
        {
            return View(_business.GetAll());
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nome,DataNascimento,Sexo,Cep,Endereco,Numero,Complemento,Bairro,Estado,Cidade")] ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.Id = Guid.NewGuid();

                _business.Insert(cliente);

                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        // GET: Cliente/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = _business.FindById(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Cliente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,Nome,DataNascimento,Sexo,Cep,Endereco,Numero,Complemento,Bairro,Estado,Cidade")] ClienteViewModel cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _business.Update(cliente);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: Cliente/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = _business.Fisrt(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (ClienteExists(id))
            {
                _business.Delete(c => c.Id == id);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(Guid id)
        {
            return _business.Any(e => e.Id == id);
        }
    }
}
