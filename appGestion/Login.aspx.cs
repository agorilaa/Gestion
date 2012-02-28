using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appGestion.BBL;

namespace appGestion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Entrar_Click(object sender, EventArgs e)
        {
            Comerciales user = new Comerciales(tbUsuario.Text, tbPassw.Text);
            string usu = user.buscarComerciales(tbUsuario.Text, tbPassw.Text);
            if (usu != "0")
            {
                Session["dni"] = tbUsuario.Text;
                Session["nom"] = usu;
                Response.Redirect("/IU/index.aspx");
            }
            else
            {
                error.Text = "Los datos no son correctos";
            }
        }
    }
}