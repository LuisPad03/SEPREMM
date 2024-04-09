using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using SEPREMM;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Net.Mail;



public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                Session.Add("id_usuario", "");
                Session.Add("nombre", "");

            }
        }

    protected void btn_logiin_Click(object sender, EventArgs e)
    {
        Usuario oUsuario = new Usuario();
        oUsuario.correo = txt_email_login.Value;
        oUsuario.contraseña = txt_contraseña_login.Value;
        if (oUsuario.Login())
        {
            Session["id_usuario"] = oUsuario.id_usuario;
            Response.Redirect("../Receta/Receta.aspx");// pagina de la receta
        }
        else
        {
            this.muestraError("El usuario o contraseña es incorrecto, intenta de nuevo.");
        }
    }

    protected void btn_registra_Click1(object sender, EventArgs e)
    {
        Cedula oCedula = new Cedula();
        oCedula.ced = txt_cedula_registro.Value;
        oCedula.nombre_completo = txt_nombre_registro.Value.ToUpper();
        int num_car = txt_cedula_registro.Value.Length;
        if (num_car == 7)
        {
            if (oCedula.Comprueba_cedula())
            {
                if (oCedula.Cedula_aprobada())
                {
                    if (txt_contraseña_registro.Value != txt_confirma_contraseña.Value)
                    {
                        this.muestraError(" Las contraseñas no coinciden");
                    }
                    else
                    {
                        Usuario oUsuario = new Usuario();
                        oUsuario.nombre = txt_nombre_registro.Value;
                        oUsuario.correo = txt_correo_registro.Value;
                        oUsuario.cedula = txt_cedula_registro.Value;
                        oUsuario.contraseña = txt_contraseña_registro.Value;

                        if (oUsuario.Guardar())
                        {
                            this.muestraExito("Usuario Registrado", "Datos guardados");
                        }
                        else
                        {
                            this.muestraError(oUsuario.error_usuario/*, "Hechale mas ganitas"*/);
                        }
                    }
                }
                else
                {
                    string texto = txt_nombre_registro.Value;
                    char[] delimitador = { ' ' };
                    string[] palabra = texto.Split(delimitador);
                    string nombre = palabra[0].ToLowerInvariant();
                    this.muestraError("Estimado " + nombre + ", necesita tener un titulo relacionado al area medica," + "\r\n"+"y el de usted es en: "+ oCedula.sTitulo);
                }
            }
            else
            {
                this.muestraError("El nombre de usuario o numero de cedula es incorrecto, intenta de nuevo o puede ponserse en contacto con nostros"/*, "Hechale mas ganitas"*/);
            }
        }
        else
        {
            this.muestraError("Formato de cedula incorrecto, debe tener 7 numeros"/*, "Hechale mas ganitas"*/);
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

}