using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Potenciales:Empresas
    {
        private string sector;

        public string Sector
        {
            get
            {
                return this.sector;
            }
            set
            {
                this.sector = value;
            }
        }
        //Métodos
        public Potenciales(string vsector, string vcif, string vnombre, string vciudad, int vnEmp, string vtipo)
            : base(vcif, vnombre, vciudad, vnEmp, vtipo)
        {
            this.sector = vsector;
        }
    }
}