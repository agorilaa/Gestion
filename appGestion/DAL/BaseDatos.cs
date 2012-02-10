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
            this.comd = new OdbcCommand();
            this.comd.Connection=conex;
        }
        public void queryBdReader(string query, string col1)        //Para sólo una columna
        {
            this.comd.CommandText = query;
            this.dataReader = this.comd.ExecuteReader();
            while (DataReader.Read())
            { 
                Console.WriteLine(this.dataReader[col1]);
            }
            
        }


        public void queryBdAdapter()
        { 
            
        }

        public void cerrarConexion()
        {
            this.conex.Close();
        }
    }
}