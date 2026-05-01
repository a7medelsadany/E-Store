using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.IdentityModule
{
    public class ApplicationUser:IdentityUser
    {
        public string DisplayName { get; set; }=string.Empty;
    }
}
