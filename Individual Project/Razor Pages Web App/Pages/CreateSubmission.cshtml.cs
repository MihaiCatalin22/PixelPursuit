using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Class_Library.Classes;
using Class_Library.DAL;
using Class_Library.Controllers;

namespace Razor_Pages_Web_App.Pages
{
    public class CreateSubmissionModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public int Type {  get; set; }
        [BindProperty]
        public User User { get; set; }
        [BindProperty]
        public Game Game { get; set; }
		[BindProperty]
		public string DateInput { get; set; }
        [BindProperty]
        public int Hours {  get; set; }
        [BindProperty]
        public int Minutes {  get; set; }
        [BindProperty]
        public int Seconds { get; set; }
        [BindProperty]
        public int Platform { get; set; }
        [BindProperty]
        public string Link { get; set; }
        [BindProperty]
        public bool TAS {  get; set; }
        [BindProperty]
        public bool Glitchless {  get; set; }
        [BindProperty]
        public bool AnyPercent {  get; set; }

        private GameController gameController = new(new GameDAL());
        private UserController userController = new(new UserDAL());
        private SubmissionController submissionController = new(new SubmissionDAL());
		public DateOnly Date
		{
			get
			{
				if (DateTime.TryParse(DateInput, out var dateTime))
				{
					return DateOnly.FromDateTime(dateTime);
				}
				return DateOnly.MinValue;
			}
		}
		public IActionResult OnGet(int id, int type)
        {
            Id = id;
            Type = type;

            string username = HttpContext.User.Identity.Name;

            ViewData["Message"] = username;

            User = userController.GetUserFromUsername(username);

            if (User.Banned == true)
            {
                TempData["Message"] = "You cannot create submissions as you are banned at the moment.";
                return RedirectToPage("./GameDetails", new { id = Id });
            }
            Game = gameController.ReadByID(Id);

            return Page();
        }
        public IActionResult OnPost(int id, int type)
        {
            Id = id;
            Type = type;

            string username = HttpContext.User.Identity.Name;

            ViewData["Message"] = username;

            User = userController.GetUserFromUsername(username);
            Game = gameController.ReadByID(id);

			if (DateTime.Parse(DateInput) > DateTime.Now)
			{
				TempData["Message"] = "Please select a date that is not in the future.";
				return Page();
			}
			if (Type == 1)
            {
                TimeSpan time = new TimeSpan(Hours, Minutes, Seconds);
                EnumPlatform platform = (EnumPlatform)Platform;
                RankedSubmission submission = new(User, Game, Date, time, platform, Link);
                submissionController.Create(submission);
                return RedirectToPage("./GameDetails", new { id = Id });
            }
            else
            {
                TimeSpan time = new TimeSpan(Hours, Minutes, Seconds);
                EnumPlatform platform = (EnumPlatform)Platform;
                UnrankedSubmission submission = new(User, Game, Date, time, platform, TAS, Glitchless, AnyPercent);
                submissionController.Create(submission);

                if (time < Game.BestTime)
                {
                    Game.BestTime = time;
                }
                Game.TotalTime = Game.TotalTime.Add(time);
                Game.NumberOfRuns++;
                if (!gameController.UserPlayedBefore(User, Game))
                {
                    Game.NumberOfPlayers++;
                }
                gameController.Update(Game);

                return RedirectToPage("./GameDetails", new {id = Id});
            }
        }

    }
}
