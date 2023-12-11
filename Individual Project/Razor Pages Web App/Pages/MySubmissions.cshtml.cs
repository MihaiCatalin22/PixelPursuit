using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Class_Library.Classes;
using Class_Library.Controllers;
using Class_Library.DAL;

namespace Razor_Pages_Web_App.Pages
{
    public class MySubmissionsModel : PageModel
    {
        private SubmissionController submissionController { get; set; } = new(new SubmissionDAL());
        [BindProperty]
        public SubmissionController subCont { get; set; }
        [BindProperty]
        public Submission[] submissions { get; set; }
        [BindProperty]
        public RankedSubmission[] rankedSubmissions { get; set; }
        [BindProperty]
        public User LoggedUser { get; set; }
        private UserController userController = new(new UserDAL());
        [BindProperty]
        public int Type { get; set; }
        public IActionResult OnGet(int type)
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;

            LoggedUser = userController.GetUserFromUsername(username);

            Type = type;

            subCont = submissionController;

            submissions = submissionController.ReadRecent(LoggedUser.Id);

            List<RankedSubmission> ranked = new();
            foreach (var submission in submissions)
            {
                if (submissionController.ReadRanked(submission.Id) != null)
                {
                    ranked.Add(submissionController.ReadRanked(submission.Id));
                }
            }
            rankedSubmissions = ranked.ToArray();
            return Page();
        }

        public IActionResult OnPost(int type)
        {
            string username = HttpContext.User.Identity.Name;
            ViewData["Message"] = username;

            LoggedUser = userController.GetUserFromUsername(username);

            Type = type;

            subCont = submissionController;

            if (Type == 1)
            {
                submissions = submissionController.ReadRankedByUser(LoggedUser.Id);
                rankedSubmissions = submissionController.ReadRankedByUser(LoggedUser.Id);
            }
            else if (Type == 2)
            {
                submissions = submissionController.ReadByUser(LoggedUser.Id);
            }
            else
            {
                submissions = submissionController.ReadRecent(LoggedUser.Id);
            }
            return Page();
        }
        public IActionResult OnPostClear()
        {
            return RedirectToPage("/MySubmissions");
        }
    }
}

