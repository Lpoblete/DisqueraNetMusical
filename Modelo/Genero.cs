using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Genero
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

        public Genero() { }
        public Genero(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
