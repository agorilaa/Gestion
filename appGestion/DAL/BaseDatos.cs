using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Odbc;


namespace appGestion.DAL
{
    public class BaseDatos
    {
        private OdbcConnection conex;
        private OdbcCommand comd;
        private OdbcDataReader dataReader;
        private OdbcDataAdapter dataAdapter;
        private DataTable dt;

        public OdbcConnection Conex
        {
            get
            {
                return this.conex;
            }
            set 
            {
                this.conex = value;
            }
        }
        public OdbcCommand Comd
        {
            get
            {
                return this.comd;
            }
            set
            {
                this.comd = value;
            }
        }
        public OdbcDataReader DataReader
        {
            get
            {
                return this.dataReader;
            }
            set
            {
                this.dataReader = value;
            }
        }
        public OdbcDataAdapter DataAdapter
        {
            get
            {
                return this.dataAdapter;
            }
            set
            {
                this.dataAdapter = value;
            }
        }
        //Metodos
        public void abrirConexion()
        {
            this.conex = new OdbcConnection("DSN=gloria");
            this.conex.Open();
        }
        public DataTable executeReader(string query)        //Para sólo una columna
        {
            this.dataAdapter = new OdbcDataAdapter(query, conex);
            this.dt = new DataTable();
            this.dataAdapter.Fill(dt);
            return this.dt;
        }


        public int executeNonQuery(string query)
        {
            OdbcCommand comand = new OdbcCommand(query, conex);
            try
            {
                comand.ExecuteNonQuery();
                return 1;
            }
            catch (OdbcException e)
            {
                return 0;
            }
        }

        public string executeQuery(string query)
        {
            OdbcCommand comand = new OdbcCommand(query, conex);
            try
            {
                OdbcDataReader dataReader = comand.ExecuteReader();
                bool filas = dataReader.HasRows;
                if (filas == true)
                {
                    dataReader.Read();
                    string usu = (string)dataReader["nombre"];
                    return usu;
                }
                else
                {
                    return "0";
                }
            }
            catch (OdbcException e)
            {
                return "0";
            }
        }

        public void cerrarConexion()
        {
            this.conex.Close();
        }
    }
}