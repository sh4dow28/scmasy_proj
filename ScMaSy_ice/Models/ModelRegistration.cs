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
    public class ModelRegistration:dbConnection
    {
        public int _id { get; set; }
        public string re_ref { get; set; }
        public string re_type { get; set; }
        public DateTime re_created_at { get; set; }
        public string re_created_by { get; set; }
        public string student { get; set;}
        public string academic_year { get; set; }
        public string re_class { get; set; }

        public bool ToRegister()
        {
            bool registered = false;
            int nbRowAffected = 0;
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var cmd=new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO tbl_registration(" +
                        "re_ref," +
                        "re_type" +
                        "re_created_at" +
                        "re_created_by" +
                        "student" +
                        "academic_year" +
                        "class" +
                        "VALUES(" +
                        re_ref + "," + re_type + "," + re_created_at + "," + re_created_by + "," + student + "," + academic_year + "," + re_class + ")";
                    cmd.Connection = connection;

                    nbRowAffected = cmd.ExecuteNonQuery();
                    if(nbRowAffected > 0)
                        registered = true;
                }
                connection.Close();
            }
            return registered;
        }
    }
}
