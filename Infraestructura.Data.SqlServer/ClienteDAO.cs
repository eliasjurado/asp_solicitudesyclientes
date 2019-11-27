using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Core.Entities;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
    public class ClienteDAO
    {
        SqlConnection cn;
        Conexion cnx = new Conexion();

        public IEnumerable<Cliente> ClientesListar()
        {
            cn = cnx.getConexion();
            List<Cliente> temporal = new List<Cliente>();
            SqlCommand cmd = new SqlCommand("select * from tb_clientes",cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente reg = new Cliente
                {
                    idcliente = dr.GetString(0),
                    nombrecia = dr.GetString(1)
                };
                temporal.Add(reg);
            }
            dr.Close();
            cn.Close();
            return temporal;
        }
    }
}
