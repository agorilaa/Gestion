using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using appGestion.DAL;
using System.Data;
using System.Data.Odbc;


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

        public Empresas(string ccif, string cnombre, string cciudad, int cnEmp, string ctipo) 
        {
            this.cif = ccif;
            this.nombre = cnombre;
            this.ciudad = cciudad;
            this.nEmp = cnEmp;
            this.tipo = ctipo;
        }
        public static DataTable listarEmpresas(string query)
        {
            BaseDatos bd = new BaseDatos();
            bd.abrirConexion();
            return bd.executeReader(query);
        }
        public int NuevaEmpresa(string dni)
        {
            
                string query = "insert into empresas values ('" + this.cif + "', '" + this.nombre + "', '" + this.ciudad + "', " + this.nEmp + ", '" + this.tipo + "');";
                BaseDatos bd = new BaseDatos();
                bd.abrirConexion();
                int control = bd.executeNonQuery(query);
                query = "insert into comemp values ('"+this.cif+"', '"+dni+"');";
                control = bd.executeNonQuery(query);
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