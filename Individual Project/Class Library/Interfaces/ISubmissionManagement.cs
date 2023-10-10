using Class_Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Interfaces
{
    public interface ISubmissionManagement
    {
        public bool Create(RankedSubmission submission);
        public bool Create(UnrankedSubmission submission);
        public Submission[] ReadRecent(string username);
        public Submission[] ReadRecent(int userId);
        public UnrankedSubmission[] ReadByGame(int gameId, string username);
        public UnrankedSubmission[] ReadByUser(int userId);
        public RankedSubmission ReadRanked(int id);
        public RankedSubmission[] ReadRankedByUser(int userId);
        public RankedSubmission[] ReadPendingAdmin(int pendingSearch, string usernameSearch, string gameSearch, string platformSearch);
        public RankedSubmission[] ReadApprovedAdmin(int approvedSearch, string usernameSeach, string gameSearch, string platformSearch);
        public RankedSubmission[] ReadRankedByGame(int gameId, string username);
        public bool UpdateRanked(RankedSubmission submission);
        public bool Delete(RankedSubmission submission);

    }
}
