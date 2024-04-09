using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;


public partial class Account_Inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session.Add("id_usuario", "");
        }
    }

    protected void btn_restablece_Click(object sender, EventArgs e)
    {
        EnviaCorreo();
    }
    private void EnviaCorreo()
    {
        try
        {
            Correos oCorreo = new Correos();
            MailMessage msg = new MailMessage();
            msg.Subject = "Restablece contraseña SIPREMM";
            msg.To.Add("luisedgar.cic@gmail.com");
            msg.From = new MailAddress("luispad03@hotmail.com", "LECIC");
            msg.Body = "Correo: " + txt_restablece.Text;
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
            server.Credentials = new System.Net.NetworkCredential("luispad03@hotmail.com", "Cegdo03apo");
            server.EnableSsl = true;
        }
        public void EnviaCorreo(MailMessage message)
        {
            server.Send(message);
        }
    }


    protected void btn_registra_Click(object sender, EventArgs e)
    {

    }

    protected void btn_login_Click(object sender, EventArgs e)
    {
        Usuario oUsuario = new Usuario();
        oUsuario.correo = txt_email_login.Value;
        oUsuario.contraseña = txt_contraseña_login.Value;
        if (oUsuario.Login())
        {
            Session["id_usuario"] = oUsuario.id_usuario;
            Response.Redirect("Receta/Receta.aspx");// pagina de la receta
        }
        else
        {
            this.muestraError("El usuario o contraseña es incorrecto");
        }
    }
}