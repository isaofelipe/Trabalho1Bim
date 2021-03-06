﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.GD
{
    public class VendaGD : BaseGD<Venda>, IDisposable
    {
        public VendaGD(database1Entities1 context) : base(context)
        {
        }

        internal List<Venda> RecuperarPorVendedor(int vendedorId)
        {
            return RecuperarTodos().Where(x => x.Vendedor.idPessoa == vendedorId).ToList();
        }
    }
}