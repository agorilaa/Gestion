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
            prueba.Text = "select e.cif, e.nombre, e.ciudad, e.nEmp, e.tipo, o.CodO, o.nombreO, o.descr, o.tipoO, o.ambito, o.estado, o.coste from comoferemp coe, empresas e, ofertas o where coe.cif=e.cif and coe.codO=o.codO and coe.dni='" + (string)Session["dni"] + "' and e.cif='%" + cifBox + " ;"; //%' and e.nombre='%" + nomEmpBox.Text + "%' and e.ciudad='%" + ciudadBox.Text + "%' and e.nEmp=" + int.Parse(numEmpBox.Text) + " and e.tipo='" + tipoE.SelectedValue + "' and o.CodO=" + int.Parse(tbCodigo.Text) + " and o.nombreO='%" + tbNombre.Text + "%' and o.descr='%" + tbDesc.Text + "%' and o.tipo='%" + tbTipo.Text + "%' and o.ambito='" + ambitoList.SelectedValue + "' and o.estado='" + estadoList.SelectedValue + "' and o.coste= "+int.Parse(tbCoste.Text) +";";
        }

        protected void buscar_Click(object sender, EventArgs e)
        {
            buscarSql.SelectCommand = "select e.cif, e.nombre, e.ciudad, e.nEmp, e.tipo, o.CodO, o.nombreO, o.descr, o.tipoO, o.ambito, o.estado, o.coste from comoferemp coe, empresas e, ofertas o where coe.cif=e.cif and coe.codO=o.codO and coe.dni='" + (string)Session["dni"] + "' and e.cif='%"+cifBox+"%' and e.nombre='%"+nomEmpBox.Text+"%' and e.ciudad='%"+ciudadBox.Text+"%' and e.nEmp="+int.Parse(numEmpBox.Text)+" and e.tipo='"+tipoE.SelectedValue+"' and o.CodO="+int.Parse(tbCodigo.Text)+" and o.nombreO='%"+tbNombre.Text+"%' and o.descr='%"+tbDesc.Text+"%' and o.tipo='%"+tbTipo.Text+"%' and o.ambito='"+ambitoList.SelectedValue+"' and o.estado='"+estadoList.SelectedValue+"' and o.coste="+int.Parse(tbCoste.Text)+"";
        }
    }
}