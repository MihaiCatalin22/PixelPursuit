using Class_Library.Classes;
using Class_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Controllers
{
    public class GameController
    {
        private IGameManagement gameManager;
        public GameController(IGameManagement _gameManager)
        {
            gameManager = _gameManager;
        }

        public bool Create(Game game)
        {
            try
            {
				if (game != null)
				{
					foreach (Game game1 in ReadAll())
					{
						if (game.ReleaseDate == game1.ReleaseDate && game.BestTime == game1.BestTime && game.TotalTime == game1.TotalTime && game.Name == game1.Name && game.Company == game1.Company && game.Genres == game1.Genres && game.Platforms == game1.Platforms && game.NumberOfPlayers == game1.NumberOfPlayers && game.NumberOfRuns == game1.NumberOfRuns && game.TrailerLink == game1.TrailerLink && game.PictureLink == game1.PictureLink && game.BackgroundPictureLink == game1.BackgroundPictureLink)
							return false;
					}
					return gameManager.Create(game);
				}
                return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error creating game: " + ex.Message);
				return false;
			}
		}
        public bool Delete(Game game)
        {
            if (game != null && ReadByID(game.ID) != null)
            {
                return gameManager.Delete(game);
            }
            return false;
        }
        public bool Update(Game game)
        {
            if (game != null && ReadByID(game.ID) != null)
            {
                return gameManager.Update(game);
            }
            return false;
        }
        public Game[] ReadAll()
        {
            return gameManager.ReadAll();
        }
        public Game? ReadByID(int id)
        {
            return gameManager.ReadById(id);
        }
        public Game[] ReadAllByName(string name)
        {
            return gameManager.ReadAllByName(name);
        }
        public Game[] ReadAllSearch(string game, string company)
        {
            return gameManager.ReadAllSearch(game, company);
        }
        public Game[] ReadOnePageByName(int page, string name)
        {
            return gameManager.ReadOnePageByName(page, name);
        }
        public int GetTotalPages(int pagesize)
        {
            return gameManager.GetTotalPages(pagesize);
        }
        public bool UserPlayedBefore(User user, Game game)
        {
            return gameManager.UserPlayedBefore(user, game);
        }
    }
}
