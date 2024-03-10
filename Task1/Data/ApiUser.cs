using Microsoft.AspNetCore.Identity;

namespace Task1.Data
{
    public class ApiUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
