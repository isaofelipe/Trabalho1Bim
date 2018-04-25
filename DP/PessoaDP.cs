using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.GD;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.DP
{
    public class PessoaDP
    {
        private static PessoaGD _Repository;
        
        public static PessoaGD Repository
        {
            get
            {
                if (_Repository == null)
                {
                    _Repository = new PessoaGD(new database1Entities1());
                }
                return _Repository;
            }
        }


    }
}