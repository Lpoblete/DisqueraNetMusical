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
    public partial class ModificarCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Tipo_Usuario = Request.Params["txtTipo_usuario"];
            txtTipoCuenta.Text = Tipo_Usuario;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Tipo_Usuario = Request.Params["txtTipo_usuario"];
            txtTipoCuenta.Text = Tipo_Usuario;

            try
            {
            string filename = Path.GetFileName(ImgCuenta.PostedFile.FileName);
            string ext = Path.GetExtension(filename);

            if (ext == ".png" || ext == ".PNG" || ext == ".jpg" || ext == ".JPG" || ext == ".jpeg" || ext == ".JPEG" || ext == ".gif" || ext == ".GIF")
            {
                Stream fs = ImgCuenta.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                byte[] bytes = br.ReadBytes((int)fs.Length);
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                string imagenURL = "data:image/jpeg;base64," + base64String;

                UsuarioBD usuBD = new UsuarioBD();
                if (txtCorreo.Text != "")
                {
                    usuBD.EliminarCuenta(txtCorreo.Text);
                    int resultado = usuBD.TipoUsuario(new Usuario(txtCorreo.Text, Tipo_Usuario, txtPass.Text, txtNombre.Text, int.Parse(txtEdad.Text), null, imagenURL));

                    //int resultado = usuBD.ActualizarCuentaConFoto(txtPass.Text, txtNombre.Text, int.Parse(txtEdad.Text), imagenURL, txtCorreo.Text);

                    if (resultado == 1)
                    {
                        Response.Write("<script type='text/javascript'>alert('Cuenta actualizada');</script>");
                        txtPass.Text = "";
                        txtNombre.Text = "";
                        txtEdad.Text = "";
                        ImgActual.ImageUrl = "Imagenes/albumDesc.png";

                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'>alert('no se pudo actualizar la Cuenta');</script>");
                    }
                }
            }
            else
            {
                UsuarioBD usuBD = new UsuarioBD();
                if (txtCorreo.Text != "")
                {
                    //usuBD.EliminarCuenta(txtCorreo.Text);

                    int resultado = usuBD.ActualizarCuentaSinFoto(txtPass.Text, txtNombre.Text, int.Parse(txtEdad.Text), txtCorreo.Text);

                    if (resultado == 1)
                    {
                        Response.Write("<script type='text/javascript'>alert('Cuenta actualizada');</script>");
                        txtPass.Text = "";
                        txtNombre.Text = "";
                        txtEdad.Text = "";
                        ImgActual.ImageUrl = "Imagenes/albumDesc.png";

                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'>alert('no se pudo actualizar la Cuenta');</script>");
                    }
                }


                //Response.Write("<script type='text/javascript'>alert('imagen no soportado');</script>");
            }
            }
            catch (Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string Tipo_Usuario = Request.Params["txtTipo_usuario"];
            UsuarioBD u = new UsuarioBD();
            if (Tipo_Usuario == "Cliente")
            {
                if (u.mostrarTipUsuario(txtCorreo.Text) == "Cliente")
                {
                    try
                    {
                        if (u.ObtenerUsuario(txtCorreo.Text))
                        {
                            txtPass.Text = u.mostrarPassword(txtCorreo.Text);
                            txtNombre.Text = u.mostrarNombre(txtCorreo.Text);
                            txtEdad.Text = u.mostrarEdad(txtCorreo.Text);
                            ImgActual.ImageUrl = u.mostrarFoto(txtCorreo.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
                    }
                }
                else
                {
                    txtCorreo.Text = "";
                    txtPass.Text = "";
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                    ImgActual.ImageUrl = "~/Imagenes/albumDesc.png";
                    Response.Write("<script type='text/javascript'>alert('Ingrese un correo de " + Tipo_Usuario + " valido');</script>");
                }
            }

            if (Tipo_Usuario == "Usuario")
            {
                if (u.mostrarTipUsuario(txtCorreo.Text) == "Usuario")
                {
                    try
                    {
                        if (u.ObtenerUsuario(txtCorreo.Text))
                        {
                            txtPass.Text = u.mostrarPassword(txtCorreo.Text);
                            txtNombre.Text = u.mostrarNombre(txtCorreo.Text);
                            txtEdad.Text = u.mostrarEdad(txtCorreo.Text);
                            ImgActual.ImageUrl = u.mostrarFoto(txtCorreo.Text);
                        }

                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
                    }
                }
                else
                {
                    txtCorreo.Text = "";
                    txtPass.Text = "";
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                    ImgActual.ImageUrl = "~/Imagenes/albumDesc.png";
                    Response.Write("<script type='text/javascript'>alert('Ingrese un correo de " + Tipo_Usuario + " valido');</script>");
                }
            }
        }
    }
}