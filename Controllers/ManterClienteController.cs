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

        // GET: ManterCliente
        public ActionResult Index()
        {
            manterClienteViewModel.ListaCliente = ClienteDP.Repository.RecuperarTodos().ToList();
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
                    ClienteDP.Repository.Adicionar(cliente);
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
            Cliente cliente = ClienteDP.Repository.RecuperarPorId(id);
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
                    ClienteDP.Repository.Editar(cliente);
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
                Cliente cliente = ClienteDP.Repository.RecuperarPorId(id);
                ClienteDP.Repository.Remover(cliente);
                
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
