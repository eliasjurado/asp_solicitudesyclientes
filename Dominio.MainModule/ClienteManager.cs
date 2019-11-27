using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura.Data.SqlServer;
using Dominio.Core.Entities;

namespace Dominio.MainModule
{
    public class ClienteManager
    {
        ClienteDAO cli = new ClienteDAO(); 
        public IEnumerable<Cliente> ListaClientes()
        {
            return cli.ClientesListar();
        }
    }
}
