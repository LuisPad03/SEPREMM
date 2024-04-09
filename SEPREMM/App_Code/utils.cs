using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Web.UI;

public static class _Utils
{
    #region MetodosVarios
    //[Extension()]
    public static DataSet ToDataSet<T>(this IList<T> list)
    {
        Type elementType = typeof(T);
        DataSet ds = new DataSet();
        DataTable t = new DataTable();
        ds.Tables.Add(t);

        //add a column to table for each public property on T
        foreach (var propInfo in elementType.GetProperties())
        {
            t.Columns.Add(propInfo.Name, propInfo.PropertyType);
        }

        //go through each property on T and add each value to the table
        foreach (T item in list)
        {
            DataRow row = t.NewRow();
            foreach (var propInfo in elementType.GetProperties())
            {
                row[propInfo.Name] = propInfo.GetValue(item, null);
            }
        }

        return ds;
    }
    public static DataTable ToDataTable<T>(this IEnumerable<T> collection)
    {
        DataTable dt = new DataTable("DataTable");
        Type t = typeof(T);
        PropertyInfo[] pia = t.GetProperties();

        //Inspect the properties and create the columns in the DataTable
        foreach (PropertyInfo pi in pia)
        {
            Type ColumnType = pi.PropertyType;
            if ((ColumnType.IsGenericType))
            {
                ColumnType = ColumnType.GetGenericArguments()[0];
            }
            dt.Columns.Add(pi.Name, ColumnType);
        }

        //Populate the data table
        foreach (T item in collection)
        {
            DataRow dr = dt.NewRow();
            dr.BeginEdit();
            foreach (PropertyInfo pi in pia)
            {
                if (pi.GetValue(item, null) != null)
                {
                    dr[pi.Name] = pi.GetValue(item, null);
                }
            }
            dr.EndEdit();
            dt.Rows.Add(dr);
        }
        return dt;
    }
    #endregion
    public static DataTable LastTable(this DataSet ds)
    {
        if (
        ds != null
        &&
        ds.Tables.Count > 0
        )
        {
            return ds.Tables[ds.Tables.Count - 1];
        }
        else
        {
            return null;
        }
    }
    public static void registraScript(this System.Web.UI.Page page, string script)
    {
        scriptCounter += 1;

        if (scriptCounter > 100000) { scriptCounter = 0; }

        Random randomizer = new Random();
        string scriptKey = "s" + scriptCounter.ToString() + DateTime.Now.ToString("HHmmssfff") + randomizer.Next(9999).ToString();

        ScriptManager.RegisterStartupScript(page, page.GetType(), scriptKey, script, true);
    }
    public static void muestraExito(this System.Web.UI.Page page, string Mensaje, string Titulo)
    {
        string scriptMuestraError =
            "$('#lblModalMensajeTitulo').text('"+Titulo+"');\r\n"
            + "$('#lblModalMensajeTexto').text('" + Mensaje.Trim().Replace("'", "").Replace("\"", "").Replace("\r", "").Replace("\n", "") + "');\r\n"
            + "$('#modMensaje').modal();\r\n"
            ;

        page.registraScript(scriptMuestraError);
    }
    public static void muestraError(this System.Web.UI.Page page, string Mensaje)
    {
        string scriptMuestraError =
             "$('#lblModalMensajeTexto').text('" + Mensaje.Trim().Replace("'", "").Replace("\"", "").Replace("\r", "").Replace("\n", "") + "');\r\n"
            + "$('#modMensaje').modal();\r\n"
            ;

        page.registraScript(scriptMuestraError);
    }
    public static int scriptCounter { get; set; }
}