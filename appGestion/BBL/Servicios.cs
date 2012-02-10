using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Servicios
    {
        private int codS;
        private string titulo;
        private string descr;
        private int coste;
        private bool astlf;

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
        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
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
        public bool Astlf
        {
            get
            {
                return this.astlf;
            }
            set
            {
                this.astlf = value;
            }
        }
        //Métodos
        public Servicios(int vcodS, string vtitulo, string vdescr, int vcoste, bool vastlf)
        {
            this.codS = vcodS;
            this.titulo = vtitulo;
            this.descr = vdescr;
            this.coste = vcoste;
            this.astlf = vastlf;
        }
    }
}