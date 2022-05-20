using Microsoft.AspNetCore.Identity;

namespace BikesWebApplication
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}