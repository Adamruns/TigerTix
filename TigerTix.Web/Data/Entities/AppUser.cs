using Microsoft.AspNetCore.Identity;

namespace TigerTix.Web.Data.Entities
{
    public class AppUser : IdentityUser
    {
        // Example of additional property
        public string FullName { get; set; }

        // You can add more custom properties as needed
    }
}
