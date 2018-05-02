using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.ViewModels
{
    public class RealizarVendaViewModel
    {
        public List<SelectListItem> ListaProdutos { get; set; }
        public List<SelectListItem> ListaClientes { get; set; }
        public List<SelectListItem> ListaVendedores { get; set; }

        [Required]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        [Required]
        [Display(Name = "Vendedor")]
        public int VendedorId { get; set; }

        [Required]
        public int Quantidade { get; set; }

        public List<SelectListItem> CriarListaClientes(List<Cliente> listaClientes)
        {
            var retorno = listaClientes.Select(x =>
                new SelectListItem()
                {
                    Text = x.nome,
                    Value = x.idPessoa.ToString()
                }).ToList();
            return retorno;
        }

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