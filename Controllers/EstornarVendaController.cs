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
    public class EstornarVendaController : Controller
    {
        EstornarVendaViewModel estornarVendaViewModel = new EstornarVendaViewModel();
        VendaDP vendaDP = new VendaDP();

        // GET: ManterCliente
        public ActionResult Index()
        {
            estornarVendaViewModel.ListaVenda = vendaDP.Repository.RecuperarTodos().ToList();
            return View(estornarVendaViewModel);
        }
        
        public ActionResult Estornar(int vendaId)
        {
            estornarVendaViewModel.ListaVenda = vendaDP.Repository.RecuperarTodos().ToList();
            if (ModelState.IsValid)
            {
                try
                {
                    new VendaDP().EstornarVenda(vendaId);
                    return View("Index", estornarVendaViewModel);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }
            return View("Index", estornarVendaViewModel);
        }
    }
}
