using Class_Library.Classes;
using Class_Library.Controllers;
using Class_Library.DAL;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
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

        public List<ProfileImage> PresetImages { get; private set; }

        private IWebHostEnvironment _environment;
        public string GetProfilePictureUrlById(int id)
        {
            return userController.GetProfilePictureUrlById(id);
        }
        public void OnGet()
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;

            LoggedUser = userController.GetUserFromUsername(username);
            PresetImages = userController.GetAllProfilePictures();

            if (PresetImages == null || !PresetImages.Any())
            {
                PresetImages = new List<ProfileImage>();
            }

            string profilePicUrl = userController.GetProfilePictureUrlById(LoggedUser.ProfilePicture);
            ViewData["ProfilePicUrl"] = profilePicUrl;
        }

        public IActionResult OnPost()
        {
            try
            {
                string username = HttpContext.User.Identity.Name;
                ViewData["Message"] = username;
                LoggedUser = userController.GetUserFromUsername(username);

                if (int.TryParse(Request.Form["SelectedProfileImage"], out int selectedImageId))
                {
                    LoggedUser.ProfilePicture = selectedImageId;
                }

                LoggedUser.Email = Email;
                LoggedUser.Bio = Bio;
                LoggedUser.UsernameColor = UsernameColor;

                userController.Update(LoggedUser);
                return RedirectToPage("/Profile");
            }
            catch (Exception ex)
            {
                ViewData["Error"] = "An error occurred while updating your profile: " + ex.Message;
                return Page();
            }
        }

        public IActionResult OnPostDelete()
        {
            try
            {
                string username = HttpContext.User.Identity.Name;
                ViewData["Message"] = username;
                LoggedUser = userController.GetUserFromUsername(username);

                userController.Delete(LoggedUser);
                HttpContext.SignOutAsync();

                return RedirectToPage("/Index");
            }
            catch (Exception ex)
            {
                ViewData["Error"] = "An error occurred while deleting your profile: " + ex.Message;
                return Page();
            }
        }
        public async Task<IActionResult> OnPostUpdateImageAsync(string image)
        {
            try
            {
                string username = HttpContext.User.Identity.Name;
                LoggedUser = userController.GetUserFromUsername(username);

                if (int.TryParse(image, out int profilePicId))
                {
                    LoggedUser.ProfilePicture = profilePicId;
                    bool updateResult = userController.Update(LoggedUser);

                    return new JsonResult(new { success = updateResult, message = updateResult ? "Profile picture updated successfully." : "Error updating profile picture." });
                }
                else
                {
                    return new JsonResult(new { success = false, message = "Error: Invalid image ID." });
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(new { success = false, message = $"Error: {ex.Message}" });
            }
        }
    }
}

