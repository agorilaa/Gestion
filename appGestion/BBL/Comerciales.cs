using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Comerciales
    {
        private string dni;
        private string nombre;
        private string apellido;
        private DateTime fecha;
        private string dir;
        private string dnij;

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
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
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
        public string Dir
        {
            get
            {
                return this.dir;
            }
            set
            {
                this.dir = value;
            }
        }
        public string Dnij
        {
            get
            {
                return this.dnij;
            }
            set
            {
                this.dnij = value;
            }
        }

        //Métodos
        public Comerciales(string vdni, string vnombre, string vapellido, DateTime vfecha, string vdir, string vdnij)
        {
            this.dni=vdni;
            this.nombre = vnombre;
            this.apellido = vapellido;
            this.fecha = vfecha;
            this.dir = vdir;
            this.dnij = vdnij;
        }
    }
}