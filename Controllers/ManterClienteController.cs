using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabalho1Bim.DP;
using Trabalho1Bim.GD;
using Trabalho1Bim.Models;
using Trabalho1Bim.ViewModels;

namespace Trabalho1Bim.Controllers
{
    public class ManterClienteController : Controller
    {
        ManterClienteViewModel manterClienteViewModel = new ManterClienteViewModel();
        ClienteRepository _ClienteRepository;

        private ClienteRepository clienteRepository{
            get
            {
                if(_ClienteRepository == null)
                {
                    _ClienteRepository = new ClienteRepository(new database1Entities1());
                }
                return _ClienteRepository;
            }
        }

        // GET: ManterCliente
        public ActionResult Index()
        {
            manterClienteViewModel.ListaCliente = clienteRepository.RecuperarTodos().ToList();
            return View(manterClienteViewModel);
        }

        // GET: ManterCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManterCliente/Create
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create([Bind(Include = "telefone, endereco, nome, cpf")] Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ClienteService.ClienteRepository.Adicionar(cliente);
                    return RedirectToAction("Index");
                }
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View(cliente);
        }

        // GET: ManterCliente/Edit/5
        public ActionResult Edit(int id)
        {
            Cliente cliente = clienteRepository.RecuperarPorId(id);
            return View(cliente);
        }

        // POST: ManterCliente/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "telefone, endereco, nome, cpf")] Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ClienteService.ClienteRepository.Editar(cliente);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View(cliente);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                Cliente cliente = clienteRepository.RecuperarPorId(id);
                clienteRepository.Remover(cliente);
                
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
