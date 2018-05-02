using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.GD;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.DP
{
    public class VendaDP
    {
        private VendaGD _Repository;
        
        public VendaGD Repository
        {
            get
            {
                if (_Repository == null)
                {
                    _Repository = new VendaGD(new database1Entities1());
                }
                return _Repository;
            }
        }

        public void EstornarVenda(int vendaId)
        {
            Venda venda = Repository.RecuperarPorId(vendaId);
            if (DateTime.Now.Subtract(venda.data.Value).TotalDays > 7)
            {
                throw new Exception("tempo excedido para estorno da venda");
            }
            ItemVendaGD itemVendaGD = new ItemVendaGD(Repository._context);
            foreach(var itemVenda in venda.ItemVenda)
            {
                itemVendaGD.Remover(itemVenda);
            }
            venda = Repository.RecuperarPorId(vendaId);
            Repository.Remover(venda);
        }
    }
}