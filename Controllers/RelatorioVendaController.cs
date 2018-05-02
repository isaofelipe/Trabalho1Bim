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
    public class RelatorioVendaController : Controller
    {
        RelatorioVendaViewModel relatorioVendaViewModel = new RelatorioVendaViewModel();
        VendedorDP vendedorDP = new VendedorDP();
        VendaDP vendaDP = new VendaDP();

        // GET: ManterCliente
        public ActionResult Index()
        {
            relatorioVendaViewModel.ListaVendedores = relatorioVendaViewModel.CriarListaVendedores(vendedorDP.Repository.RecuperarTodos().ToList());
            relatorioVendaViewModel.ListaVenda = vendaDP.Repository.RecuperarTodos().ToList();
            return View(relatorioVendaViewModel);
        }

        [HttpPost]
        public ActionResult Index(RelatorioVendaViewModel model)
        {
            relatorioVendaViewModel.ListaVendedores = relatorioVendaViewModel.CriarListaVendedores(vendedorDP.Repository.RecuperarTodos().ToList());
            relatorioVendaViewModel.ListaVenda = vendaDP.Repository.RecuperarPorVendedor(model.VendedorId);
            return View(relatorioVendaViewModel);
        }
    }
}
