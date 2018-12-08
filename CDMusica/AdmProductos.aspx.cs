using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using Controlador;
using Modelo;

namespace CDMusica
{
    public partial class AdmProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Producto pro = new Producto();
                ProductoBD proBD = new ProductoBD();

                DataTable tablaProducto = proBD.listar();

                int acumuladorID = tablaProducto.Rows.Count + 1;

                string filename = Path.GetFileName(Imagen.PostedFile.FileName);
                string ext = Path.GetExtension(filename);

                if (ext == ".png" || ext == ".PNG" || ext == ".jpg" || ext == ".JPG" || ext == ".jpeg" || ext == ".JPEG" || ext == ".gif" || ext == ".GIF")
                {
                    Stream fs = Imagen.PostedFile.InputStream;
                    BinaryReader br = new BinaryReader(fs);
                    byte[] bytes = br.ReadBytes((int)fs.Length);
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    string imagenURL = "data:image/jpeg;base64," + base64String;

                    proBD.agregar(new Producto(acumuladorID, Artista.Text, Album.Text, int.Parse(Precio.Text), 1, genero.Value, imagenURL));

                    Response.Write("<script type='text/javascript'>alert('Album agregado');</script>");
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('imagen no soportado');</script>");
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
            }
        }
    }
}