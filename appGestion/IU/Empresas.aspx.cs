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
                detallesEmpresaSource.SelectCommand = "select coe.cif, coe.codO, coe.fecha, coe.coste, coe.dni from comoferemp coe join empresas emp on coe.cif=emp.cif where coe.cif='" + Request.QueryString.Get("cif") + "';";
            }
            if (Request.QueryString.Get("codO") != null)
            {
                detallesEmpresaSource.SelectCommand = "select coe.cif, coe.codO, coe.fecha, coe.coste, coe.dni from comoferemp coe join empresas emp on coe.cif=emp.cif where coe.cif='" + Request.QueryString.Get("cif") + "';";
                detallesOfertaSource.SelectCommand = "select codO, nombre, tipo from ofertas where codO=" + Request.QueryString.Get("codO") + ";";
            }
        }
        protected void cargarDatos(object sender, EventArgs e)
        {
            
        }
        
    }
}