using Class_Library.Classes;
using Class_Library.DAL;
using Class_Library.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;

namespace Razor_Pages_Web_App.Pages
{
    public class GamesModel : PageModel
    {
        [BindProperty]
        public Game[] GamePage { get; set; }
        public Game[] GameList { get; set; }
        private GameController gameController = new(new GameDAL());
        public int ID { get; private set; } = 0;
        public int Count { get; set; }
        public int pageSize = 8;
        [BindProperty]
        public string SearchQuery { get; set; }
        public int TotalPages { get; set; }
        public IActionResult OnGet(int id)
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;
            ID = id;
            GameList = gameController.ReadAllByName(SearchQuery);
            Count = GameList.Count();
            GamePage = gameController.ReadOnePageByName(ID, SearchQuery);
            TotalPages = gameController.GetTotalPages(Count);

            if (ID >= TotalPages)
            {
                return RedirectToPage("/Games");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(int id)
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;
            GameList = gameController.ReadAllByName(SearchQuery);
            Count = GameList.Count();
            GamePage = gameController.ReadOnePageByName(ID, SearchQuery);
            TotalPages = gameController.GetTotalPages(Count);

            if (ID >= TotalPages)
            {
                return RedirectToPage("/Games");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPostClear()
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;
            return RedirectToPage("/Games");
        }
    }
}
