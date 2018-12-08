using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Controlador;
using Modelo;

namespace CDMusica
{
    public partial class CrearUsuario : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string Tipo_Usuario = Request.Params["txtTipo_usuario"];
            Label1.Text = Tipo_Usuario;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Tipo_Usuario = Request.Params["txtTipo_usuario"];
            string Cod = Request.Params["Cod"];
            try
            {
                string filename = Path.GetFileName(ImagenUsuario.PostedFile.FileName);
                string ext = Path.GetExtension(filename);

                if (ext == ".png" || ext == ".PNG" || ext == ".jpg" || ext == ".JPG" || ext == ".jpeg" || ext == ".JPEG" || ext == ".gif" || ext == ".GIF")
                {
                    Stream fs = ImagenUsuario.PostedFile.InputStream;
                    BinaryReader br = new BinaryReader(fs);
                    byte[] bytes = br.ReadBytes((int)fs.Length);
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    string imagenURL = "data:image/jpeg;base64," + base64String;

                    UsuarioBD usuBD = new UsuarioBD();

                    int resultado = usuBD.TipoUsuario(new Usuario(Correo.Text, Tipo_Usuario, Pass.Text, Nombre.Text, int.Parse(Edad.Text), null, imagenURL));

                    if (resultado == 1)
                    {
                        Correo.Text = "";
                        Pass.Text = "";
                        Nombre.Text = "";
                        Edad.Text = "";
                        Response.Write("<script type='text/javascript'>alert('" + Tipo_Usuario + " registrado');</script>");
                        /*if (Tipo_Usuario == "Usuario")
                        {
                            if (Cod == "1")
                            {
                                Response.Redirect("Principal.aspx");
                            }
                            else
                            {
                                Response.Redirect("AdmUsuarios.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("AdmClientes.aspx");
                        }*/

                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'>alert('no se pudo registrar " + Tipo_Usuario + "');</script>");
                    }
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('imagen no soportado');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
            }
        }
    }
}
