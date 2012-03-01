using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appGestion.BBL;

namespace appGestion.IU
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ofertasSql.SelectCommand = "select o.codO, o.nombreO, o.descr, o.tipoO, o.ambito, o.estado, o.coste from ofertas o";
            //ofertasSql.SelectCommand = "select o.codO, coe.cif, o.nombreO, o.descr, o.tipoO, o.ambito, o.estado, o.coste from hace coe, ofertas o where o.codO=coe.codO and coe.dni='" + (string)Session["dni"] + "' ;";
            ofertasRes.EmptyDataText = "No se han encontrado resultados";
        }

        protected void añadir_Click(object sender, EventArgs e)
        {
            string cif = Request.QueryString.Get("cif");
            string dni = (string)Session["dni"];
            foreach (GridViewRow gvr in ofertasRes.Rows)
            {

                if (((CheckBox)gvr.FindControl("CheckBoxOf")).Checked == true)
                {
                    int codOf = Convert.ToInt32(ofertasRes.DataKeys[gvr.RowIndex].Value);
                    Hace hc = new Hace(dni, codOf, cif, DateTime.Today.ToString("yyyy/dd/MM"));
                    int control = hc.nuevo();
                    if (control == 0)
                    {
                        mens.Text = "Ya está añadida!";
                    }
                    else
                    {
                        mens.Text = "correcto!Añadidas";
                    }
                }

            }
        }
    }
}