using Class_Library.Classes;
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
	public class BanDAL //: /*IBanManagement*/

	{
		public string CONNECTION_STRING = "Server = mssqlstud.fhict.local; Database = dbi500157_dbindivid; User Id = dbi500157_dbindivid; Password = individual;";

		//	public bool Create(Ban ban)
		//	{
		//		try
		//		{
		//			using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
		//			{
		//				string sql = "INSERT INTO Ban (StartDate, EndDate, Reason, BannedUserID, AdminID) VALUES (@startDate, @endDate, @reason, @bannedUserId, @adminId)";

		//				using (SqlCommand cmd = new SqlCommand(sql, conn))
		//				{
		//					cmd.Parameters.AddWithValue("@startDate", ban.StartDate.ToDateTime(TimeOnly.MinValue));
		//					cmd.Parameters.AddWithValue("@endDate", ban.EndDate.ToDateTime(TimeOnly.MinValue));
		//					cmd.Parameters.AddWithValue("@reason", ban.Reason);
		//					cmd.Parameters.AddWithValue("@bannedUserId", ban.User.Id);
		//					cmd.Parameters.AddWithValue("@adminId", ban.Admin.Id);


		//					conn.Open();
		//					int result = cmd.ExecuteNonQuery();

		//					if (result < 0) return false;
		//				}

		//			}
		//			return true;
		//		}
		//		catch (Exception ex)
		//		{
		//			return false;
		//		}
		//	}

		//	public Ban[] ReadAll()
		//	{
		//		try
		//		{
		//			UserController userController = new UserController(new UserDAL());
		//			List<Ban> bans = new();
		//			using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
		//			{
		//				string sql = "SELECT * FROM Ban";

		//				using (SqlCommand cmd = new SqlCommand(sql, conn))
		//				{
		//					conn.Open();
		//					SqlDataReader dr = cmd.ExecuteReader();

		//					while (dr.Read())
		//					{
		//						int userId = Convert.ToInt32(dr[4]);
		//						int adminId = Convert.ToInt32(dr[5]);

		//						User user = userController.GetUserFromId(userId);
		//						User admin = userController.GetUserFromId(adminId);

		//						bans.Add(new Ban(Convert.ToInt32(dr[0]), DateOnly.FromDateTime(Convert.ToDateTime(dr[1])), DateOnly.FromDateTime(Convert.ToDateTime(dr[2])), dr[3].ToString(), user, admin));
		//					}
		//				}

		//			}
		//			return bans.ToArray();
		//		}
		//		catch (Exception ex)
		//		{
		//			return null;
		//		}
		//	}

		//	public Ban[] ReadAllSearch(string search)
		//	{
		//		try
		//		{
		//			UserController userController = new UserController(new UserDAL());
		//			List<Ban> bans = new();
		//			using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
		//			{
		//				string sql = "SELECT * FROM Ban AS b INNER JOIN [User] AS u ON b.BannedUserId = u.Id WHERE u.Username LIKE @search";

		//				using (SqlCommand cmd = new SqlCommand(sql, conn))
		//				{
		//					cmd.Parameters.AddWithValue("@search", "%" + search + "%");
		//					conn.Open();
		//					SqlDataReader dr = cmd.ExecuteReader();

		//					while (dr.Read())
		//					{
		//						int userId = Convert.ToInt32(dr[4]);
		//						int adminId = Convert.ToInt32(dr[5]);

		//						User user = userController.GetUserFromId(userId);
		//						User admin = userController.GetUserFromId(adminId);

		//						bans.Add(new Ban(Convert.ToInt32(dr[0]), DateOnly.FromDateTime(Convert.ToDateTime(dr[1])), DateOnly.FromDateTime(Convert.ToDateTime(dr[2])), dr[3].ToString(), user, admin));
		//					}
		//				}

		//			}
		//			return bans.ToArray();
		//		}
		//		catch (Exception ex)
		//		{
		//			return null;
		//		}
		//	}
		//}
		//}
	}
}