using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appGestion.IU
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            buscarRes.EmptyDataText = "";
        }

        protected void buscar_Click(object sender, EventArgs e)
        {
           buscarSql.SelectCommand = "select e.cif, e.nombre, e.ciudad, e.nEmp, e.tipo, o.CodO, o.nombreO, o.descr, o.tipoO from hace coe, empresas e, ofertas o where coe.cif=e.cif and coe.codO=o.codO and coe.dni='" + (string)Session["dni"] + "' and e.cif like '%" + cifBox.Text + "%' and e.nombre like '%" + nomEmpBox.Text + "%' and e.ciudad like '%" + ciudadBox.Text + "%' and e.nEmp like '%" + numEmpBox.Text + "%' and e.tipo like '" + tipoE.SelectedValue + "' and o.CodO like '%" + tbCodigo.Text + "%' and o.nombreO like '%" + tbNombre.Text + "%' and o.descr like '%" + tbDesc.Text + "%' and o.tipoO like '%" + tbTipo.Text + "%' and o.ambito like '" + ambitoList.SelectedValue + "' and o.estado like '" + estadoList.SelectedValue + "' and o.coste like '%" + tbCoste.Text + "%';";
           buscarRes.EmptyDataText = "No se han encontrado resultados";
        }
    }
}