using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appGestion.IU
{
    public partial class appGesion : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Today.ToString("d");
        }
        public static System.Web.UI.Control FindControl(string controlID, System.Web.UI.Control control)
        {
            if (control.ID == controlID)
                return control;
            else
            {
                foreach (System.Web.UI.Control ctrl in control.Controls)
                {
                    System.Web.UI.Control searchedControl = FindControl(controlID, ctrl);
                    if (searchedControl != null)
                        return searchedControl;
                }
                return null;
            }
        }
    }
}