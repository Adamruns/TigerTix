using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TigerTix.Web.Data.Entities
{
    
    [Keyless]
    public class NotificationSettings
    {
        public bool EmailNotifications { get; set; }
        public bool PushNotifications { get; set; }
        // Add more properties as needed
    }

    public class AppUser : IdentityUser
    {
        // Example of additional property
        public string? FullName { get; set; }

        /*

        // You can add more custom properties as needed
        public NotificationSettings NotificationSettings { get; set; }

        public AppUser()
        {
            // Initialize NotificationSettings property
            NotificationSettings = new NotificationSettings();
        }
        */
    }
}
