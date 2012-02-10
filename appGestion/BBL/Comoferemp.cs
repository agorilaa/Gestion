using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Comoferemp
    {
        private string dni;
        private int codO;
        private string cif;
        private DateTime fecha;

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
        public int CodO
        {
            get
            {
                return this.codO;
            }
            set
            {
                this.codO = value;
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
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }
        //Métodos
        public Comoferemp(string vdni, int vcodO, string vcif, DateTime vfecha)
        {
            this.dni = vdni;
            this.codO = vcodO;
            this.cif = vcif;
            this.fecha = vfecha;
        }
    }
}