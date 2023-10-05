using Class_Library.Classes;
using Class_Library.Controllers;
using Class_Library.DAL;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Razor_Pages_Web_App.Pages
{
	public class RegisterModel : PageModel
	{
		[BindProperty]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Your email address should have at least 3 characters.")]
		[Required]
		[RegularExpression(@"^[\w\.]+@([\w]+\.)+[\w]{2,4}$")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[BindProperty]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Your username should have at least 3 characters.")]
		[Required]
		public string Username { get; set; }

		[BindProperty]
		[MinLength(5, ErrorMessage = "Your password should have at least 5 characters.")]
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		private UserController userController = new(new UserDAL());

		public void OnGet()
		{
		}

		public async Task<IActionResult> OnPostAsync()
		{

			if (ModelState.IsValid)
			{
				User user = new User(Username, Password, Email, false);
				userController.Create(user);
				var claims = new List<Claim>
					{
						new Claim(ClaimTypes.Name, user.Username),
						new Claim(ClaimTypes.Role, "LoggedIn"),
					};

				var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

				await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

				return RedirectToPage("Login");
			}
			else
				return Page();
		}
	}
}
