using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Modelo;
using Controlador;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace CDMusica
{
    public partial class CarritoCompras : System.Web.UI.Page
    {
        public DataTable detallesVentas;

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                Usuario usu = (Usuario)Session["MiUsuario"];

                if (!(usu.Correo == null))
                {
                    string idProd = Request.Params["idPro"];

                    DetalleVentaBD detven = new DetalleVentaBD();
                    detallesVentas = detven.listar();

                    DataRow datosProducto;

                    if (!(idProd == null))
                    {
                        ProductoBD proBD = new ProductoBD();
                        DataTable tablaProducto = proBD.listarPorID(int.Parse(idProd));
                        datosProducto = tablaProducto.Rows[0];

                        DataTable tablaDetalleVenta = detven.listar();
                        int acumulandoID = tablaDetalleVenta.Rows.Count + 1;

                        detven.agregar(new DetalleVenta(acumulandoID, int.Parse(datosProducto["ID_producto"].ToString()), int.Parse(datosProducto["Stock"].ToString()), int.Parse(datosProducto["Precio"].ToString())));

                        Response.Redirect("CarritoCompras.aspx");
                    }

                    int sumando = 0;

                    foreach (DataRow dr in detallesVentas.Rows)
                    {
                        sumando = sumando + int.Parse(dr["Sub_total"].ToString());
                    }

                    montoFinal.InnerText = sumando.ToString();
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('Debe iniciar sesion para poder comprar'); location.href = 'Principal.aspx';</script>");
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DetalleVentaBD detven = new DetalleVentaBD();
            detallesVentas = detven.listar();

            DateTime fechaHoy = DateTime.Today;
            string fecha = fechaHoy.ToString("dd-MM-yy");

            Usuario usu = (Usuario)Session["MiUsuario"];

            if (detallesVentas.Rows.Count > 0)
            {

                string[] textoPDF = new string[]
    {
                    "NET MUSICAL",
                    "Venta de discos de musicas",
                    " ",
    };

                string[] textoPDF2 = new string[]
                {
                    "Correo :                        " + usu.Correo,
                    "Nombre :                        " + usu.Nombre,
                    " ",
                    "Monto Total :                   " + montoFinal.InnerText,
                    " ",
                    "Fecha Impresion :               " + fecha
                };

                Document doc = new Document();
                MemoryStream ms = new MemoryStream();
                PdfWriter.GetInstance(doc, ms);

                doc.Open();
                for (int i = 0; i < textoPDF.Length; i++)
                {
                    Paragraph parag = new Paragraph(textoPDF[i], new Font(Font.FontFamily.HELVETICA, 20, Font.BOLD));
                    parag.Alignment = Element.ALIGN_CENTER;
                    doc.Add(parag);
                }
                for (int i = 0; i < textoPDF2.Length; i++)
                {
                    Paragraph parag = new Paragraph(textoPDF2[i], new Font(Font.FontFamily.COURIER, 10, Font.BOLD));
                    parag.Alignment = Element.ALIGN_LEFT;
                    doc.Add(parag);
                }
                doc.Close();

                byte[] bytes = ms.ToArray();
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                string PDFURL = "data:application/pdf;base64," + base64String;

                VentasBD venBD = new VentasBD();
                DataTable tablaVentas = venBD.listar();

                int acumulandoID = tablaVentas.Rows.Count + 1;

                venBD.agregar(new Ventas(acumulandoID, fecha, usu.Correo, int.Parse(montoFinal.InnerText), PDFURL));

                detven.eliminar();

                detallesVentas = detven.listar();

                montoFinal.InnerText = "???";

                Response.Write("<script type='text/javascript'>alert('Compra generada'); window.open('" + PDFURL + "','_blank');</script>");
            }
            else
            {
                Response.Write("<script type='text/javascript'>alert('Carrito compra vacio');</script>");
            }
        }
    }
}