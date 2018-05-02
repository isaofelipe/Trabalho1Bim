using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.ViewModels
{
    public class ManterClienteViewModel
    {
        public List<Cliente> ListaCliente { get; set; }

        public Cliente cliente { get; set; } = new Cliente();
    }
}