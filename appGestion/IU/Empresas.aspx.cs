using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appGestion.IU
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString.Get("cif") != null)
            {
                detallesEmpresaSource.SelectCommand = "select coe.cif, coe.codO, coe.fecha, o.coste, coe.dni from ofertas o join hace coe on o.codO=coe.codO join empresas emp on coe.cif=emp.cif where coe.cif='" + Request.QueryString.Get("cif") + "';";
                detallesempresa.EmptyDataText = "No se han encontrado resultados";
            }
            if (Request.QueryString.Get("codO") != null)
            {
                detallesEmpresaSource.SelectCommand = "select coe.cif, coe.codO, coe.fecha, o.coste, coe.dni from ofertas o join hace coe on o.codO=coe.codO join empresas emp on coe.cif=emp.cif where coe.cif='" + Request.QueryString.Get("cif") + "';";
                detallesOfertaSource.SelectCommand = "select codO, nombreO, tipoO from ofertas where codO=" + Request.QueryString.Get("codO") + ";";
            }
        }
        protected void cargarDatos(object sender, EventArgs e)
        {
            
        }
        
    }
}