using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Razor_Pages_Web_App.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Your username or email should have at least 4 characters.")]
        public string LoginInfo { get; set; }
        [BindProperty]
        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [BindProperty]
        public bool RememberMe { get; set; }

        public void OnGet()
        {
        }
    }
}
