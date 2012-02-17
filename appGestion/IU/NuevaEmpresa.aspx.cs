using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appGestion.BBL;

namespace appGestion.IU
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            int numeroEmp = int.Parse(numEmpBox.Text);
            Empresas emp = new Empresas(cifBox.Text, nomEmpBox.Text, ciudadBox.Text,numeroEmp,tipoLista.SelectedValue);
            int control = emp.NuevaEmpresa();
            if (control == 0)
            {
                Label1.Text = "Error de pk, no se puede insertar";
            }
            else
            {
                Label1.Text = "correcto!Añadida";
            }
            
        }
        
    }
}