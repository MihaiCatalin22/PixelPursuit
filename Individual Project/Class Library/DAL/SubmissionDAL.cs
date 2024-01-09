using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Class_Library.Classes;
using Class_Library.Interfaces;
using Class_Library.Controllers;
using System.Data;

namespace Class_Library.DAL
{
    public class SubmissionDAL : BaseDAL, ISubmissionManagement
    {
        public bool Create(RankedSubmission submission)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Submission (UserID, GameID, Date, Hours, Minutes, Seconds, Platform, ApprovedState, PendingState, Link, Rank, TAS, Glitchless, AnyPercent) VALUES (@userID, @gameID, @date, @hours, @minutes, @seconds, @platform, @approvalState, @pendingState, @link, @rank, @tas, @glitchless, @anypercent)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", submission.User.Id);
                        cmd.Parameters.AddWithValue("@gameID", submission.Game.ID);
                        cmd.Parameters.AddWithValue("@date", submission.Date.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@hours", submission.TotalTime.Hours);
                        cmd.Parameters.AddWithValue("@minutes", submission.TotalTime.Minutes);
                        cmd.Parameters.AddWithValue("@seconds", submission.TotalTime.Seconds);
                        cmd.Parameters.AddWithValue("@platform", submission.Platform.ToString());
                        cmd.Parameters.AddWithValue("@approvalState", submission.Approved);
                        cmd.Parameters.AddWithValue("@pendingState", submission.Pending);
                        cmd.Parameters.AddWithValue("@link", submission.Link);
                        cmd.Parameters.AddWithValue("@rank", submission.Rank);
                        cmd.Parameters.AddWithValue("@tas", DBNull.Value);
                        cmd.Parameters.AddWithValue("@glitchless", DBNull.Value);
                        cmd.Parameters.AddWithValue("@anypercent", DBNull.Value);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;

                        if (result > 0)
                        {
                            GameDAL gameDAL = new GameDAL();
                            Game game = gameDAL.ReadById(submission.Game.ID);
                            if (game != null)
                            {
                                game.TotalTime = game.TotalTime.Add(submission.TotalTime);
                                if (game.BestTime > submission.TotalTime || game.BestTime == TimeSpan.Zero)
                                {
                                    game.BestTime = submission.TotalTime;
                                }

                                game.NumberOfRuns++;
                                if (!gameDAL.UserPlayedBefore(submission.User, game))
                                {
                                    game.NumberOfPlayers++;
                                }
                                gameDAL.Update(game);
                            }
                        }
                    }

                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in Create(RankedSubmission): " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in Create(RankedSubmission): " + ex.Message);
                return false;
            }
        }

        public bool Create(UnrankedSubmission submission)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Submission (UserID, GameID, Date, Hours, Minutes, Seconds, Platform, ApprovedState, PendingState, Link, Rank, TAS, Glitchless, AnyPercent) VALUES (@userID, @gameID, @date, @hours, @minutes, @seconds, @platform, @approvalState, @pendingState, @link, @rank, @tas, @glitchless, @anypercent)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", submission.User.Id);
                        cmd.Parameters.AddWithValue("@gameID", submission.Game.ID);
                        cmd.Parameters.AddWithValue("@date", submission.Date.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@hours", submission.TotalTime.Hours);
                        cmd.Parameters.AddWithValue("@minutes", submission.TotalTime.Minutes);
                        cmd.Parameters.AddWithValue("@seconds", submission.TotalTime.Seconds);
                        cmd.Parameters.AddWithValue("@platform", submission.Platform.ToString());
                        cmd.Parameters.AddWithValue("@approvalState", DBNull.Value);
                        cmd.Parameters.AddWithValue("@pendingState", DBNull.Value);
                        cmd.Parameters.AddWithValue("@link", DBNull.Value);
                        cmd.Parameters.AddWithValue("@rank", DBNull.Value);
                        cmd.Parameters.AddWithValue("@tas", submission.TAS);
                        cmd.Parameters.AddWithValue("@glitchless", submission.Glitchless);
                        cmd.Parameters.AddWithValue("@anypercent", submission.AnyPercent);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;

                        if (result > 0)
                        {
                            GameDAL gameDAL = new GameDAL();
                            Game game = gameDAL.ReadById(submission.Game.ID);
                            if (game != null)
                            {
                                game.TotalTime = game.TotalTime.Add(submission.TotalTime);
                                if (game.BestTime > submission.TotalTime || game.BestTime == TimeSpan.Zero)
                                {
                                    game.BestTime = submission.TotalTime;
                                }

                                game.NumberOfRuns++;
                                if (!gameDAL.UserPlayedBefore(submission.User, game))
                                {
                                    game.NumberOfPlayers++;
                                }
                                gameDAL.Update(game);
                            }
                        }
                    }

                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in Create(UnrankedSubmission): " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in Create(UnrankedSubmission): " + ex.Message);
                return false;
            }
        }
        public bool UpdateRanked(RankedSubmission submission)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Submission SET ApprovedState = @approvedState, PendingState = @pendingState, Rank = @rank WHERE Id = @id";


                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", submission.Id);
                        cmd.Parameters.AddWithValue("@approvedState", submission.Approved);
                        cmd.Parameters.AddWithValue("@pendingState", submission.Pending);
                        cmd.Parameters.AddWithValue("@rank", submission.Rank);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in UpdateRanked: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in UpdateRanked: " + ex.Message);
                return false;
            }
        }
        public bool Delete(RankedSubmission submission)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM Submission WHERE Id = @id ";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", submission.Id);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0) return false;
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in Delete(RankedSubmission): " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in Delete(RankedSubmission): " + ex.Message);
                return false;
            }
        }
        public Submission[] ReadRecent(string username)
        {
            try
            {
                UserController userController = new(new UserDAL());
                GameController gameController = new(new GameDAL());
                List<Submission> submissions = new List<Submission>();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Submission AS s INNER JOIN [User] AS u ON s.UserID = u.Id WHERE u.Username LIKE @username ORDER BY s.Date DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", $"%{username}%");

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = dr.GetInt32("Id");
                            int userId = dr.GetInt32("UserID");
                            int gameId = dr.GetInt32("GameID");
                            DateOnly date = DateOnly.FromDateTime(dr.GetDateTime("Date"));
                            int hours = dr.GetInt32("Hours");
                            int minutes = dr.GetInt32("Minutes");
                            int seconds = dr.GetInt32("Seconds");
                            string p = dr.GetString("Platform");
                            EnumPlatform platform;
                            Enum.TryParse(p, out platform);

                            User user = userController.GetUserFromId(userId);
                            Game game = gameController.ReadByID(gameId);

                            TimeSpan time = new TimeSpan(hours, minutes, seconds);

                            submissions.Add(new Submission(id, user, game, date, time, platform));
                        }
                    }
                }
                return submissions.ToArray();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in ReadRecent: " + ex.Message);
                return new Submission[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadRecent: " + ex.Message);
                return new Submission[0];
            }
        }

        public Submission[] ReadRecent(int userId)
        {
            try
            {
                UserController userController = new(new UserDAL());
                GameController gameController = new(new GameDAL());
                List<Submission> submissions = new List<Submission>();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Submission WHERE UserID = @userId ORDER BY Date DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = dr.GetInt32("Id");
                            int gameId = dr.GetInt32("GameID");
                            DateOnly date = DateOnly.FromDateTime(dr.GetDateTime("Date"));
                            int hours = dr.GetInt32("Hours");
                            int minutes = dr.GetInt32("Minutes");
                            int seconds = dr.GetInt32("Seconds");
                            string p = dr.GetString("Platform");
                            EnumPlatform platform;
                            Enum.TryParse(p, out platform);

                            User user = userController.GetUserFromId(userId);
                            Game game = gameController.ReadByID(gameId);

                            TimeSpan time = new TimeSpan(hours, minutes, seconds);

                            submissions.Add(new Submission(id, user, game, date, time, platform));
                        }
                    }
                }
                return submissions.ToArray();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in ReadRecent: " + ex.Message);
                return new Submission[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadRecent: " + ex.Message);
                return new Submission[0];
            }
        }

        public UnrankedSubmission[] ReadByGame(int gameId, string username)
        {
            try
            {
                UserController userController = new(new UserDAL());
                GameController gameController = new(new GameDAL());
                List<UnrankedSubmission> submissions = new List<UnrankedSubmission>();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Submission AS s INNER JOIN [User] AS u ON s.UserID = u.Id WHERE s.GameID = @gameId AND u.Username LIKE @username AND TAS IS NOT NULL ORDER BY s.Date DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@gameId", gameId);
                        cmd.Parameters.AddWithValue("@username", $"%{username}%");

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = dr.GetInt32("Id");
                            int userId = dr.GetInt32("UserID");
                            DateOnly date = DateOnly.FromDateTime(dr.GetDateTime("Date"));
                            int hours = dr.GetInt32("Hours");
                            int minutes = dr.GetInt32("Minutes");
                            int seconds = dr.GetInt32("Seconds");
                            string p = dr.GetString("Platform");
                            EnumPlatform platform;
                            Enum.TryParse(p, out platform);
                            bool tas = dr.GetBoolean("TAS");
                            bool glitchless = dr.GetBoolean("Glitchless");
                            bool anypercent = dr.GetBoolean("AnyPercent");

                            User user = userController.GetUserFromId(userId);
                            Game game = gameController.ReadByID(gameId);

                            TimeSpan time = new TimeSpan(hours, minutes, seconds);

                            submissions.Add(new UnrankedSubmission(id, user, game, date, time, platform, tas, glitchless, anypercent));
                        }
                    }
                }
                return submissions.ToArray();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in ReadByGame: " + ex.Message);
                return new UnrankedSubmission[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadByGame: " + ex.Message);
                return new UnrankedSubmission[0];
            }
        }

        public UnrankedSubmission[] ReadByUser(int userId)
        {
            try
            {
                UserController userController = new(new UserDAL());
                GameController gameController = new(new GameDAL());
                List<UnrankedSubmission> submissions = new List<UnrankedSubmission>();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Submission WHERE UserId = @userId AND TAS IS NOT NULL ORDER BY Date DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = dr.GetInt32("Id");
                            int gameId = dr.GetInt32("GameID");
                            DateOnly date = DateOnly.FromDateTime(dr.GetDateTime("Date"));
                            int hours = dr.GetInt32("Hours");
                            int minutes = dr.GetInt32("Minutes");
                            int seconds = dr.GetInt32("Seconds");
                            string p = dr.GetString("Platform");
                            EnumPlatform platform;
                            Enum.TryParse(p, out platform);
                            bool tas = dr.GetBoolean("TAS");
                            bool glitchless = dr.GetBoolean("Glitchless");
                            bool anypercent = dr.GetBoolean("AnyPercent");

                            User user = userController.GetUserFromId(userId);
                            Game game = gameController.ReadByID(gameId);

                            TimeSpan time = new TimeSpan(hours, minutes, seconds);

                            submissions.Add(new UnrankedSubmission(id, user, game, date, time, platform, tas, glitchless, anypercent));
                        }
                    }
                }
                return submissions.ToArray();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in ReadByUser: " + ex.Message);
                return new UnrankedSubmission[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadByUser: " + ex.Message);
                return new UnrankedSubmission[0];
            }
        }

        public RankedSubmission ReadRanked(int id)
        {
            try
            {
                UserController userController = new(new UserDAL());
                GameController gameController = new(new GameDAL());
                RankedSubmission submission = null;
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Submission WHERE Id = @id AND LINK IS NOT NULL";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            int userId = dr.GetInt32("UserID");
                            int gameId = dr.GetInt32("GameID");
                            DateOnly date = DateOnly.FromDateTime(dr.GetDateTime("Date"));
                            int hours = dr.GetInt32("Hours");
                            int minutes = dr.GetInt32("Minutes");
                            int seconds = dr.GetInt32("Seconds");
                            string p = dr.GetString("Platform");
                            EnumPlatform platform;
                            Enum.TryParse(p, out platform);
                            bool approved = dr.GetBoolean("ApprovedState");
                            bool pending = dr.GetBoolean("PendingState");
                            string link = dr.GetString("Link");
                            int rank = dr.GetInt32("Rank");

                            User user = userController.GetUserFromId(userId);
                            Game game = gameController.ReadByID(gameId);

                            TimeSpan time = new TimeSpan(hours, minutes, seconds);

                            submission = new RankedSubmission(id, user, game, date, time, platform, approved, pending, link, rank);
                        }
                    }
                }
                return submission;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in ReadRanked: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadRanked: " + ex.Message);
                return null;
            }
        }

        public RankedSubmission[] ReadPendingAdmin(int pendingSearch, string usernameSearch, string gameSearch, string platformSearch)
        {
            try
            {
                UserController userController = new(new UserDAL());
                GameController gameController = new(new GameDAL());
                List<RankedSubmission> submissions = new List<RankedSubmission>();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT s.* FROM Game AS g INNER JOIN Submission AS s ON g.Id = s.GameID INNER JOIN [User] AS u ON s.UserID = u.Id WHERE s.PendingState = @pending AND u.Username LIKE @username AND g.Name LIKE @game AND s.Platform LIKE @platform ORDER BY s.Date DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@pending", pendingSearch);
                        cmd.Parameters.AddWithValue("@username", $"%{usernameSearch}%");
                        cmd.Parameters.AddWithValue("@game", $"%{gameSearch}%");
                        cmd.Parameters.AddWithValue("@platform", $"%{platformSearch}%");

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = dr.GetInt32("Id");
                            int userId = dr.GetInt32("UserID");
                            int gameId = dr.GetInt32("GameID");
                            DateOnly date = DateOnly.FromDateTime(dr.GetDateTime("Date"));
                            int hours = dr.GetInt32("Hours");
                            int minutes = dr.GetInt32("Minutes");
                            int seconds = dr.GetInt32("Seconds");
                            string p = dr.GetString("Platform");
                            EnumPlatform platform;
                            Enum.TryParse(p, out platform);
                            bool approved = dr.GetBoolean("ApprovedState");
                            bool pending = dr.GetBoolean("PendingState");
                            string link = dr.GetString("Link");
                            int rank = dr.GetInt32("Rank");

                            User user = userController.GetUserFromId(userId);
                            Game game = gameController.ReadByID(gameId);

                            TimeSpan time = new TimeSpan(hours, minutes, seconds);

                            submissions.Add(new RankedSubmission(id, user, game, date, time, platform, approved, pending, link, rank));
                        }
                    }
                }
                return submissions.ToArray();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in ReadPendingAdmin: " + ex.Message);
                return new RankedSubmission[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadPendingAdmin: " + ex.Message);
                return new RankedSubmission[0];
            }
        }

        public RankedSubmission[] ReadApprovedAdmin(int approvedSearch, string usernameSearch, string gameSearch, string platformSearch)
        {
            try
            {
                UserController userController = new(new UserDAL());
                GameController gameController = new(new GameDAL());
                List<RankedSubmission> submissions = new List<RankedSubmission>();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT s.* FROM Game AS g INNER JOIN Submission AS s ON g.Id = s.GameID INNER JOIN [User] AS u ON s.UserID = u.Id WHERE s.ApprovedState = @approved AND u.Username LIKE @username AND g.Name LIKE @game AND s.Platform LIKE @platform ORDER BY s.Date DESC";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@approved", approvedSearch);
                        cmd.Parameters.AddWithValue("@username", $"%{usernameSearch}%");
                        cmd.Parameters.AddWithValue("@game", $"%{gameSearch}%");
                        cmd.Parameters.AddWithValue("@platform", $"%{platformSearch}%");

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = dr.GetInt32("Id");
                            int userId = dr.GetInt32("UserID");
                            int gameId = dr.GetInt32("GameID");
                            DateOnly date = DateOnly.FromDateTime(dr.GetDateTime("Date"));
                            int hours = dr.GetInt32("Hours");
                            int minutes = dr.GetInt32("Minutes");
                            int seconds = dr.GetInt32("Seconds");
                            string p = dr.GetString("Platform");
                            EnumPlatform platform;
                            Enum.TryParse(p, out platform);
                            bool approved = dr.GetBoolean("ApprovedState");
                            bool pending = dr.GetBoolean("PendingState");
                            string link = dr.GetString("Link");
                            int rank = dr.GetInt32("Rank");

                            User user = userController.GetUserFromId(userId);
                            Game game = gameController.ReadByID(gameId);

                            TimeSpan time = new TimeSpan(hours, minutes, seconds);

                            submissions.Add(new RankedSubmission(id, user, game, date, time, platform, approved, pending, link, rank));
                        }
                    }
                }
                return submissions.ToArray();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in ReadApprovedAdmin: " + ex.Message);
                return new RankedSubmission[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadApprovedAdmin: " + ex.Message);
                return new RankedSubmission[0];
            }
        }

        public RankedSubmission[] ReadRankedByGame(int gameId, string username)
        {
            try
            {
                UserController userController = new(new UserDAL());
                GameController gameController = new(new GameDAL());
                List<RankedSubmission> submissions = new List<RankedSubmission>();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Submission AS s INNER JOIN [User] AS u ON s.UserID = u.Id WHERE s.GameID = @gameId AND u.Username LIKE @username AND ApprovedState = 1 ORDER BY s.Rank";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@gameId", gameId);
                        cmd.Parameters.AddWithValue("@username", $"%{username}%");

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = dr.GetInt32("Id");
                            int userId = dr.GetInt32("UserID");
                            DateOnly date = DateOnly.FromDateTime(dr.GetDateTime("Date"));
                            int hours = dr.GetInt32("Hours");
                            int minutes = dr.GetInt32("Minutes");
                            int seconds = dr.GetInt32("Seconds");
                            string p = dr.GetString("Platform");
                            EnumPlatform platform;
                            Enum.TryParse(p, out platform);
                            bool approved = dr.GetBoolean("ApprovedState");
                            bool pending = dr.GetBoolean("PendingState");
                            string link = dr.GetString("Link");
                            int rank = dr.GetInt32("Rank");

                            User user = userController.GetUserFromId(userId);
                            Game game = gameController.ReadByID(gameId);

                            TimeSpan time = new TimeSpan(hours, minutes, seconds);

                            submissions.Add(new RankedSubmission(id, user, game, date, time, platform, approved, pending, link, rank));
                        }
                    }
                }
                return submissions.ToArray();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in ReadRankedByGame: " + ex.Message);
                return new RankedSubmission[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadRankedByGame: " + ex.Message);
                return new RankedSubmission[0];
            }
        }

        public RankedSubmission[] ReadRankedByUser(int userId)
        {
            try
            {
                UserController userController = new(new UserDAL());
                GameController gameController = new(new GameDAL());
                List<RankedSubmission> submissions = new List<RankedSubmission>();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Submission WHERE UserID = @userId AND Rank IS NOT NULL ORDER BY Date DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int id = dr.GetInt32("Id");
                            int gameId = dr.GetInt32("GameID");
                            DateOnly date = DateOnly.FromDateTime(dr.GetDateTime("Date"));
                            int hours = dr.GetInt32("Hours");
                            int minutes = dr.GetInt32("Minutes");
                            int seconds = dr.GetInt32("Seconds");
                            string p = dr.GetString("Platform");
                            EnumPlatform platform;
                            Enum.TryParse(p, out platform);
                            bool approved = dr.GetBoolean("ApprovedState");
                            bool pending = dr.GetBoolean("PendingState");
                            string link = dr.GetString("Link");
                            int rank = dr.GetInt32("Rank");

                            User user = userController.GetUserFromId(userId);
                            Game game = gameController.ReadByID(gameId);

                            TimeSpan time = new TimeSpan(hours, minutes, seconds);

                            submissions.Add(new RankedSubmission(id, user, game, date, time, platform, approved, pending, link, rank));
                        }
                    }
                }
                return submissions.ToArray();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Exception in ReadRankedByUser: " + ex.Message);
                return new RankedSubmission[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ReadRankedByUser: " + ex.Message);
                return new RankedSubmission[0];
            }
        }
    }
}
