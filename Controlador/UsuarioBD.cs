using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Controlador
{
    public class UsuarioBD
    {
        public bool inicioSesion(string corr, string pass)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("select * from Usuario where Correo_usuario='" + corr + "' and Pass='"+pass+"'", conx.conectar());
            SqlDataReader reader = comando.ExecuteReader();
            return reader.Read();
        }

        public string mostrarNombre(string corr)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select Nombre from Usuario where Correo_usuario='" + corr + "'", conx.conectar());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return reader["Nombre"].ToString();
            }
            else
            {
                return null;
            }
        }

        public string mostrarTipUsuario(string corr)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select Tipo_usuario from Usuario where Correo_usuario='" + corr + "'", conx.conectar());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return reader["Tipo_usuario"].ToString();
            }
            else
            {
                return null;
            }
        }

        public string mostrarFoto(string corr)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select Imagen from Usuario where Correo_usuario='" + corr +"'", conx.conectar());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return reader["Imagen"].ToString();
            }
            else
            {
                return null;
            }
        }

        public string mostrarPassword(string corr)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select Pass from Usuario where Correo_usuario='" + corr + "'", conx.conectar());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return reader["Pass"].ToString();
            }
            else
            {
                return null;
            }
        }

        public string mostrarEdad(string corr)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select Edad from Usuario where Correo_usuario='" + corr + "'", conx.conectar());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return reader["Edad"].ToString();
            }
            else
            {
                return null;
            }
        }
        
        public int agregarCliente(Usuario u)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("insert into Usuario values('" + u.Correo + "','Cliente','" + u.Pass + "','" + u.Nombre + "'," + u.Edad + ",'no','" + u.Foto + "');", conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public int agregarUsuario(Usuario u)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("insert into Usuario values('" + u.Correo + "','Usuario','" + u.Pass + "','" + u.Nombre + "'," + u.Edad + ",'no','" + u.Foto + "');", conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public int TipoUsuario(Usuario u)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("insert into Usuario values('" + u.Correo + "','" + u.Tipo_usuario +"','" + u.Pass + "','" + u.Nombre + "'," + u.Edad + ",'0','" + u.Foto + "');", conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public bool ObtenerUsuario(string corr)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("select * from Usuario where Correo_usuario='" + corr + "'", conx.conectar());
            SqlDataReader reader = comando.ExecuteReader();
            return reader.Read();
        }

        public int EliminarCuenta(string corr)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("delete from Usuario where Correo_usuario='" + corr + "'", conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }

        public int ActualizarCuentaSinFoto(string Pass,string Nombre, int Edad, string Correo)
        {
            Conexion conx = new Conexion();
            SqlCommand comando = new SqlCommand("update Usuario set Pass='" + Pass + "', Nombre='" + Nombre + "', Edad=" + Edad + " where Correo_usuario='" + Correo + "'", conx.conectar());
            conx.conectar().Open();
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }
        
        /*********Intentos de ingreso de sesion********************************************/
        public string mostrarIntentos(string corr)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand cmd = new SqlCommand("select Bloqueado from Usuario where Correo_usuario='" + corr + "'", conx.conectar());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return reader["Bloqueado"].ToString();
            }
            else
            {
                return null;
            }
        }
        public int ActualizarIntentos(string intentos,string correo)
        {
            Conexion conx = new Conexion();
            conx.conectar().Open();
            SqlCommand comando = new SqlCommand("update Usuario set Bloqueado='" + intentos + "' where Correo_usuario='" + correo + "'", conx.conectar());
            int resultado = comando.ExecuteNonQuery();
            conx.cerrar();
            return resultado;
        }
    }
}
