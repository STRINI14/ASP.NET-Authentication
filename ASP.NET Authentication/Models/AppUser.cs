using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Authentication.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Address { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}
