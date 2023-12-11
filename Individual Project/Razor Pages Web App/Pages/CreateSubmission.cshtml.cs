using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Class_Library.Classes;
using Class_Library.DAL;
using Class_Library.Controllers;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "Date is required.")]
        public string DateInput { get; set; }
        [BindProperty]
        [Range(-1, 72, ErrorMessage = "Hours must be between 0 and 72.")]
        public int Hours {  get; set; }
        [BindProperty]
        [Range(-1, 59, ErrorMessage = "Minutes must be between 0 and 59.")]
        public int Minutes {  get; set; }
        [BindProperty]
        [Range(-1, 59, ErrorMessage = "Seconds must be between 0 and 59.")]
        public int Seconds { get; set; }
        [BindProperty]
        public int Platform { get; set; }
        [BindProperty]
        [Url(ErrorMessage = "Please enter a valid URL.")]
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
            try
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
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"An error occurred: {ex.Message}");
                return Page();
            }        
        }
        public IActionResult OnPost(int id, int type)
        {
			try
			{
				Id = id;
				Type = type;

				string username = HttpContext.User.Identity.Name;
				ViewData["Message"] = username;

				User = userController.GetUserFromUsername(username);
				Game = gameController.ReadByID(id);

				if (User.Banned == true)
				{
					TempData["Message"] = "You cannot create submissions as you are banned at the moment.";
					return RedirectToPage("./GameDetails", new { id = Id });
				}

				if (DateTime.TryParse(DateInput, out var parsedDate))
				{
					if (parsedDate > DateTime.Now)
					{
						TempData["Message"] = "Please select a date that is not in the future.";
						return Page();
					}
				}
				else
				{
					TempData["Message"] = "Invalid date format.";
					return Page();
				}

                TimeSpan time = new TimeSpan(Hours, Minutes, Seconds);
                gameController.UpdateGameStats(Game, Hours, Minutes, Seconds);

                if (time.TotalSeconds <= 0)
				{
					TempData["Message"] = "Please enter a valid time for the speedrun.";
					return Page();
				}

				EnumPlatform platform = (EnumPlatform)Platform;

				if (Type == 1)
				{
					RankedSubmission submission = new(User, Game, DateOnly.FromDateTime(parsedDate), time, platform, Link);
					submissionController.Create(submission);
				}
				else
				{
					UnrankedSubmission submission = new(User, Game, DateOnly.FromDateTime(parsedDate), time, platform, TAS, Glitchless, AnyPercent);
					submissionController.Create(submission);
					UpdateGameStatistics(Game, time, User);
				}

				return RedirectToPage("./GameDetails", new { id = Id });
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", $"An error occurred: {ex.Message}");
				return Page();
			}
		}

		private void UpdateGameStatistics(Game game, TimeSpan time, User user)
		{
			if (time < game.BestTime || game.BestTime == TimeSpan.Zero)
			{
				game.BestTime = time;
			}
			game.TotalTime = game.TotalTime.Add(time);
			game.NumberOfRuns++;
			if (!gameController.UserPlayedBefore(user, game))
			{
				game.NumberOfPlayers++;
			}
			gameController.Update(game);
		}
	}
}
