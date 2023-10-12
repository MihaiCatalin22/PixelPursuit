using Class_Library.Classes;
using Class_Library.Controllers;
using Class_Library.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Razor_Pages_Web_App.Pages
{
    public class ProfileModel : PageModel
    {
        public ProfileModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [BindProperty]
        public User LoggedUser { get; set; }

        [BindProperty]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please supply an email with at least 3 characters!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        private UserController userController = new(new UserDAL());
   
        [BindProperty]
        [MaxLength(100, ErrorMessage = "Bio cannot be longer than 100 characters!")]
        public string Bio { get; set; }

        [BindProperty]
        public string UsernameColor { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        private IWebHostEnvironment _environment;


        public void OnGet()
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;

            LoggedUser = userController.GetUserFromUsername(username);

        }

        public IActionResult OnPost()
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;
            LoggedUser = userController.GetUserFromUsername(username);

            LoggedUser.Email = Email;
            LoggedUser.Bio = Bio;
            LoggedUser.UsernameColor = UsernameColor;

            userController.Update(LoggedUser);
            return Page();
        }

        public IActionResult OnPostDelete()
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;
            LoggedUser = userController.GetUserFromUsername(username);

            userController.Delete(LoggedUser);
            HttpContext.Session.Clear();

            return RedirectToPage("/Index");
        }

        public async Task<IActionResult> OnPostImageAsync()
        {

            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;
            LoggedUser = userController.GetUserFromUsername(username);

            Email = LoggedUser.Email;
            Bio = LoggedUser.Bio;
            UsernameColor = LoggedUser.UsernameColor;

            if (Image != null)
            {
                var index = Image.FileName.LastIndexOf(".");
                var extension = Image.FileName.Substring(index);

                List<string> extensions = new List<string> { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };

                if (extensions.Contains(extension))
                {
                    var fileName = GetUniqueName(Image.FileName);
                    var uploads = Path.Combine(_environment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploads, fileName);
                    Image.CopyTo(new FileStream(filePath, FileMode.Create));

                    LoggedUser.ProfilePicture = fileName;

                    userController.Update(LoggedUser);
                }
                else
                {
                    ViewData["Error"] = "Invalid file type.";
                }

            }
            return Page();
        }

        private string GetUniqueName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }
    }
}

