using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Ventas
    {
        private int id;
        private string fecha;
        private string cliente;
        private int totalVenta;
        private string comprobante;

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

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public int TotalVenta
        {
            get
            {
                return totalVenta;
            }

            set
            {
                totalVenta = value;
            }
        }

        public string Comprobante
        {
            get
            {
                return comprobante;
            }

            set
            {
                comprobante = value;
            }
        }

        public Ventas() { }
        public Ventas(int id, string fecha, string cliente, int totalVenta, string comprobante)
        {
            Id = id;
            Fecha = fecha;
            Cliente = cliente;
            TotalVenta = totalVenta;
            Comprobante = comprobante;
        }
    }
}
