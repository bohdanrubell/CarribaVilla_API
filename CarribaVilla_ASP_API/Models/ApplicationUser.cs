using Microsoft.AspNetCore.Identity;

namespace CarribaVilla_ASP_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
