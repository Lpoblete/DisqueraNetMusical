using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using Modelo;

namespace CDMusica
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        private Usuario MiUsuario
        {
            get
            {
                if (Session["MiUsuario"] == null)
                {
                    Session["MiUsuario"] = new Usuario();
                }
                return (Usuario)Session["MiUsuario"];
            }
            set
            {
                Session["MiUsuario"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var usuIni = Request.Params["usu"];

            if (!(MiUsuario.Correo == null) && MiUsuario.Tipo_usuario == "Cliente")
            {
                usuIniciado.Text = MiUsuario.Nombre;
                fotoUsu.Src = MiUsuario.Foto;

                cor.Visible = false;
                pas.Visible = false;
                Corr.Visible = false;
                Pass.Visible = false;
                Button1.Visible = false;
                Button2.Visible = false;
                Button3.Visible = true;
                fotoUsu.Visible = true;

                clienteTitulo.Visible = true;
                clienteFunciones.Visible = true;

                usuarioTitulo.Visible = false;
                usuarioFunciones.Visible = false;

                //UsuarioBD u = new UsuarioBD();

                //u.ActualizarIntentos("0", usuIni);
            }
            else if (!(MiUsuario.Correo == null) && MiUsuario.Tipo_usuario == "Usuario")
            {
                usuIniciado.Text = MiUsuario.Nombre;
                fotoUsu.Src = MiUsuario.Foto;

                cor.Visible = false;
                pas.Visible = false;
                Corr.Visible = false;
                Pass.Visible = false;
                Button1.Visible = false;
                Button2.Visible = false;
                Button3.Visible = true;
                fotoUsu.Visible = true;

                clienteTitulo.Visible = false;
                clienteFunciones.Visible = false;

                usuarioTitulo.Visible = true;
                usuarioFunciones.Visible = true;

                //UsuarioBD u = new UsuarioBD();
                //u.ActualizarIntentos("0", usuIni);
            }
            else
            {
                usuIniciado.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBD u = new UsuarioBD();
                int intentos = int.Parse(u.mostrarIntentos(Corr.Value));
                if (intentos < 3 && u.inicioSesion(Corr.Value, Pass.Value))
                {
                    MiUsuario = new Usuario();
                    MiUsuario.Correo = Corr.Value;
                    MiUsuario.Nombre = u.mostrarNombre(Corr.Value);
                    MiUsuario.Foto = u.mostrarFoto(Corr.Value);
                    MiUsuario.Tipo_usuario = u.mostrarTipUsuario(Corr.Value);
                    usuIniciado.Text = u.mostrarNombre(Corr.Value);

                    cor.Visible = false;
                    pas.Visible = false;
                    Corr.Visible = false;
                    Pass.Visible = false;
                    Button1.Visible = false;
                    Button2.Visible = false;
                    Button3.Visible = true;
                    fotoUsu.Visible = true;
                    fotoUsu.Src = u.mostrarFoto(Corr.Value);

                    clienteTitulo.Visible = true;
                    clienteFunciones.Visible = true;

                    usuarioTitulo.Visible = false;
                    usuarioFunciones.Visible = false;

                    if (MiUsuario.Tipo_usuario == "Cliente")
                    {
                        Response.Redirect("Principal.aspx?usu=" + Corr.Value);
                    }
                    if (MiUsuario.Tipo_usuario == "Usuario")
                    {
                        Response.Redirect("VerBoletas.aspx?usu=" + Corr.Value);
                    }
                }
                else
                {
                    //int intentos = int.Parse(u.mostrarIntentos(Corr.Value));
                    if (intentos < 3)
                    {
                        intentos += 1;
                        int cantidadIntentos = 4 - intentos;
                        Response.Write("<script type='text/javascript'>alert('Datos erroneos, tiene " + cantidadIntentos + " intentos');</script>");
                        int resultado = u.ActualizarIntentos(intentos.ToString(), Corr.Value);
                        Corr.Focus();
                    }
                    else
                    {

                        intentos += 1;
                        int resultado = u.ActualizarIntentos(intentos.ToString(), Corr.Value);
                        Response.Write("<script type='text/javascript'>alert('Datos erroneos, Su cuenta se a bloqueado porngase en contacto con el administrador');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string usuario = "Cliente";
            string Cod = "1";
            Server.Transfer("CrearCuenta.aspx?txtTipo_usuario=" + usuario + "&Cod=" + Cod);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MiUsuario.Correo = null;
            usuIniciado.Text = "";
            fotoUsu.Src = "Imagenes/albumDesc.png";

            cor.Visible = true;
            pas.Visible = true;
            Corr.Visible = true;
            Pass.Visible = true;
            Button1.Visible = true;
            Button2.Visible = true;
            Button3.Visible = false;
            fotoUsu.Visible = false;

            clienteTitulo.Visible = true;
            clienteFunciones.Visible = true;

            usuarioTitulo.Visible = false;
            usuarioFunciones.Visible = false;

            DetalleVentaBD dvBD = new DetalleVentaBD();
            dvBD.eliminar();

            Response.Redirect("Principal.aspx");
        }
    }
}
