using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Classes
{
    public class UnrankedSubmission : Submission
    {
        public bool TAS {  get; set; }
        public bool Glitchless { get; set; }
        public bool AnyPercent { get; set; }

        public UnrankedSubmission()
        {

        }
        public UnrankedSubmission(int id, User user, Game game, DateOnly date, TimeSpan time, EnumPlatform platform, bool tas, bool glitchless, bool anypercent) : base(id, user, game, date, time, platform)
        {
            TAS = tas;
            Glitchless = glitchless;
            AnyPercent = anypercent;
        }
        public UnrankedSubmission(User user, Game game, DateOnly date, TimeSpan time, EnumPlatform platform, bool tas, bool glitchless, bool anypercent) : base(user, game, date, time, platform)
        {
            TAS = tas;
            Glitchless = glitchless;
            AnyPercent = anypercent;
        }
    }
}
