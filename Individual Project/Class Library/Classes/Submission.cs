using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Classes
{
    public class Submission
    {
        public int Id { get; set; }
        public User User { get; private set; }
        public Game Game { get; private set; }
        public DateOnly Date { get; private set; }
        public TimeSpan TotalTime { get; private set; }
        public EnumPlatform Platform { get; private set; }

        public Submission()
        {

        }
        public Submission(User user, Game game, DateOnly date, TimeSpan time, EnumPlatform platform )
        {
            User = user;
            Game = game;
            Date = date;
            TotalTime = time;
            Platform = platform;
        }
        public Submission(int id, User user, Game game, DateOnly date, TimeSpan time, EnumPlatform platform)
        {
            Id = id;
            User = user;
            Game = game;
            Date = date;
            TotalTime = time;
            Platform = platform;
        }
    }
}
