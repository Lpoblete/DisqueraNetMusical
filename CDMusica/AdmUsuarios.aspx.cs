using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CDMusica
{
    public partial class AdmUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnEliminar(object sender, EventArgs e)
        {
            string usuario = "Usuario";
            Server.Transfer("EliminarCuenta.aspx?txtTipo_usuario=" + usuario + "");
        }

        protected void btnModificar(object sender, EventArgs e)
        {
            string usuario = "Usuario";
            Server.Transfer("ModificarCuenta.aspx?txtTipo_usuario=" + usuario + "");
        }

        protected void btnCrear(object sender, EventArgs e)
        {
            string usuario = "Usuario";
            Server.Transfer("CrearCuenta.aspx?txtTipo_usuario=" + usuario+"");
        }

        protected void btnDesbloquear(object sender, EventArgs e)
        {
            Server.Transfer("DesbloqueoCuenta.aspx");
        }
    }
}