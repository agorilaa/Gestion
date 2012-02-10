using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Comemp
    {
        private string cif;
        private string dni;

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
        public string Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        //Métodos
        public Comemp(string vcif, string vdni)
        {
            this.cif = vcif;
            this.dni = vdni;
        }
    }
}