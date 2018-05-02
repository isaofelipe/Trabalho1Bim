using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.ViewModels
{
    public class RealizarCompraViewModel
    {
        public List<SelectListItem> ListaProdutos { get; set; }
        public List<SelectListItem> ListaFornecedores { get; set; }

        [Required]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        [Required]
        [Display(Name = "Fornecedor")]
        public int FornecedorId { get; set; }

        [Required]
        public int Quantidade { get; set; }

        public List<SelectListItem> CriarListaFornecedores(List<Fornecedor> listaFornecedores)
        {
            var retorno = listaFornecedores.Select(x =>
                new SelectListItem()
                {
                    Text = x.nome,
                    Value = x.idFornecedor.ToString()
                }).ToList();
            return retorno;
        }

        public List<SelectListItem> CriarListaProdutos(List<Produto> listaProdutos)
        {
            var retorno = listaProdutos.Select(x =>
                new SelectListItem()
                {
                    Text = x.nome,
                    Value = x.idProduto.ToString()
                }).ToList();
            return retorno;
        }
    }
}