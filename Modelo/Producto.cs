using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private int id;
        private string nombreArtista;
        private string nombreAlbum;
        private int precio;
        private int stock;
        private string genero;
        private string imagen;

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

        public string NombreArtista
        {
            get
            {
                return nombreArtista;
            }

            set
            {
                nombreArtista = value;
            }
        }

        public string NombreAlbum
        {
            get
            {
                return nombreAlbum;
            }

            set
            {
                nombreAlbum = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public Producto() { }
        public Producto(int id, string nombArtista, string nombAlbum, int precio, int stock, string genero, string imagen)
        {
            Id = id;
            NombreArtista = nombArtista;
            NombreAlbum = nombAlbum;
            Precio = precio;
            Stock = stock;
            Genero = genero;
            Imagen = imagen;
        }
    }
}
