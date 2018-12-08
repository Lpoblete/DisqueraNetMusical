using Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CDMusica
{
    public partial class VerBoletas : System.Web.UI.Page
    {
        public DataTable ventas;

        protected void Page_Load(object sender, EventArgs e)
        {
            VentasBD venBD = new VentasBD();

            ventas = venBD.listar();

        }
    }
}