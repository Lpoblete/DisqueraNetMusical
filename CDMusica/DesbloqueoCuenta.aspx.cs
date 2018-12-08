using Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CDMusica
{
    public partial class DesbloqueoCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDesbloquear(object sender, EventArgs e)
        {
            UsuarioBD u = new UsuarioBD();
            int intentos = 0;
            int resultado = u.ActualizarIntentos(intentos.ToString(), txtCorreo.Text);

            if (resultado == 1)
            {
                //Response.Write("<script type='text/javascript'>alert('Su cuenta se a Desbloqueado');</script>");
                detalle.InnerText = "Su cuenta se a Desbloqueado";
                txtCorreo.Text = "";
            }
            else
            {
                //Response.Write("<script type='text/javascript'>alert('Correo erroneo');</script>");
                detalle.InnerText = "Correo erroneo";
                txtCorreo.Text = "";
                txtCorreo.Focus();
            }
        }
    }
}