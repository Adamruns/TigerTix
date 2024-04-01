using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using TigerTix.Web.Data.Entities;
// ... other using statements if necessary

namespace TigerTix.Extensions
{
    public static class UserManagerExtensions
    {
        public static string GetFullName(this UserManager<AppUser> userManager, ClaimsPrincipal principal)
        {
            // Your extension method implementation
            // Assuming your AppUser has FirstName and LastName properties
            var user = userManager.GetUserAsync(principal).Result; // Note: .Result is used here for simplicity, it's better to use async/await
            return $"{user.FullName}";
        }
    }
}
