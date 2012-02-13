using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Firmes:Empresas
    {
        //Métodos
        public Firmes(string vcif, string vnombre, string vciudad, int vnEmp, string vtipo):base(vcif, vnombre, vciudad, vnEmp, vtipo)
        {
            
        }
    }
}