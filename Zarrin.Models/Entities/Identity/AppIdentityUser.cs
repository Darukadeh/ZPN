using Microsoft.AspNetCore.Identity;

namespace Zarrin.Models.Entities.Identity
{
    public class AppIdentityUser : IdentityUser
    {
        public int Age { get; set; }
    }
}
