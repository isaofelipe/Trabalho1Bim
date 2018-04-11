using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.ViewModels
{
    public class RealizarCompraViewModel
    {
        public List<Produto> ListaProdutos { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }
        public int ProdutoId { get; set; }
        public int FornecedorId { get; set; }
        public int Quantidade { get; set; }
    }
}