using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.ViewModels
{
    public class RealizarCompraViewModel
    {
        public List<Produto> ListaProdutos { get; set; }
        public List<SelectListItem> ListaFornecedores { get; set; }
        public int ProdutoId { get; set; }
        public int FornecedorId { get; set; }
        public int Quantidade { get; set; }

        public List<SelectListItem> CriarListaProdutos(List<Fornecedor> listaFornecedores)
        {
            var retorno = listaFornecedores.Select(x =>
                new SelectListItem()
                {
                    Text = x.nome,
                    Value = x.idFornecedor.ToString()
                }).ToList();
            return retorno;
        }
    }
}