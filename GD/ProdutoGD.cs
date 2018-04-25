using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.GD
{
    public class ProdutoGD : BaseGD<Produto>, IDisposable
    {
        public ProdutoGD(database1Entities1 context) : base(context)
        {
        }
    }
}