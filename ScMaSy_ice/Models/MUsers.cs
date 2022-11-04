using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ScMaSy_ice.Database;

namespace ScMaSy_ice.Models
{
    public class MUsers:dbConnection
    {
		private int _id { get; set; }
		public string us_code { get; set; }
		public string us_name { get; set; }
		public string us_username { get; set; }
		public string us_password { get; set; }
		public string us_status { get; set; }
		public string us_role { get; set; }
		public DateTime us_created_at { get; set; }
		public DateTime us_deleted_at { get; set; }
		public string us_created_by { get; set; }
		public int us_group { get; set; }

		public bool ValidateUser()
        {
			bool check = false;
			SqlDataReader reader;
			using (var connection = GetConnection())
            {
				connection.Open();
				using(var command = new SqlCommand())
                {
					command.Connection = connection;
					command.CommandText = "SELECT * FROM tbl_user WHERE us_username=@uname AND us_password=@upassword";
					command.CommandType = CommandType.Text;

					// Add Parameters
					command.Parameters.Add("@uname", SqlDbType.NVarChar).Value = us_username;
					command.Parameters.Add("@upassword", SqlDbType.NVarChar).Value = us_password;


					reader = command.ExecuteReader();
                    while (reader.Read())
                    {
						check = true;
						// TODO : Get user infos...
						_id = reader.GetInt32(0);
						us_code = reader.GetString(1);
						us_name = reader.GetString(2);
						us_status = reader.GetString(5);
						us_role = reader.GetString(6);
						us_group = reader.GetInt32(10);

                    }

					connection.Close();
                }
            }

			return check;
        }

		
		public void Save()
        {
			int rowsAffected = 0;
			using(var connection = GetConnection())
            {
				connection.Open();
				using(var command = new SqlCommand())
                {
					command.Connection = connection;
					command.CommandText = "";
                    try
                    {
						rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

						rowsAffected = -2;
                    }
                }
            }
        }

		public void Delete()
        {
			int rowsAffected = 0;
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "";
					try
					{
						rowsAffected = command.ExecuteNonQuery();
					}
					catch (Exception)
					{

						rowsAffected = -2;
					}
				}
			}
		}

		public void Update()
        {
			int rowsAffected = 0;
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "";
					try
					{
						rowsAffected = command.ExecuteNonQuery();
					}
					catch (Exception)
					{

						rowsAffected = -2;
					}
				}
			}
		}
	}
}
