using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private string correo;
        private string tipo_usuario;
        private string pass;
        private string nombre;
        private int edad;
        private string bloqueo;
        private string foto;

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Tipo_usuario
        {
            get
            {
                return tipo_usuario;
            }

            set
            {
                tipo_usuario = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public string Bloqueo
        {
            get
            {
                return bloqueo;
            }

            set
            {
                bloqueo = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public Usuario() { }
        public Usuario(string correo, string tipo_usuario, string pass, string nombre, int edad, string bloqueo, string foto)
        {
            Correo = correo;
            Tipo_usuario = tipo_usuario;
            Pass = pass;
            Nombre = nombre;
            Edad = edad;
            Bloqueo = bloqueo;
            Foto = foto;
        }
    }
}
