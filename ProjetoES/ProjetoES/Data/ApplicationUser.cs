using Microsoft.AspNetCore.Identity;
using ProjetoES.Models;

namespace ProjetoES.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual Collections Favourites { get; set; } = new Collections("Favorites");
    }

}
