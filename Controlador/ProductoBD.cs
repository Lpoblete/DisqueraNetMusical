using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Controlador
{
    public class ProductoBD
    {
        public int agregar(Producto p)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("insert into Producto ([ID_producto],[Artista],[Album],[Precio],[Stock],[Genero],[Imagen]) values(" + p.Id + ",'" + p.NombreArtista + "','" + p.NombreAlbum + "'," + p.Precio + "," + p.Stock + ",'" + p.Genero + "','" + p.Imagen + "')", conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public int modificar(Producto p)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("update Producto set ID_producto=" + p.Id + ", Artista='" + p.NombreArtista + "', Album='" + p.NombreAlbum + "', Precio=" + p.Precio + ", Stock=" + p.Stock + ", Genero=" + p.Genero + ", Imagen=" + p.Imagen + " where ID_producto=" + p.Id, conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public int eliminar(Producto p)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("delete from Producto where ID_producto=" + p.Id, conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public DataTable listar()
        {
            var dataTable = new DataTable();
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select * from Producto", conx.conectar());
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
        public DataTable listarPorGenero(string g)
        {
            var dataTable = new DataTable();
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select * from Producto where Genero='" + g + "'", conx.conectar());
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
        public DataTable listarPorAlbum(string a)
        {
            var dataTable = new DataTable();
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select * from Producto where Album='" + a + "'", conx.conectar());
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

        public DataTable listarPorArtista(string a)
        {
            var dataTable = new DataTable();
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select * from Producto where Artista='" + a + "'", conx.conectar());
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

        public DataTable listarPorID(int i)
        {
            var dataTable = new DataTable();
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select * from Producto where ID_producto='" + i + "'", conx.conectar());
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
