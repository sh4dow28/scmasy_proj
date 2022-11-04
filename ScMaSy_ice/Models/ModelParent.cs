using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ScMaSy_ice.Database;

namespace ScMaSy_ice.Models
{
    public class ModelParent:dbConnection
    {
        public int _id { get; set; }
        public string pa_code { get; set; }
        public string pa_name { get; set; }
        public string pa_phone_no { get; set; }
        public string pa_adresse { get; set; }
        public string pa_occupation { get; set; }

        public bool Save()
        {
            bool saved = false;
            int nbRowAffected = 0;
            
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "";
                    cmd.Connection = connection;

                    nbRowAffected = cmd.ExecuteNonQuery();
                    if(nbRowAffected > 0)
                    {
                        saved = true;
                    }
                }
                connection.Close();
            }
            return saved;
        }
    }
}
