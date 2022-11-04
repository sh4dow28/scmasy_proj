using ScMaSy_ice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScMaSy_ice.MyClass
{
    public class UserModel : dbConnection
    {
        // Fields
        private int id;
        private string us_code;
        private string us_name;
        private string us_username;
        private string us_password;
        private string us_status;
        private string us_role;
        private DateTime us_created_at;
        private DateTime us_deleted_at;
        private string us_created_by;
        private int us_group;

        public UserModel(string aCode, string aName, string aUsername, string aPassword, string aStatus, string aRole, DateTime createdAt, DateTime deletedAt, string createdBy, int aGroup)
        {
            this.us_code = aCode;
            this.us_name = aName;
            this.us_username = aUsername;
            this.us_password = aPassword;
            this.us_status = aStatus;
            this.us_role = aRole;
            this.us_created_at = createdAt;
            this.us_deleted_at = deletedAt;
            this.us_created_by = createdBy;
            this.us_group = aGroup;
        }

        // Empty constructor
        public UserModel()
        {
            this.us_code = "";
            this.us_name = "";
            this.us_username = "";
            this.us_password = "";
            this.us_status = "";
            this.us_role = "";
        }

        // Check if user already exist
        public bool UserAlreadyExist()
        {
            return true;
        }
        // CREATE user
        public bool CreateUser()
        {
            return true;
        }
        // Authentification
        public bool Auth(string aUsername, string aPassword)
        {
            if((!string.IsNullOrEmpty(aUsername)) && (!string.IsNullOrEmpty(aPassword)))
            {
                // TODO : Check if user alredy exist in database
                using(var connection = GetConnection())
                {
                    connection.Open();
                    using(var command = connection.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT " +
                            "us_code," +
                            "us_name," +
                            "us_username," +
                            "us_password," +
                            "us_status," +
                            "us_role," +
                            "us_created_at," +
                            "us_created_by," +
                            "us_deleted_at," +
                            "us_group " +
                            "FROM tbl_user " +
                            "WHERE us_username=@name" +
                            " AND us_password=@pwd";
                        command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = aUsername;
                        command.Parameters.Add("@pwd", System.Data.SqlDbType.NVarChar).Value = aPassword;

                        using(var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.us_code = reader[0].ToString();
                                this.us_name = reader[1].ToString();
                                this.us_username = aUsername;
                                this.us_status = reader[4].ToString();
                                this.us_created_at = DateTime.Parse(reader[6].ToString());
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            else
            {
                return true;
            }
        }
        // Update user info
        public bool UpdateUser()
        {
            return true;
        }
        // Delete user
        public bool DeleteUser()
        {
            return true;
        }
        // List all users
        public void GetAllUser()
        {

        }
        // Get user by code
        public void GetUserByCode(string aCode)
        {

        }
        // Get user by username
        public void GetUserByUsername(string aUsername)
        {

        }

        public int Id { get => id; set => id = value; }
        public string Us_code { get => us_code; set => us_code = value; }
        public string Us_name { get => us_name; set => us_name = value; }
        public string Us_username { get => us_username; set => us_username = value; }
        public string Us_password { get => us_password; set => us_password = value; }
        public string Us_status { get => us_status; set => us_status = value; }
        public string Us_role { get => us_role; set => us_role = value; }
        public DateTime Us_created_at { get => us_created_at; set => us_created_at = value; }
        public DateTime Us_deleted_at { get => us_deleted_at; set => us_deleted_at = value; }
        public string Us_created_by { get => us_created_by; set => us_created_by = value; }
        public int Us_group { get => us_group; set => us_group = value; }
    }
}
