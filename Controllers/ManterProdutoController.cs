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
    public class ManterProdutoController : Controller
    {
        ManterProdutoViewModel manterProdutoViewModel = new ManterProdutoViewModel();
        ProdutoDP produtoDP = new ProdutoDP();

        // GET: ManterProduto
        public ActionResult Index()
        {
            manterProdutoViewModel.ListaProduto = produtoDP.Repository.RecuperarTodos().ToList();
            return View(manterProdutoViewModel);
        }

        // GET: ManterProduto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManterProduto/Create
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create([Bind(Include = "categoria, estoque, precoUnitario, nome")] Produto Produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    produtoDP.Repository.Adicionar(Produto);
                    return RedirectToAction("Index");
                }
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View(Produto);
        }

        // GET: ManterProduto/Edit/5
        public ActionResult Edit(int id)
        {
            Produto Produto = produtoDP.Repository.RecuperarPorId(id);
            return View(Produto);
        }

        // POST: ManterProduto/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "categoria, estoque, precoUnitario, nome, idProduto")] Produto Produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    produtoDP.Repository.Editar(Produto);
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View(Produto);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                Produto Produto = produtoDP.Repository.RecuperarPorId(id);
                produtoDP.Repository.Remover(Produto);
                
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
