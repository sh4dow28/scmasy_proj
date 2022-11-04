using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ScMaSy_ice.Database
{
    public abstract class mySqlDbConnection
    {
        private readonly string ms_connectionString;
        private MySqlConnection _msConnection;

        public mySqlDbConnection()
        {
            // For MySQL connection
            string ms_host = "localhost";
            string ms_db = "ScMaSy_db";
            string ms_user = "scmasy_account";
            string ms_password = "scmasy_password";

            ms_connectionString = "Data Source=" + ms_host + ";Database=" + ms_db + ";username=" + ms_user + ";password=" + ms_password + "SslMode=none;";
            _msConnection = new MySqlConnection(ms_connectionString);
        }

        // For MySql Connection
        protected MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection(ms_connectionString);
        }

        public MySqlConnection OpenMySqlConnection()
        {
            if (_msConnection.State == ConnectionState.Closed)
                _msConnection.Open();
            return _msConnection;
        }
        public MySqlConnection CloseMySqlConnection()
        {
            if (_msConnection.State == ConnectionState.Open)
                _msConnection.Close();
            return _msConnection;
        }
    }
}
