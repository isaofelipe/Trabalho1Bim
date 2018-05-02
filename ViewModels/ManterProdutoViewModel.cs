using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.ViewModels
{
    public class ManterProdutoViewModel
    {
        public List<Produto> ListaProduto { get; set; }

        public Produto produto { get; set; } = new Produto();
    }
}