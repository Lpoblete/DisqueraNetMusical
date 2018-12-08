using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using System.Data;

namespace CDMusica
{
    public partial class Artistas : System.Web.UI.Page
    {
        public DataTable productos;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ProductoBD proBD = new ProductoBD();

            productos = proBD.listarPorAlbum(nomb.Value);

            nomb.Value = "";
            arti.Value = "";
            gene.Value = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ProductoBD proBD = new ProductoBD();

            productos = proBD.listarPorArtista(arti.Value);

            nomb.Value = "";
            arti.Value = "";
            gene.Value = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ProductoBD proBD = new ProductoBD();

            productos = proBD.listarPorGenero(gene.Value);

            nomb.Value = "";
            arti.Value = "";
            gene.Value = "";
        }
    }
}