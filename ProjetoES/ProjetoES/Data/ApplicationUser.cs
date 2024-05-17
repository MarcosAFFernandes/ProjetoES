using Microsoft.AspNetCore.Identity;
using ProjetoES.Models;

namespace ProjetoES.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public Collections Favourites { get; set; }
    }

}
