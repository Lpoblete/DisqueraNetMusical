using Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CDMusica
{
    public partial class EliminarCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Tipo_Usuario = Request.Params["txtTipo_usuario"];
        }

        protected void brnEliminar(object sender, EventArgs e)
        {
            string Tipo_Usuario = Request.Params["txtTipo_usuario"];
            UsuarioBD u = new UsuarioBD();
            if (Tipo_Usuario == "Cliente")
            {
                if (u.mostrarTipUsuario(txtCorreo.Text) == "Cliente")
                {
                    try
                    {
                        if (u.EliminarCuenta(txtCorreo.Text) == 1)
                        {
                            txtCorreo.Text = "";
                            //Response.Write("<script type='text/javascript'>alert('Cuenta Eliminada con exito');</script>");
                            detalle.InnerText = "Cuenta Eliminada con exito";
                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
                    }
                }
                else
                {
                    //Response.Write("<script type='text/javascript'>alert('Ingrese un correo valido');</script>");
                    txtCorreo.Text = "";
                    detalle.InnerText = "Ingrese un correo valido";
                }
            }

            if (Tipo_Usuario == "Usuario")
            {
                if (u.mostrarTipUsuario(txtCorreo.Text) == "Usuario")
                {
                    try
                    {
                        if (u.EliminarCuenta(txtCorreo.Text) == 1)
                        {
                            txtCorreo.Text = "";
                            //Response.Write("<script type='text/javascript'>alert('Cuenta Eliminada con exito');</script>");
                            detalle.InnerText = "Cuenta Eliminada con exito";
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
                    }
                }
                else
                {
                    //Response.Write("<script type='text/javascript'>alert('Ingrese un correo valido');</script>");
                    txtCorreo.Text = "";
                    txtCorreo.Focus();
                    detalle.InnerText = "Ingrese un correo valido";
                }
            }
        }
    }
}