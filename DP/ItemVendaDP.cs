using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.GD;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.DP
{
    public class ItemVendaDP
    {
        private static ItemVendaGD _Repository;
        
        public static ItemVendaGD Repository
        {
            get
            {
                if (_Repository == null)
                {
                    _Repository = new ItemVendaGD(new database1Entities1());
                }
                return _Repository;
            }
        }


    }
}