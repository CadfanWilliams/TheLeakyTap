using Microsoft.AspNetCore.Identity;

namespace TheLeakyTap.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    public string firstName { get; set; } = string.Empty;
    public string lastName { get; set; } = string.Empty;
    public int telNum { get; set; }
}

