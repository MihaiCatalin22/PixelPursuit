﻿using Class_Library.Classes;
using Class_Library.Interfaces;
using Class_Library.Controllers;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;

namespace Class_Library.DAL
{
	public class BanDAL : BaseDAL, IBanManagement

	{
		public bool Create(Ban ban)
		{
			try
			{
				using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
				{
                    string sql = "INSERT INTO Ban (StartDate, EndDate, Reason, BannedUserID, AdminID, IsActive) VALUES (@startDate, @endDate, @reason, @bannedUserId, @adminId, @isActive)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@startDate", ban.StartDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@endDate", ban.EndDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@reason", ban.Reason);
                        cmd.Parameters.AddWithValue("@bannedUserId", ban.User.Id);
                        cmd.Parameters.AddWithValue("@adminId", ban.Admin.Id);
                        cmd.Parameters.AddWithValue("@isActive", true);

                        conn.Open();
						int result = cmd.ExecuteNonQuery();

						if (result < 0) return false;
					}
                    UserDAL userDAL = new UserDAL();
                    userDAL.UpdateUserBanStatus(ban.User.Id, true);
                }
				return true;
			}
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in Create method: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error in Create method: {ex.Message}");
                return false;
            }
        }

		public Ban[] ReadAll()
		{
			try
			{
				UserController userController = new UserController(new UserDAL());
				List<Ban> bans = new();
				using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
				{
					string sql = "SELECT * FROM Ban";

					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						conn.Open();
						SqlDataReader dr = cmd.ExecuteReader();

						while (dr.Read())
						{
                            int id = dr.GetInt32(0);
                            DateOnly startDate = DateOnly.FromDateTime(dr.GetDateTime(1));
                            DateOnly endDate = DateOnly.FromDateTime(dr.GetDateTime(2));
                            string reason = dr.GetString(3);
                            int userId = dr.GetInt32(4);
                            int adminId = dr.GetInt32(5);
                            bool isActive = dr.GetBoolean(6);

                            User user = userController.GetUserFromId(userId);
                            User admin = userController.GetUserFromId(adminId);

                            bans.Add(new Ban(id, startDate, endDate, reason, user, admin, isActive));
                        }
					}

				}
				return bans.ToArray();
			}
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in ReadAll method: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error in ReadAll method: {ex.Message}");
                return null;
            }
        }

		public Ban[] ReadAllSearch(string search)
		{
			try
			{
				UserController userController = new UserController(new UserDAL());
				List<Ban> bans = new();
				using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
				{
					string sql = "SELECT * FROM Ban AS b INNER JOIN [User] AS u ON b.BannedUserId = u.Id WHERE u.Username LIKE @search";

					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@search", "%" + search + "%");
						conn.Open();
						SqlDataReader dr = cmd.ExecuteReader();

						while (dr.Read())
						{
                            int id = dr.GetInt32(0);
                            DateOnly startDate = DateOnly.FromDateTime(dr.GetDateTime(1));
                            DateOnly endDate = DateOnly.FromDateTime(dr.GetDateTime(2));
                            string reason = dr.GetString(3);
                            int userId = dr.GetInt32(4);
                            int adminId = dr.GetInt32(5);
                            bool isActive = dr.GetBoolean(6);

                            User user = userController.GetUserFromId(userId);
                            User admin = userController.GetUserFromId(adminId);

                            bans.Add(new Ban(id, startDate, endDate, reason, user, admin, isActive));
                        }
					}

				}
				return bans.ToArray();
			}
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in ReadAllSearch method: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error in ReadAllSearch method: {ex.Message}");
                return null;
            }
        }
		public bool Update(Ban ban)
		{
			try
			{
				using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
				{
					string sql = "UPDATE Ban SET IsActive = @isActive WHERE Id = @banId";

					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@isActive", ban.IsActive);
						cmd.Parameters.AddWithValue("@banId", ban.Id);

						conn.Open();
						int result = cmd.ExecuteNonQuery();
                        Console.WriteLine("Updated rows: " + result);
                        return result > 0;
					}
				}
			}
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in Update method: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error in Update method: {ex.Message}");
                return false;
            }
        }
		public bool Delete(Ban ban)
		{
			try
			{
				using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
				{
					string sql = "DELETE FROM Ban WHERE Id = @banId";

					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@banId", ban.Id);

						conn.Open();
						int result = cmd.ExecuteNonQuery();

						return result > 0;
					}
				}
			}
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in Update method: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error in Update method: {ex.Message}");
                return false;
            }
        }
		public bool IsUserCurrentlyBanned(int userId)
		{
			try 
			{
				using (var connection = new SqlConnection(CONNECTION_STRING))
				{
					string query = "SELECT COUNT(*) FROM Ban WHERE BannedUserID = @BannedUserID AND IsActive = 1";
					using (var command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@BannedUserID", userId);
						connection.Open();
						int count = (int)command.ExecuteScalar();
						return count > 0;
					}
				}
			}
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error in IsUserCurrentlyBanned method: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error in IsUserCurrentlyBanned method: {ex.Message}");
                return false;
            }

        }
	}
}