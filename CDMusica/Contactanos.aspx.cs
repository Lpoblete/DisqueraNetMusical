using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using System.Configuration;

namespace CDMusica
{
    public partial class Contactanos : System.Web.UI.Page
    {
        public void EnviarCorreo(string correo,string mensaje,string asunto)
        {
            //string to = ConfigurationManager.AppSettings["To"];
            /*-------------------------MENSAJE DE CORREO----------------------*/
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress("TUEMAIL"));//a quien se le manda el mail
            email.From = new MailAddress(correo);//mail desde donde se envia
            email.Subject = asunto+" de "+ correo;
            email.Body = mensaje + "\n\n" + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss");
            email.BodyEncoding = System.Text.Encoding.UTF8;

            /*-------------------------CLIENTE DE CORREO----------------------*/
            
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("TUEMAIL", "TUPASS");

            /*---------------------------ENVIO DE CORREO----------------------*/
            smtp.Send(email);
            email.Dispose();
            Response.Write("<script language='JavaScript'>alert('Mensaje Enviado Correctamente...!!!');</script>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            slctConsulta.Value = "Seleccione";
            txtEmail.Value = "";
            txtAreaComentario.Value = "";
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!slctConsulta.Value.Equals("Seleccione"))
                {
                    EnviarCorreo(txtEmail.Value, txtAreaComentario.Value, slctConsulta.Value);
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('Selecciones el tipo de consulta');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "');</script>");
                
            }
        }

    }
}