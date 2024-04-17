#nullable disable

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TigerTix.Web.Data.Entities;

namespace TigerTix.Web.Areas.Identity.Pages.Account.Manage
{
    public class NotificationSettingsModel : PageModel
    {
        /*
        private readonly UserManager<AppUser> _userManager;
        private readonly ILogger<NotificationSettingsModel> _logger;

        public NotificationSettingsModel(UserManager<AppUser> userManager, ILogger<NotificationSettingsModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            // Get the current user
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            // Load user's notification settings and pass them to the view
            var notificationSettings = user.NotificationSettings; // Assuming you have a property for notification settings in your AppUser model
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(bool emailNotifications, bool pushNotifications)
        {
            // Get the current user
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            // Update user's notification settings based on form submission
            user.NotificationSettings.EmailNotifications = emailNotifications;
            user.NotificationSettings.PushNotifications = pushNotifications;

            // Save changes to the database
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return Page();
            }

            _logger.LogInformation("User with ID '{UserId}' updated their notification settings.", user.Id);
            return RedirectToPage();
        }
        */
    }
}