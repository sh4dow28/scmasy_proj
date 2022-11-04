using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ScMaSy_ice.Database
{
    public abstract class dbConnection:mySqlDbConnection
    {
        private readonly string connectionString;
        private SqlConnection _connection;
        
        public dbConnection()
        {
            // For SQL Server
            string host = "DESKTOP-QE28AJI\\SQLEXPRESS";
            string db = "ScMaSy_db";

            connectionString = "Data Source="+host+";DataBase="+db+";Integrated Security=True";
            _connection = new SqlConnection(connectionString);
            
        }
        // For SQL Server Connection
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public SqlConnection OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
            return _connection;
        }
        public SqlConnection CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
            return _connection;
        }
    }
}
