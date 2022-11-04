using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ScMaSy_ice.Database;
using ScMaSy_ice.Models;

namespace ScMaSy_ice.Models
{
    public class ModelStudent : dbConnection
    {
        public int _id { get; set; }
        public string st_rol_number { get; set; }
        public string st_lastname { get; set; }
        public string st_firstname { get; set;}
        public string st_gender { get; set; }
        public string st_phone { get; set; }
        public DateTime st_dob { get; set; }
        public string st_pob { get; set; }
        public string st_picture { get; set; }
        public string st_status { get; set; }
        public DateTime st_created_at { get; set; }

        public bool Registration()
        {
            bool registered = false;
            int nbRowAffected = 0;
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO tbl_student(" +
                        "st_rol_no," +
                        "st_lastname," +
                        "st_firstname," +
                        "st_gender," +
                        "st_phone," +
                        "st_dob," +
                        "st_pob," +
                        "st_picture," +
                        "st_status," +
                        "st_created_at) " +
                        "VALUES(" + st_rol_number + "," + st_lastname + "," + st_firstname + "," + st_gender + "," + st_phone + "," + st_dob + "," + st_pob + "," + st_picture + "," + st_status + "," + st_created_at + ")";
                    cmd.Connection = connection;
                    nbRowAffected = cmd.ExecuteNonQuery();
                    if(nbRowAffected > 0)
                        registered = true;

                    connection.Close();
                }
            }
            return registered;
        }
    }
}
