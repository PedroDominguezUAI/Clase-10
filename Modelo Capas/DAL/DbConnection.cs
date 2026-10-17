using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DAL
{
    public class DbConnection
    {
        public string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConexionParcial"].ConnectionString;
        }

    }
}
