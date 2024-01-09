using Class_Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Interfaces
{
    public interface IGameManagement 
    {
        public bool Create(Game game);
        public bool Update(Game game);
        public bool Delete(Game game);
        public Game? ReadById(int id);
        public Game[] ReadAll();
        public Game[] ReadOnePageByName(int page, string name);
        public Game[] ReadAllByName(string name);
        public Game[] ReadAllSearch(string name, string company);
        public int GetTotalPages(int pagesize);
        public bool UserPlayedBefore(User user, Game game);
    }
}
