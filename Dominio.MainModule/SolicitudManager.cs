using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura.Data.SqlServer;
using Dominio.Core.Entities;

namespace Dominio.MainModule
{
    public class SolicitudManager
    {
        SolicitudDAO sol = new SolicitudDAO();
        public IEnumerable<Solicitud> ListaSolicitudes()
        {
            return sol.SolicitudListar();
        }
        public string AgregarCliente(Solicitud reg)
        {
            return sol.SolicitudAgregar(reg);
        }
    }
}
