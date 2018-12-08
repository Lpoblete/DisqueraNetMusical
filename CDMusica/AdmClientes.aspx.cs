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
    public partial class AdmClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearUsu_Click(object sender, EventArgs e)
        {
           /* try
            {
                string filename = Path.GetFileName(ImagenCliente.PostedFile.FileName);
                string ext = Path.GetExtension(filename);

                if (ext == ".png" || ext == ".PNG" || ext == ".jpg" || ext == ".JPG" || ext == ".jpeg" || ext == ".JPEG" || ext == ".gif" || ext == ".GIF")
                {
                    Stream fs = ImagenCliente.PostedFile.InputStream;
                    BinaryReader br = new BinaryReader(fs);
                    byte[] bytes = br.ReadBytes((int)fs.Length);
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    string imagenURL = "data:image/jpeg;base64," + base64String;

                    UsuarioBD usuBD = new UsuarioBD();

                    int resultado = usuBD.agregarCliente(new Usuario(txtCorreoCli.Text, null, txtPassCli.Text, txtNombreCli.Text, int.Parse(txtEdadCli.Text), null, imagenURL));

                    if (resultado == 1)
                    {
                        Response.Write("<script type='text/javascript'>alert('usuario registrado');</script>");
                        txtCorreoCli.Text = "";
                        txtPassCli.Text = "";
                        txtNombreCli.Text = "";
                        txtEdadCli.Text = "";
                    }
                    else
                    {
                        Response.Write("<script type='text/javascript'>alert('no se pudo registrar usuario');</script>");
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
            }*/
        }

        protected void btnModificarUsu_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }
        
        protected void btnCrear(object sender, EventArgs e)
        {
            string usuario = "Cliente";
            Server.Transfer("CrearCuenta.aspx?txtTipo_usuario=" + usuario + "");
        }

        protected void btnModificar(object sender, EventArgs e)
        {
            string usuario = "Cliente";
            Server.Transfer("ModificarCuenta.aspx?txtTipo_usuario=" + usuario + "");
        }

        protected void btnEliminar(object sender, EventArgs e)
        {
            string usuario = "Cliente";
            Server.Transfer("EliminarCuenta.aspx?txtTipo_usuario=" + usuario + "");
        }
    }
}