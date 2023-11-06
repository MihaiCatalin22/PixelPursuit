using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Class_Library.DAL;
using Class_Library.Classes;
using Class_Library.Controllers;
namespace Razor_Pages_Web_App.Pages
{
    public class GameDetailsModel : PageModel
    {
        [BindProperty]
        public Game Game { get; set; }
        [BindProperty]
        public bool Banned { get; set; } = true;
        [BindProperty]
        public User User { get; set; }
        private GameController gameController = new(new GameDAL());
        private SubmissionController submissionController = new(new SubmissionDAL());
        private UserController userController = new(new UserDAL());
        [BindProperty]
        public RankedSubmission[] rankedSubmissions { get; set; }
        [BindProperty]
        public UnrankedSubmission[] unrankedSubmissions { get; set; }
        [BindProperty]
        public int Type { get; set; } = 1;
        public static int type = 1;
        [BindProperty]
        public int Id {  get; set; }
        [BindProperty]
        public string Query { get; set; } = "";
        public static string query = "";
        public IActionResult OnGet(int id)
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;
            Id = id;
            Query = "";

            if (username != null)
            {
                User = userController.GetUserFromUsername(username);
                Banned = (bool)User.Banned;
            }
            Game = gameController.ReadByID(Id);

            if (Game == null)
            {
                TempData["Message"] = "Game does not exist.";
                return RedirectToPage("/Games");
            }

            if (Type == 1)
            {
                rankedSubmissions = submissionController.ReadRankedByGame(Id, Query);
            }
            else
            {
                unrankedSubmissions = submissionController.ReadByGame(Id, Query);
            }
            return Page();
        }

        public IActionResult OnPost(int id, int type, string query)
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;
            Id = id;
            Type = type;
            if (query == null)
            {
                Query = "";
            }
            else
            {
                Query = query;
            }

            if (username != null)
            {
                User = userController.GetUserFromUsername(username);
                Banned = (bool)User.Banned;
            }
            Game = gameController.ReadByID(Id);

            if (Game == null)
            {
                TempData["Message"] = "Game does not exist.";
                return RedirectToPage("/Games");
            }
            rankedSubmissions = submissionController.ReadRankedByGame(Id, Query);
            unrankedSubmissions = submissionController.ReadByGame(Id, Query);
            return Page();
        }
		public IActionResult OnPostClear(int id)
		{
			string username = HttpContext.User.Identity.Name;

			ViewData["Message"] = username;

			Id = id;
			Query = "";

			if (username != null)
			{
				User = userController.GetUserFromUsername(username);

				Banned = (bool)User.Banned;
			}
			Game = gameController.ReadByID(Id);

			if (Game == null)
			{
				TempData["Message"] = "Game does not exist!";
				return RedirectToPage("/Games");
			}

			if (Type == 1)
			{
				rankedSubmissions = submissionController.ReadRankedByGame(Id, Query);
			}
			else
			{
				unrankedSubmissions = submissionController.ReadByGame(Id, Query);
			}
			return Page();
		}
	}
}
