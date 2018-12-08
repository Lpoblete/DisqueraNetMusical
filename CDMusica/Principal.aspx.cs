using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Controlador;

namespace CDMusica
{
    public partial class Principal : System.Web.UI.Page
    {
        public DataTable productos;

        protected void Page_Load(object sender, EventArgs e)
        {

            ProductoBD proBD = new ProductoBD();

            DataTable tablaProductos = proBD.listar();

            string[] generos = { "", "Electronica", "Jazz", "Metal", "Pop", "Punk", "Rap" };

            Random r = new Random();

            int numAleatorio = r.Next(1, 6);

            if (tablaProductos.Rows.Count > 0)
            {
                productos = proBD.listarPorGenero(generos[numAleatorio]);
                DataRow datosProductos = proBD.listarPorGenero(generos[numAleatorio]).Rows[0];

                generosRandom.InnerText = "Discos de " + datosProductos["Genero"].ToString();
            }
            else
            {
                //productos = proBD.listar();
            }
        }
    }
}