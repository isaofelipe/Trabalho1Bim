using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabalho1Bim.ViewModels;

namespace Trabalho1Bim.GT
{
    public class RealizarCompraController : Controller
    {
        RealizarCompraViewModel realizarCompraViewModel = new RealizarCompraViewModel();
        // GET: RealizarCompra
        public ActionResult Index()
        {
            realizarCompraViewModel.ListaProdutos = 
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nome)
        {
            return View();

        }
    }
}