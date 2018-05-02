using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabalho1Bim.DP;
using Trabalho1Bim.ViewModels;

namespace Trabalho1Bim.GT
{
    public class RealizarCompraController : Controller
    {
        RealizarCompraViewModel realizarCompraViewModel = new RealizarCompraViewModel();
        ProdutoDP produtoDP = new ProdutoDP();
        FornecedorDP fornecedorDP = new FornecedorDP();
        CompraFacadeDP facadeDP = new CompraFacadeDP();
        // GET: RealizarCompra
        public ActionResult Index()     
        {
            realizarCompraViewModel.ListaProdutos = realizarCompraViewModel.CriarListaProdutos(produtoDP.Repository.RecuperarTodos().ToList());
            realizarCompraViewModel.ListaFornecedores = realizarCompraViewModel.CriarListaFornecedores(fornecedorDP.Repository.RecuperarTodos().ToList());
            return View(realizarCompraViewModel);
        }
        [HttpPost]
        public ActionResult Index(RealizarCompraViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    facadeDP.RealizarCompra(model.FornecedorId, model.ProdutoId, model.Quantidade);
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View(model);
        }
    }
}