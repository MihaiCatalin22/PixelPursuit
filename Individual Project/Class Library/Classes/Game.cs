using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Classes
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string Genres { get; set; }
        public string Platforms { get; set; }
        public string TrailerLink { get; set; }
        public int NumberOfRuns { get; set; }
        public int NumberOfPlayers { get; set; }
        public TimeSpan BestTime { get; set; }
        public TimeSpan TotalTime { get; set; }
        public string PictureLink { get; set; }
        public string BackgroundPictureLink { get; set; }
        public Game()
        {

        }

        public Game(int id, string name, string company, DateOnly releaseDate, string trailerLink, int noOfRuns, int noOfPlayers, TimeSpan bestTime, TimeSpan totalTime, string genres, string platforms, string pictureLink, string backgroundPictureLink)
        {
            ID = id;
            Name = name;
            Company = company;
            ReleaseDate = releaseDate;
            TrailerLink = trailerLink;
            Genres = genres;
            Platforms = platforms;
            NumberOfRuns = noOfRuns;
            NumberOfPlayers = noOfPlayers;
            BestTime = bestTime;
            TotalTime = totalTime;
            PictureLink = pictureLink;
            BackgroundPictureLink = backgroundPictureLink;
        }

        public Game(string name, string company, DateOnly releaseDate, string trailerLink, string genres, string platforms, string pictureLink, string backgroundPictureLink)
        {
            Name = name;
            Company = company;
            ReleaseDate = releaseDate;
            TrailerLink = trailerLink;
            Genres = genres;
            Platforms = platforms;
            NumberOfRuns = 0;
            NumberOfPlayers = 0;
            BestTime = TimeSpan.MinValue;
            TotalTime = TimeSpan.MinValue;
            PictureLink = pictureLink;
            BackgroundPictureLink = backgroundPictureLink;
        }
    }
}
