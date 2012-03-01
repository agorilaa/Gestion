using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using appGestion.DAL;

namespace appGestion.BBL
{
    public class Hace
    {
        private string dni;
        private int codO;
        private string cif;
        private string fecha;

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
        public string Fecha
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
        public Hace(string vdni, int vcodO, string vcif, string vfecha)
        {
            this.dni = vdni;
            this.codO = vcodO;
            this.cif = vcif;
            this.fecha = vfecha;
        }

        public int nuevo()
        {
            string query = "insert into hace values ('"+this.dni+"', "+this.codO+", '"+this.cif+"', '"+this.fecha+"');";
            BaseDatos bd = new BaseDatos();
            bd.abrirConexion();
            int control = bd.executeNonQuery(query);
            bd.cerrarConexion();
            if (control == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}