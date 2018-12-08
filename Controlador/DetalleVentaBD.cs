using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace Controlador
{
    public class DetalleVentaBD
    {

        public int agregar(DetalleVenta dv)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("insert into Detalle_Venta ([ID_detalle_venta],[ID_producto],[Cantidad],[Sub_total]) values(" + dv.Id + "," + dv.IdProducto + "," + dv.Cantidad + "," + dv.SubTotal + ")", conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public int eliminar()
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("delete from Detalle_Venta", conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public DataTable listar()
        {
            var dataTable = new DataTable();
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select dv.*, pr.Album from Detalle_Venta dv inner join Producto pr ON dv.ID_producto = pr.ID_producto", conx.conectar());
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
