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
            User loggedInUser = null;

            if (LoginInfo.Contains("@"))
            {
                loggedInUser = loginController.LoginEmail(LoginInfo, Password);
                if (loggedInUser != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, loggedInUser.Username),
                        new Claim(ClaimTypes.Role, "LoggedIn"),
                    };

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = RememberMe,
                        ExpiresUtc = DateTime.UtcNow.AddMonths(1),
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), authProperties);

                    return RedirectToPage("Index");
                }
                ModelState.AddModelError(string.Empty, "Wrong email or password.");
                return Page();
            }
            else
            {
                loggedInUser = loginController.LoginUsername(LoginInfo, Password);
                if (loggedInUser != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, loggedInUser.Username),
                        new Claim("id", loggedInUser.Id.ToString()),
                    };

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = RememberMe,
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), authProperties);

                    return RedirectToPage("Index");

                }
                ModelState.AddModelError(string.Empty, "Wrong username or password.");
                return Page();
            }
        }
    }
}
