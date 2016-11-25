using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AspNetCoreSpa.Server.Entities
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
    }
}
