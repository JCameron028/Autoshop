using Microsoft.AspNetCore.Identity;

namespace Autoshop.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}
