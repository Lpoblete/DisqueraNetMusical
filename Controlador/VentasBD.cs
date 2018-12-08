using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Controlador
{
    public class VentasBD
    {
        public int agregar(Ventas v)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("insert into Ventas ([ID_venta],[Fecha],[Cliente_correo],[Total_venta],[Comprobante]) values(" + v.Id + ",'" + v.Fecha + "','" + v.Cliente + "'," + v.TotalVenta + ",'" + v.Comprobante + "')", conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public DataTable listar()
        {
            var dataTable = new DataTable();
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select * from Ventas", conx.conectar());
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                dataTable.Load(reader);
            }
            catch
            {

            }
            return dataTable;
        }
    }
}
