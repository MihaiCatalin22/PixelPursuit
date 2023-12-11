using Class_Library.Controllers;
using Class_Library.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace Razor_Pages_Web_App.Pages
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Please supply a username or an email with at least 4 characters!")]
        public string LoginInfo { get; set; }

        [BindProperty]
        [Required]
        [MinLength(4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [BindProperty]
        public bool RememberMe { get; set; }

        private LoginController loginController = new();

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            User loggedInUser = LoginInfo.Contains("@") ? LoginByEmail() : LoginByUsername();

            if (loggedInUser != null)
            {
                if (loginController.IsUserBanned(loggedInUser.Username))
                {
                    ModelState.AddModelError(string.Empty, "Your account is currently banned.");
                    return Page();
                }
                await SignInUser(loggedInUser);
                return RedirectToPage("Index");
            }

            ModelState.AddModelError(string.Empty, "Invalid login credentials or you are currently banned.");
            return Page();
        }
        private User LoginByEmail()
        {
            User user = loginController.LoginEmail(LoginInfo, Password);
            if (user == null)
            {
                ModelState.AddModelError("LoginFailed", "Email not found or password is incorrect.");
            }
            return user;
        }

        private User LoginByUsername()
        {
            User user = loginController.LoginUsername(LoginInfo, Password);
            if (user == null)
            {
                ModelState.AddModelError("LoginFailed", "Username not found or password is incorrect.");
            }
            return user;
        }

        private async Task SignInUser(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, "LoggedIn"),
            };

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = RememberMe,
                ExpiresUtc = DateTime.UtcNow.AddDays(30),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), authProperties);
        }
    }
}
