using Class_Library.Interfaces;
using Class_Library.Classes;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace Class_Library.DAL
{
    public class UserDAL : IUserManagement
    {
        public string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Datbase = dbi500157_dbindivid; User Id = dbi500157_dbindivid; Password = individual";
        public bool Create(User user)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO [User] (Username, Password, Email, RegistrationDate, Bio, Banned, IsAdmin) VALUES (@username, @password, @email, @registrationDate, @bio, @banned, @isAdmin)";

                    using (SqlCommand cmd = new SqlCommand(sql,conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@registrationDate", user.RegistrationDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@bio", user.Bio);
                        cmd.Parameters.AddWithValue("@banned", user.Banned);
                        cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }
                }
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        public bool Update(User user) 
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE [User] SET Username = @username, Password = @password, Email = @email, Bio = @bio, Banned = @banned WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(sql,conn))
                    {
                        cmd.Parameters.AddWithValue("@id", user.Id);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@bio", user.Bio);
                        cmd.Parameters.AddWithValue("@banned", user.Banned);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(User user)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM [User] WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", user.Id);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result < 0) return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public User[] ReadAll()
        {
            try
            {
                List<User> users = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM [User]";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            users.Add(new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), Convert.ToBoolean(dr[7]), Convert.ToBoolean(dr[8])));
                        }
                    }
                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public User[] ReadAllUsers()
        {
            try
            {
                List<User> users = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM [User] WHERE IsAdmin = @isAdmin";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@isAdmin", false);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            users.Add(new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), Convert.ToBoolean(dr[7]), Convert.ToBoolean(dr[8])));
                        }
                    }
                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public User[] ReadAllUsersSearch(string search)
        {
            try
            {
                List<User> users = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM [User] WHERE IsAdmin = @isAdmin AND (Username LIKE @search OR Email LIKE @search)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                        cmd.Parameters.AddWithValue("@isAdmin", false);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            users.Add(new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), Convert.ToBoolean(dr[7]), Convert.ToBoolean(dr[8])));
                        }
                    }
                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public User[] ReadAllAdmins()
        {
            try
            {
                List<User> users = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM [User] WHERE IsAdmin = @isAdmin";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@isAdmin", true);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            users.Add(new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), Convert.ToBoolean(dr[7]), Convert.ToBoolean(dr[8])));
                        }
                    }
                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public User? GetUserFromUsername(string username)
        {
            try
            {
                User user = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM [User] WHERE Username = @username";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            user = new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), Convert.ToBoolean(dr[7]), Convert.ToBoolean(dr[8]));
                        }
                    }
                }
                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public User? GetUserFromId(int id)
        {
            try
            {
                User user = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM [User] WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if(dr.Read())
                        {
                            user = new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), Convert.ToBoolean(dr[7]), Convert.ToBoolean(dr[8]));
                        }
                    }
                }
                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
