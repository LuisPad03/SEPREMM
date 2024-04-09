using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

/// <summary>
/// Descripción breve de Cedula
/// </summary>
public class Cedula
{
    public string error_usuario = "", nombre_completo = "", ced = "", sTitulo = "";
    string sNombre = "", sApemat = "", sApepat = "", sCedula = "";

    public Cedula()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public bool Comprueba_cedula()//Verifica que sean validos los datos ingresados
    {
        bool log = false;
        string name = ""; //Variable para generar el nombre copleto

        Consulta_cedula();
        name = sNombre + " " + sApepat + " " + sApemat;

        try 
        {
            if (ced == sCedula && nombre_completo == name) log = true; //Compara parametros ingresados con los obtenidos en el XML
            else log = false;
        }
        catch (Exception oE)
        {
            log = false;
            error_usuario = oE.Message;
        }
        return log;
    }

    public bool Cedula_aprobada() //Verifica que el Titulo obtenido sea referente a el area Medica
    {
        Consulta_cedula();
        List<string> Titulos_aceptados = new List<string>() { "MÉDICO", "CIRUJANO", "CIRUGÍA"/*, "", "", ""*/ };// Palabras aceptadas 
        bool aceptado = false;

        string texto = sTitulo;
        char[] delimitador = { ' ' };
        string[] palabra = texto.Split(delimitador);

        for (int i = 0; i < palabra.Length; i++) //compara la lista de palabras aceptadas con el Titulo obtendio 
        {
            if (!aceptado)
            {
                for (int j = 0; j < Titulos_aceptados.Count; j++)
                {
                    if (palabra[i] == Titulos_aceptados[j])// Si encuentra coincidencia entre las palabras aprueba la cedula como valida en el area medica
                    {
                        j = Titulos_aceptados.Count;
                        aceptado = true;
                    }
                    else aceptado = false;
                }
            }
        }
        return aceptado;
    }

    public void Consulta_cedula() //Obtiene un XML en con la informacion de la persona mediante el numero de cedula
    {
        string sCedulas = HttpPost("http://search.sep.gob.mx/solr/cedulasCore/select?","fl=%2A%2Cscore&q=" + ced + "&start=0&rows=11&facet=true&indent=on&wt=xml");

        #region // Obtiene los datos principales de del XML

        XmlDocument oNomb = new XmlDocument(); //Obtiene el nombre
        oNomb.LoadXml(sCedulas);
        sNombre = oNomb.SelectSingleNode("/response").ChildNodes[1].ChildNodes[0].ChildNodes[0].InnerText;
        oNomb = null;

        XmlDocument oApP = new XmlDocument(); // Obtiene el apellido paterno
        oApP.LoadXml(sCedulas);
        sApepat = oApP.SelectSingleNode("/response").ChildNodes[1].ChildNodes[0].ChildNodes[9].InnerText;
        oApP = null;

        XmlDocument oApM = new XmlDocument();// Obtiene el apellido materno
        oApM.LoadXml(sCedulas);
        sApemat = oApM.SelectSingleNode("/response").ChildNodes[1].ChildNodes[0].ChildNodes[6].InnerText;
        oApM = null;

        XmlDocument oCed = new XmlDocument(); //Obtiene la cedula
        oCed.LoadXml(sCedulas);
        sCedula = oCed.SelectSingleNode("/response").ChildNodes[1].ChildNodes[0].ChildNodes[2].InnerText;
        oCed = null;

        XmlDocument oTitulo = new XmlDocument(); //Obtiene la cedula
        oTitulo.LoadXml(sCedulas);
        sTitulo = oTitulo.SelectSingleNode("/response").ChildNodes[1].ChildNodes[0].ChildNodes[3].InnerText;
        oTitulo = null;
        #endregion

    }

    static string HttpPost(string uri, string parameters)
    {
        // parameters: name1=value1&name2=value2 
        WebRequest webRequest = WebRequest.Create(uri);
        webRequest.ContentType = "application/x-www-form-urlencoded";
        webRequest.Method = "POST";
        byte[] bytes = Encoding.ASCII.GetBytes(parameters);
        Stream os = null;
        try
        {
            webRequest.ContentLength = bytes.Length;   //Count bytes to send
            os = webRequest.GetRequestStream();
            os.Write(bytes, 0, bytes.Length);         //Send it
        }
        catch (WebException ex)
        {

        }
        finally
        {
            if (os != null)
            {
                os.Close();
            }
        }
        try
        {
            WebResponse webResponse = webRequest.GetResponse();
            if (webResponse == null)
            { return null; }
            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }
        catch (WebException ex)
        {

        }
        return null;
    }

}