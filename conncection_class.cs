using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;

namespace adr.myclass
{
    internal class connection_class
    {
        public MySqlConnection connectdb;

        public connection_class()
        {

            string host = "localhost";
            string database = "new_schema";
            string username = "root";
            string password = "";
            string port = "3306";

            string connection_string = "datasource =" + host + ";database=" + database + "; port=" + port + "; username=" + username + ";" + "password=" + password + "; SslMode =none; ";

            connectdb = new MySqlConnection(connection_string);

        }


    }
}