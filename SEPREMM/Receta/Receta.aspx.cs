using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Receta_Receta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["id_usuario"] == null) Response.Redirect("../Account/Login.aspx");
        if (!IsPostBack)
        {
            int id_usuario;
            string nombre;
            id_usuario = int.Parse(Session["id_usuario"].ToString());
            nombre = Session["nombre"].ToString();
            Session["id_usuario"] = id_usuario;
            Session["nombre"] = nombre;
            //lbl_usuario.Text = Session["nombre"].ToString();
            //Label1.Text = string.Format("{0:dd/MM/yyyy HH:mm}", DateTime.Now);
            Label1.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
        }
    }
}