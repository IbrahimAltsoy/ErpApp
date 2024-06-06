using Microsoft.AspNetCore.Identity;

namespace ErpApp.Domain.Entities
{
    public class User:IdentityUser<string>
    {        
        public string NameSurname { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
        
    }
}
