using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string Name {  get; set; } 
    }
}
