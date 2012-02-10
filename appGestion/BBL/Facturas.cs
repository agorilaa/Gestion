using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Facturas
    {
        private int numf;
        private string cif;
        private string concepto;
        private string formpago;
        private DateTime fecha;
        private int total;
        private int codO;

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
        public string Concepto
        {
            get
            {
                return this.concepto;
            }
            set
            {
                this.concepto = value;
            }
        }
        public string Formpago
        {
            get
            {
                return this.formpago;
            }
            set
            {
                this.formpago = value;
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
        public int Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
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
        //Métodos
        public Facturas(int vnumf, string vcif, string vconcepto, string vformPago, DateTime vfecha, int vtotal, int vcodO)
        {
            this.numf = vnumf;
            this.cif = vcif;
            this.concepto = vconcepto;
            this.formpago = vformPago;
            this.fecha = vfecha;
            this.total = vtotal;
            this.codO = vcodO;
        }
    }
}