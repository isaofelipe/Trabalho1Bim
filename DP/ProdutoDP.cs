using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.GD;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.DP
{
    public class ProdutoDP
    {
        private ProdutoGD _Repository;
        
        public ProdutoGD Repository
        {
            get
            {
                if (_Repository == null)
                {
                    _Repository = new ProdutoGD(new database1Entities1());
                }
                return _Repository;
            }
        }


    }
}