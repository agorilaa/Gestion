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
            
        }
        protected internal void gvDataRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            foreach (GridViewRow gr in this.GridView1.Rows)
            {
                DropDownList tipo = (DropDownList)gr.FindControl("tipo");
                if (tipo != null)
                {
                    e.NewValues["Tipo"] = tipo.SelectedValue;
                }
            }

        }
    }
}