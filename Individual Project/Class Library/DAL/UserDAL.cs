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
    public class UserDAL : BaseDAL, IUserManagement
    {
        public bool Create(User user)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO [User] (Username, Password, Salt, Email, RegistrationDate, UsernameColor, ProfilePicture, Bio, Banned, IsAdmin) VALUES (@username, @password, @salt, @email, @registrationDate, @usernameColor, @profilePicture, @bio, @banned, @isAdmin)";

                    string salt = HashPassword.GenerateSalt();
                    user.Password = HashPassword.GenerateHashedPassword(user.Password, salt);

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@salt", salt);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@registrationDate", user.RegistrationDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@usernameColor", user.UsernameColor);
                        cmd.Parameters.AddWithValue("@profilePicture", user.ProfilePicture);
                        cmd.Parameters.AddWithValue("@bio", user.Bio ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@banned", user.Banned ?? (object)DBNull.Value);
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
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool Update(User user)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE [User] SET Username = @username, Password = @password, Email = @email, UsernameColor = @usernameColor, ProfilePicture = @profilePicture, Bio = @bio, Banned = @banned WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", user.Id);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@usernameColor", user.UsernameColor);
                        cmd.Parameters.AddWithValue("@profilePicture", user.ProfilePicture);
                        cmd.Parameters.AddWithValue("@bio", user.Bio ?? (object)DBNull.Value);
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
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
                            users.Add(new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), Convert.ToBoolean(dr[9]), Convert.ToBoolean(dr[10])));
                        }
                    }

                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                            users.Add(new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), Convert.ToBoolean(dr[9]), Convert.ToBoolean(dr[10])));
                        }
                    }

                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                            users.Add(new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), Convert.ToBoolean(dr[9]), Convert.ToBoolean(dr[10])));
                        }
                    }

                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                            users.Add(new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), Convert.ToBoolean(dr[9]), Convert.ToBoolean(dr[10])));
                        }
                    }

                }
                return users.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }       

        public string? GetSalt(User user)
        {
            try
            {
                string salt = string.Empty;
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT Salt FROM [User] Where Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", user.Id);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            salt = dr[0].ToString();
                        }
                    }

                }
                return salt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                            user = new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), Convert.ToBoolean(dr[9]), Convert.ToBoolean(dr[10]));
                        }
                    }

                }
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

                        if (dr.Read())
                        {
                            user = new User(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5])), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), Convert.ToBoolean(dr[9]), Convert.ToBoolean(dr[10]));
                        }
                    }

                }
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
