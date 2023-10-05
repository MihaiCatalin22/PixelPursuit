using Class_Library.Classes;
using Class_Library.Controllers;
using Class_Library.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Pages_Web_App.Pages
{
	public class IndexModel : PageModel
	{
		private UserController userController = new(new UserDAL());
		private readonly ILogger<IndexModel> _logger;

		[BindProperty]
		public User LoggedUser { get; private set; }
		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			string username = HttpContext.User.Identity.Name;

			ViewData["Message"] = username;

			LoggedUser = userController.GetUserFromUsername(username);

		}
	}
}