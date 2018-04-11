using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trabalho1Bim.GT
{
    public class RealizarCompraController : Controller
    {
        // GET: RealizarCompra
        public ActionResult Index()
        {
            ViewBag.abc = "jfdisofjdsio";
            return View();
            

        }

        [HttpPost]
        public ActionResult Index(string nome)
        {
            ViewBag.erro = "faltou letras";
            return View();

        }
    }
}