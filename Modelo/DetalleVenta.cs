using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleVenta
    {
        private int id;
        private int idProducto;
        private int cantidad;
        private int subTotal;

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

        public int IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public int SubTotal
        {
            get
            {
                return subTotal;
            }

            set
            {
                subTotal = value;
            }
        }

        public DetalleVenta() { }
        public DetalleVenta(int id, int idProducto, int cantidad, int subTotal)
        {
            Id = id;
            IdProducto = idProducto;
            Cantidad = cantidad;
            SubTotal = subTotal;
        }
    }
}
