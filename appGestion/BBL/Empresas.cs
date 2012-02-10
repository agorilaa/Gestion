using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Empresas
    {
        private string cif;
        private string nombre;
        private string ciudad;
        private int nEmp;
        private string tipo;

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
        public string Ciudad
        {
            get
            {
                return this.ciudad;
            }
            set
            {
                this.ciudad = value;
            }
        }
        public int NEmp
        {
            get
            {
                return this.nEmp;
            }
            set
            {
                this.nEmp = value;
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

        //Métodos

        public Empresas(string vcif, string vnombre, string vciudad, int vnEmp, string vtipo) 
        {
            this.cif = vcif;
            this.nombre = vnombre;
            this.ciudad = vciudad;
            this.nEmp = vnEmp;
            this.tipo = vtipo;
        }
    }
}