using System;
using System.Collections.Generic;
using System.Text;

using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;

namespace AbstractFactoryPattern.Database
{
    public class OleDBDatabase : Database
    {
        private DbConnection _Connection = null;

        private DbCommand _Command = null;


        public override DbConnection Connection {
            get
            {
                if(_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OledbConnectionString"].ConnectionString;
                    //_Connection = new oledbc(connectionString);
                }
                return _Connection;
            }
            set
            {
                _Connection = value;
            }
        }
    }
}
