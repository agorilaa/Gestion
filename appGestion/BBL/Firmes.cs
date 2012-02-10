using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Firmes
    {
        private string cif;

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
        //Métodos
        public Firmes(string vcif)
        {
            this.cif = vcif;
        }
    }
}