using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trabalho1Bim.GD;
using Trabalho1Bim.Models;

namespace Trabalho1Bim.DP
{
    public class ClienteService
    {
        private static ClienteRepository _ClienteRepository;
        
        public static ClienteRepository ClienteRepository
        {
            get
            {
                if (_ClienteRepository == null)
                {
                    _ClienteRepository = new ClienteRepository(new database1Entities1());
                }
                return _ClienteRepository;
            }
        }


    }
}