using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Core.Entities;
using System.Data.SqlClient;

namespace Infraestructura.Data.SqlServer
{
    public class SolicitudDAO
    {
        SqlConnection cn;
        Conexion cnx = new Conexion();

        public IEnumerable<Solicitud> SolicitudListar()
        {
            cn = cnx.getConexion();
            List<Solicitud> temporal = new List<Solicitud>();
            SqlCommand cmd = new SqlCommand("select * from tb_solicitud",cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Solicitud reg = new Solicitud
                {
                    idsol = dr.GetInt32(0),
                    fechasol =dr.GetDateTime(1),
                    idcliente = dr.GetString(2),
                    detsol = dr.GetString(3),
                    costosol = dr.GetDecimal(4)
                };
                temporal.Add(reg);
            }
            dr.Close();
            cn.Close();
            return temporal;
        }

        public string SolicitudAgregar(Solicitud reg)
        {
            cn = cnx.getConexion();
            string mensaje = "";
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into tb_solicitud values(@cod,@fec,@idcli,@det,@cost)", cn);
                cmd.Parameters.AddWithValue("@cod", reg.idsol);
                cmd.Parameters.AddWithValue("@fec", reg.fechasol);
                cmd.Parameters.AddWithValue("@idcli", reg.idcliente);
                cmd.Parameters.AddWithValue("@det", reg.detsol);
                cmd.Parameters.AddWithValue("@cost", reg.costosol);

                int i = cmd.ExecuteNonQuery();
                mensaje = i.ToString() + "registro agregado";
            }
            catch(SqlException e)
            {
                mensaje = e.Message;
            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }
    }
}
