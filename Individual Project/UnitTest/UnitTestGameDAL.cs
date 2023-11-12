using Class_Library.Classes;
using Class_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace UnitTest
{
    public class UnitTestGameDAL : UnitTestBaseDAL, IGameManagement
    {
        public bool Create(Game game)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "INSERT INTO Game (Name, Company, ReleaseDate, TrailerLink, NumberOfRuns, NumberOfPlayers, BestTimeHours, BestTimeMinutes, BestTimeSeconds, TotalTimeHours, TotalTimeMinutes, TotalTimeSeconds, Genres, Platforms, PictureLink, BackgroundPictureLink) VALUES (@name, @company, @releaseDate, @trailerLink, @numberOfRuns, @numberOfPlayers, @bestTimeHours, @bestTimeMinutes, @bestTimeSeconds, @totalTimeHours, @totalTimeMinutes, @totalTimeSeconds, @genres, @platforms, @pictureLink, @backgroundPictureLink)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", game.Name);
                        cmd.Parameters.AddWithValue("@company", game.Company);
                        cmd.Parameters.AddWithValue("@releaseDate", game.ReleaseDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@trailerLink", game.TrailerLink);
                        cmd.Parameters.AddWithValue("@numberOfRuns", game.NumberOfRuns);
                        cmd.Parameters.AddWithValue("@numberOfPlayers", game.NumberOfPlayers);
                        cmd.Parameters.AddWithValue("@bestTimeHours", game.BestTime.Hours);
                        cmd.Parameters.AddWithValue("@bestTimeMinutes", game.BestTime.Minutes);
                        cmd.Parameters.AddWithValue("@bestTimeSeconds", game.BestTime.Seconds);
                        cmd.Parameters.AddWithValue("@totalTimeHours", game.TotalTime.Hours);
                        cmd.Parameters.AddWithValue("@totalTimeMinutes", game.TotalTime.Minutes);
                        cmd.Parameters.AddWithValue("@totalTimeSeconds", game.TotalTime.Seconds);
                        cmd.Parameters.AddWithValue("@genres", game.Genres);
                        cmd.Parameters.AddWithValue("@platforms", game.Platforms);
                        cmd.Parameters.AddWithValue("@pictureLink", game.PictureLink);
                        cmd.Parameters.AddWithValue("@backgroundPictureLink", game.BackgroundPictureLink);

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

        public Game? ReadById(int id)
        {
            try
            {
                Game game = null;
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Game WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            int bestHours = Convert.ToInt32(dr[7]);
                            int bestMinutes = Convert.ToInt32(dr[8]);
                            int bestSeconds = Convert.ToInt32(dr[9]);
                            int totalHours = Convert.ToInt32(dr[10]);
                            int totalMinutes = Convert.ToInt32(dr[11]);
                            int totalSeconds = Convert.ToInt32(dr[12]);

                            TimeSpan bestTime = new TimeSpan(bestHours, bestMinutes, bestSeconds);
                            TimeSpan totalTime = new TimeSpan(totalHours, totalMinutes, totalSeconds);

                            game = new Game(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[3])), dr[4].ToString(), Convert.ToInt32(dr[5]), Convert.ToInt32(dr[6]), bestTime, totalTime, dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString());
                        }

                    }

                }
                return game;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Game[] ReadAll()
        {
            try
            {
                List<Game> games = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Game ORDER BY Name";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int bestHours = Convert.ToInt32(dr[7]);
                            int bestMinutes = Convert.ToInt32(dr[8]);
                            int bestSeconds = Convert.ToInt32(dr[9]);
                            int totalHours = Convert.ToInt32(dr[10]);
                            int totalMinutes = Convert.ToInt32(dr[11]);
                            int totalSeconds = Convert.ToInt32(dr[12]);

                            TimeSpan bestTime = new TimeSpan(bestHours, bestMinutes, bestSeconds);
                            TimeSpan totalTime = new TimeSpan(totalHours, totalMinutes, totalSeconds);

                            Game game = new Game(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[3])), dr[4].ToString(), Convert.ToInt32(dr[5]), Convert.ToInt32(dr[6]), bestTime, totalTime, dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString());
                            games.Add(game);
                        }

                    }

                }
                return games.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Game[] ReadOnePageByName(int page, string name)
        {
            try
            {
                List<Game> games = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Game WHERE Name LIKE @name ORDER BY Name OFFSET @page ROWS FETCH FIRST 4 ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                        cmd.Parameters.AddWithValue("@page", page * 4);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int bestHours = Convert.ToInt32(dr[7]);
                            int bestMinutes = Convert.ToInt32(dr[8]);
                            int bestSeconds = Convert.ToInt32(dr[9]);
                            int totalHours = Convert.ToInt32(dr[10]);
                            int totalMinutes = Convert.ToInt32(dr[11]);
                            int totalSeconds = Convert.ToInt32(dr[12]);

                            TimeSpan bestTime = new TimeSpan(bestHours, bestMinutes, bestSeconds);
                            TimeSpan totalTime = new TimeSpan(totalHours, totalMinutes, totalSeconds);

                            Game game = new Game(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[3])), dr[4].ToString(), Convert.ToInt32(dr[5]), Convert.ToInt32(dr[6]), bestTime, totalTime, dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString());
                            games.Add(game);
                        }

                    }

                }
                return games.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Game[] ReadAllByName(string name)
        {
            try
            {
                List<Game> games = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Game WHERE Name LIKE @name ORDER BY Name";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int bestHours = Convert.ToInt32(dr[7]);
                            int bestMinutes = Convert.ToInt32(dr[8]);
                            int bestSeconds = Convert.ToInt32(dr[9]);
                            int totalHours = Convert.ToInt32(dr[10]);
                            int totalMinutes = Convert.ToInt32(dr[11]);
                            int totalSeconds = Convert.ToInt32(dr[12]);

                            TimeSpan bestTime = new TimeSpan(bestHours, bestMinutes, bestSeconds);
                            TimeSpan totalTime = new TimeSpan(totalHours, totalMinutes, totalSeconds);

                            Game game = new Game(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[3])), dr[4].ToString(), Convert.ToInt32(dr[5]), Convert.ToInt32(dr[6]), bestTime, totalTime, dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString());
                            games.Add(game);
                        }

                    }

                }
                return games.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Game[] ReadAllSearch(string name, string company)
        {
            try
            {
                List<Game> games = new();
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT * FROM Game WHERE Name LIKE @name AND Company LIKE @company";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                        cmd.Parameters.AddWithValue("@company", "%" + company + "%");

                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            int bestHours = Convert.ToInt32(dr[7]);
                            int bestMinutes = Convert.ToInt32(dr[8]);
                            int bestSeconds = Convert.ToInt32(dr[9]);
                            int totalHours = Convert.ToInt32(dr[10]);
                            int totalMinutes = Convert.ToInt32(dr[11]);
                            int totalSeconds = Convert.ToInt32(dr[12]);

                            TimeSpan bestTime = new TimeSpan(bestHours, bestMinutes, bestSeconds);
                            TimeSpan totalTime = new TimeSpan(totalHours, totalMinutes, totalSeconds);

                            Game game = new Game(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[3])), dr[4].ToString(), Convert.ToInt32(dr[5]), Convert.ToInt32(dr[6]), bestTime, totalTime, dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString());
                            games.Add(game);
                        }

                    }

                }
                return games.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool Update(Game game)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "UPDATE Game SET Name = @name, Company = @company, ReleaseDate = @releaseDate, TrailerLink = @trailerLink, NumberOfRuns = @numberOfRuns, NumberOfPlayers = @numberOfPlayers, BestTimeHours = @bestTimeHours, BestTimeMinutes = @bestTimeMinutes, BestTimeSeconds = @bestTimeSeconds, TotalTimeHours = @totalTimeHours, TotalTimeMinutes = @totalTimeMinutes, TotalTimeSeconds = @totalTimeSeconds, Genres = @genres, Platforms = @platforms, PictureLink = @pictureLink, BackgroundPictureLink = @backgroundPictureLink WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", game.ID);
                        cmd.Parameters.AddWithValue("@name", game.Name);
                        cmd.Parameters.AddWithValue("@company", game.Company);
                        cmd.Parameters.AddWithValue("@releaseDate", game.ReleaseDate.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@trailerLink", game.TrailerLink);
                        cmd.Parameters.AddWithValue("@numberOfRuns", game.NumberOfRuns);
                        cmd.Parameters.AddWithValue("@numberOfPlayers", game.NumberOfPlayers);
                        cmd.Parameters.AddWithValue("@bestTimeHours", game.BestTime.Hours);
                        cmd.Parameters.AddWithValue("@bestTimeMinutes", game.BestTime.Minutes);
                        cmd.Parameters.AddWithValue("@bestTimeSeconds", game.BestTime.Seconds);
                        cmd.Parameters.AddWithValue("@totalTimeHours", game.TotalTime.Hours);
                        cmd.Parameters.AddWithValue("@totalTimeMinutes", game.TotalTime.Minutes);
                        cmd.Parameters.AddWithValue("@totalTimeSeconds", game.TotalTime.Seconds);
                        cmd.Parameters.AddWithValue("@genres", game.Genres);
                        cmd.Parameters.AddWithValue("@platforms", game.Platforms);
                        cmd.Parameters.AddWithValue("@pictureLink", game.PictureLink);
                        cmd.Parameters.AddWithValue("@backgroundPictureLink", game.BackgroundPictureLink);

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

        public bool Delete(Game game)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "DELETE FROM Game WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", game.ID);

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

        public int GetTotalPages(int count)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "Select CEILING(@count/ (4 * 1.0)) FROM Game";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@count", count);

                        conn.Open();
                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public bool UserPlayedBefore(User user, Game game)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
                {
                    string sql = "SELECT s.* FROM Game AS g INNER JOIN Submission AS s ON g.Id = s.GameID INNER JOIN [User] AS u ON s.MemberID = u.Id WHERE s.GameID = @gameId AND s.MemberID = @memberId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@gameId", game.ID);
                        cmd.Parameters.AddWithValue("@memberId", user.Id);

                        conn.Open();
                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        if (result > 0)
                            return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
