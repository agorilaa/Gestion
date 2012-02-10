using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Tlfemp
    {
        private string cif;
        private int tlf;

        public string Cif
        {
            get 
            {
                return this.cif;
            }
            set 
            {
                this.cif=value;
            }
        }
        public int Tlf
        {
            get
            {
                return this.tlf;
            }
            set
            {
                this.tlf = value;
            }
        }
        //Métodos
        public Tlfemp(string vcif, int vtlf)
        {
            this.cif = vcif;
            this.tlf = vtlf;
        }
    }
}