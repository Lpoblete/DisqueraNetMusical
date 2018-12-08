using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TipoUsuario
    {
        private int id;
        private string descripcion;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public TipoUsuario() { }
        public TipoUsuario(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

    }
}
