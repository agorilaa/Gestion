using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
using appGestion.BBL;

namespace appGestion.IU
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.SelectCommand = "select e.cif, e.nombre, e.ciudad, e.nEmp, e.tipo from comerciales c join comemp com on c.dni=com.dni join empresas e on com.cif=e.cif where c.dni='" + (string)Session["dni"] + "';";
        }
        
    }
}