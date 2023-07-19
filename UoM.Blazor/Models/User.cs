using Microsoft.AspNetCore.Identity;

namespace UoM.Blazor.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
