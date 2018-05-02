using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabalho1Bim.DP;
using Trabalho1Bim.ViewModels;

namespace Trabalho1Bim.GT
{
    public class RealizarVendaController : Controller
    {
        RealizarVendaViewModel realizarVendaViewModel = new RealizarVendaViewModel();
        VendaFacadeDP facadeDP = new VendaFacadeDP();
        ClienteDP clienteDP = new ClienteDP();
        ProdutoDP produtoDP = new ProdutoDP();
        VendedorDP vendedorDP = new VendedorDP();
        // GET: RealizarCompra
        public ActionResult Index()
        {
            realizarVendaViewModel.ListaProdutos = realizarVendaViewModel.CriarListaProdutos(produtoDP.Repository.RecuperarTodos().ToList());
            realizarVendaViewModel.ListaClientes = realizarVendaViewModel.CriarListaClientes(clienteDP.Repository.RecuperarTodos().ToList());
            realizarVendaViewModel.ListaVendedores = realizarVendaViewModel.CriarListaVendedores(vendedorDP.Repository.RecuperarTodos().ToList());
            return View(realizarVendaViewModel);
        }
        [HttpPost]
        public ActionResult Index(RealizarVendaViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    facadeDP.RealizarVenda(model.ClienteId, model.VendedorId, model.ProdutoId, model.Quantidade);
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            model.ListaProdutos = realizarVendaViewModel.CriarListaProdutos(produtoDP.Repository.RecuperarTodos().ToList());
            model.ListaClientes = realizarVendaViewModel.CriarListaClientes(clienteDP.Repository.RecuperarTodos().ToList());
            model.ListaVendedores = realizarVendaViewModel.CriarListaVendedores(vendedorDP.Repository.RecuperarTodos().ToList());
            return View(model);
        }
    }
}