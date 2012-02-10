using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Ofertas
    {
        private int codO;
        private string nombre;
        private string descr;
        private string tipo;
        private string ambito;
        private string estado;
        private int coste;

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
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Descr
        {
            get
            {
                return this.descr;
            }
            set
            {
                this.descr = value;
            }
        }
        public string Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public string Ambito
        {
            get
            {
                return this.ambito;
            }
            set
            {
                this.ambito = value;
            }
        }
        public string Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public int Coste
        {
            get
            {
                return this.coste;
            }
            set
            {
                this.coste = value;
            }
        }
        //Métodos
        public Ofertas(int vcodO, string vnombre, string vdescr, string vtipo, string vambito, string vestado, int vcoste)
        {
            this.codO = vcodO;
            this.nombre = vnombre;
            this.descr = vdescr;
            this.tipo = vtipo;
            this.ambito = vambito;
            this.estado = vestado;
            this.coste = vcoste;
        }
    }
}