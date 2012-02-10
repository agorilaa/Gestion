using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Facser
    {
        private int numf;
        private string cif;
        private int codS;

        public int Numf
        {
            get
            {
                return this.numf;
            }
            set
            {
                this.numf = value;
            }
        }
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
        public int CodS
        {
            get
            {
                return this.codS;
            }
            set
            {
                this.codS = value;
            }
        }
        //Métodos
        public Facser(int vnumf, string vcif, int vcodS) 
        {
            this.numf = vnumf;
            this.cif = vcif;
            this.codS = vcodS;
        }
    }
}