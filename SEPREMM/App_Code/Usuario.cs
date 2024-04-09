using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    public int id_usuario, id_status;
    public DateTime fecha_registro, fecha_cambio_contraseña;
    public string nombre = "", cedula = "", correo = "", contraseña = "", error_usuario = "";
    public Usuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public bool Guardar()
    {
        bool guarda = false;
        DataAcces oData = new DataAcces();
        try
        {
            oData.Sentencia = "exec sp_guarda_usuario @id_usuario=" + id_usuario.ToString() + ", @nombre='" + nombre.Trim() + 
                            "', @correo='" + correo.Trim() + "',@cedula='" + cedula.ToString() + "',@contraseña='" + contraseña.Trim() +
                            /* "',@id_estatus=" + id_estatus.ToString() +
            ",@id_tipo_usuario=" + id_tipo_usuario.ToString() + 
            ",@fecha_registro='" + string.Format("{0:yyyyMMdd HH:mm:ss}", fecha_registro) +
            "',@fecha_cambio_contraseña='" + string.Format("{{0:yyyyMMdd HH:mm:ss}", fecha_cambio_contraseña) +
            "',@fecha_activacion_cuenta='" + string.Format("{{0:yyyyMMdd HH:mm:ss}", fecha_activacion_cuenta) +
            "',@id_activacion='" + id_activacion.Trim() +*/ "'";
            System.Data.DataSet oDs = new System.Data.DataSet();
            oDs = oData.GetData();
            if (int.Parse(oDs.Tables[0].Rows[0]["error"].ToString()) == 0) guarda = true;
            else
            {
                error_usuario = oDs.Tables[0].Rows[0]["descripcion"].ToString();
                guarda = false;
            } 
        }
        catch (Exception oE)
        {
            guarda = false;
            error_usuario = oE.Message;
        }
        return guarda;
    }

    public bool Login()
    {
        bool login = false;
        DataAcces oData = new DataAcces();
        try
        {
            oData.Sentencia = "exec sp_login '" + correo.Trim() + "','" + contraseña.Trim() + "'";
            System.Data.DataSet oDs = new System.Data.DataSet();
            oDs = oData.GetData();
            if (int.Parse(oDs.Tables[0].Rows[0]["error"].ToString()) == 0)
            {
                id_usuario = int.Parse(oDs.Tables[0].Rows[0]["usuario"].ToString());
                login = true;

            }
            else
            {
                error_usuario = oDs.Tables[0].Rows[0]["descripcion"].ToString();
                login = false;
            }
        }
        catch (Exception oE)
        {
            login = false;
            error_usuario = oE.Message;
        }
        return login;
    }
}