using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Classes
{
    public class RankedSubmission : Submission
    {
        public bool Approved { get; set; }
        public bool Pending { get; set; }
        public string Link { get; set; }
        public int Rank { get; set; }

        public RankedSubmission()
        {

        }
        public RankedSubmission(User user, Game game, DateOnly date, TimeSpan time, EnumPlatform platform, string link): base(user, game, date, time, platform)
        {
            Approved = false;
            Pending = true;
            Link = link;
            Rank = 0;
        }
        public RankedSubmission(int id, User user, Game game, DateOnly date, TimeSpan time, EnumPlatform platform, bool approved, bool pending, string link, int rank) : base(id, user, game, date, time, platform)
        {
            Approved = approved;
            Pending = pending;
            Link = link;
            Rank = rank;
        }
    }
}
