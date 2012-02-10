using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Potenciales
    {
        private string cif;
        private string sector;

        public string Cif
        {
            get 
            {
                return this.cif;
            }
            set
            {
                this.cif = value;
            }
        }
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
        public Potenciales(string vcif, string vsector)
        {
            this.cif = vcif;
            this.sector = vsector;
        }
    }
}