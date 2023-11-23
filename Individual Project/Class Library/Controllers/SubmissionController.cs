using Class_Library.Classes;
using Class_Library.DAL;
using Class_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Controllers
{
    public class SubmissionController
    {
        private ISubmissionManagement submissionManager;
        public SubmissionController()
        {

        }
        public SubmissionController(ISubmissionManagement _submissionManager)
        {
            submissionManager = _submissionManager;
        }
        public bool Create(RankedSubmission submission)
        {
            if (submission != null)
                return submissionManager.Create(submission);
            return false;
        }
        public bool Create(UnrankedSubmission submission)
        {
            if (submission != null && submissionManager.Create(submission))
            {
                var game = new GameController(new GameDAL()).ReadByID(submission.Game.ID);
                if (game != null)
                {
                    // Update TotalTime
                    game.TotalTime = game.TotalTime.Add(submission.TotalTime);

                    // Check and Update BestTime
                    if (game.BestTime == TimeSpan.MaxValue || submission.TotalTime < game.BestTime)
                    {
                        game.BestTime = submission.TotalTime;
                    }

                    // Update the game
                    new GameController(new GameDAL()).Update(game);
                    return true;
                }
            }
            return false;
        }
        public Submission[] ReadRecent(string username)
        {
            return submissionManager.ReadRecent(username);
        }
        public Submission[] ReadRecent(int userId)
        {
            return submissionManager.ReadRecent(userId);
        }
        public UnrankedSubmission[] ReadByGame(int gameId, string username)
        {
            return submissionManager.ReadByGame(gameId, username);
        }
        public UnrankedSubmission[] ReadByUser(int userId)
        {
            return submissionManager.ReadByUser(userId);
        }
        public RankedSubmission ReadRanked(int id)
        {
            return submissionManager.ReadRanked(id);
        }
        public RankedSubmission[] ReadRankedByUser(int userId)
        {
            return submissionManager.ReadRankedByUser(userId);
        }
        public RankedSubmission[] ReadPendingAdmin(int pendingSearch, string usernameSearch, string gameSearch, string platformSearch)
        {
            return submissionManager.ReadPendingAdmin(pendingSearch, usernameSearch, gameSearch, platformSearch);
        }
        public RankedSubmission[] ReadApprovedAdmin(int approvedSearch, string usernameSearch, string gameSearch, string platformSearch)
        {
            return submissionManager.ReadApprovedAdmin(approvedSearch, usernameSearch, gameSearch, platformSearch);
        }
        public RankedSubmission[] ReadRankedByGame(int gameId, string username)
        {
            return submissionManager.ReadRankedByGame(gameId, username);
        }
        public bool UpdateRanked(RankedSubmission submission)
        {
            if (submission != null)
                return submissionManager.UpdateRanked(submission);
            return false;
        }
        public bool Delete(RankedSubmission submission)
        {
            if (submission != null)
            {
                int game = submission.Game.ID;
                int rank = submission.Rank;
                foreach(RankedSubmission s in ReadRankedByGame(game, ""))
                {
                    if (s.Rank < rank)
                    {
                        s.Rank++;
                        submissionManager.UpdateRanked(s);
                    }
                }
                return submissionManager.Delete(submission);
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="submission"></param>
        /// <returns></returns>
        public int CalculateRank(RankedSubmission submission)
        {
            if (submission != null)
            {
                int rank = PredictRank(submission)[0];
                int pos = PredictRank(submission)[1];
                int gameId = submission.Game.ID;

                RankedSubmission[] submissions = ReadRankedByGame(gameId, "");

                for (int i = pos; i < submissions.Count(); i++)
                {
                    submissions[i].Rank++;
                    submissionManager.UpdateRanked(submissions[i]);
                }
                return rank;
            }
            return 0;
        }
        public int[] PredictRank(RankedSubmission submission)
        {
            int[] results = new int[2];
            results[0] = 0;
            results[1] = 0;

            if (submission != null)
            {
                int gameId = submission.Game.ID;
                TimeSpan time = submission.TotalTime;
                RankedSubmission[] submissions = ReadRankedByGame(gameId, "");
                results[0] = submissions.Count() + 1;
                results[1] = submissions.Count() + 1;
                for (int pos = 0; pos < submissions.Count(); pos++)
                {
                    if (submissions[pos].TotalTime >= time)
                    {
                        results[0] = submissions[pos].Rank;
                        results[1] = pos;
                        return results;
                    }
                }
            }
            return results;
        }
    }
}
