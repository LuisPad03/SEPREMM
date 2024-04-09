using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Web.Mail;
using System.Net.Mail;

public partial class Contact : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_envia_Click(object sender, EventArgs e)
    {
        EnviaCorreo();
    }

    private void EnviaCorreo()
    {
        try
        {
            Correos oCorreo = new Correos();
            MailMessage msg = new MailMessage();
            msg.Subject = "Contacto SIPREMM";
            msg.To.Add("luisedgar.cic@gmail.com");
            //msg.From = new MailAddress("luisedgar.cic@hotmail.com", "LECIC");
            msg.From = new MailAddress("luispad03@hotmail.com", "LECIC");
            msg.Body = "Nombre: " + txt_nombre.Value + "\r\n" +
                       "Email: " + txt_email.Value + "\r\n" + 
                       "Telefono: " + txt_telefono.Value + "\r\n" + "\r\n" +
                       "Mensaje: " + txt_mensaje.Value;
            oCorreo.EnviaCorreo(msg);
            //Console.WriteLine("Correo enviado satisfactoriamente");
        }
        catch (Exception ex)
        {
           // Console.WriteLine("Error: " + ex.Message);
        }
    }

    internal class Correos
    {
        SmtpClient server = new SmtpClient("SMTP.Office365.com", 587);
        public Correos()
        {
            //server.Credentials = new System.Net.NetworkCredential("luisedgar.cic@hotmail.com", "Luisedgar94");
            server.Credentials = new System.Net.NetworkCredential("luispad03@hotmail.com", "Cegdo03apo");
            server.EnableSsl = true;
        }
        public void EnviaCorreo(MailMessage message)
        {
            server.Send(message);
        }
    }

}