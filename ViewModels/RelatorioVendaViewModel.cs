using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.ViewModels
{
    public class RelatorioVendaViewModel
    {
        public List<SelectListItem> ListaVendedores { get; set; }
        public List<Venda> ListaVenda { get; set; } = new List<Venda>();
        public int VendedorId { get; set; }

        public List<SelectListItem> CriarListaVendedores(List<Vendedor> listaVendedores)
        {
            var retorno = listaVendedores.Select(x =>
                new SelectListItem()
                {
                    Text = x.nome,
                    Value = x.idPessoa.ToString()
                }).ToList();
            return retorno;
        }
    }
}