using MagicVilla_VillaAPI.Models;
using MagicVilla_Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers {  get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
            new Villa()
            {
                Id = 1,
                Name = "Royal Villa",
                Details = "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.",
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.myluxoria.com%2Fpl%2Fwille-pula%2Fvilla-vestibul&psig=AOvVaw3NHQ8dlOMqLJ8h69c1lHCe&ust=1740129122224000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDc66P00YsDFQAAAAAdAAAAABAE",
                Occupancy = 5,
                Rate = 200,
                Sqft = 550,
                Amenity = "",
                CreateDate = new DateTime(2025, 2, 20, 10, 25, 44, 101, DateTimeKind.Local).AddTicks(3216)
        },
            new Villa()
            {
                Id = 2,
                Name = "Diamond Pool Villa",
                Details = "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.",
                ImageUrl = "https://unique-residence.com/wp-content/uploads/2020/05/WILLA-E%CC%81LE%CC%81GANT_mirror-1.jpg",
                Occupancy = 6,
                Rate = 350,
                Sqft = 700,
                Amenity = "",
                CreateDate = new DateTime(2025, 2, 20, 10, 25, 44, 105, DateTimeKind.Local).AddTicks(6489)
            },
            new Villa()
            {
                Id = 3,
                Name = "Diamond Villa",
                Details = "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.",
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.behance.net%2Fgallery%2F93248823%2FElegant-Modern-Villa%3Flocale%3Dpl_PL&psig=AOvVaw3NHQ8dlOMqLJ8h69c1lHCe&ust=1740129122224000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDc66P00YsDFQAAAAAdAAAAABAd",
                Occupancy = 4,
                Rate = 250,
                Sqft = 800,
                Amenity = "",
                CreateDate = new DateTime(2025, 2, 20, 10, 25, 44, 105, DateTimeKind.Local).AddTicks(6524)
            },
            new Villa()
            {
                Id = 4,
                Name = "Premium Poll Villa",
                Details = "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.",
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Feastwest.com%2Finsights%2Fvacation-rentals%2Fwhat-is-the-difference-between-a-hotel-room-and-a-villa%2F&psig=AOvVaw3NHQ8dlOMqLJ8h69c1lHCe&ust=1740129122224000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDc66P00YsDFQAAAAAdAAAAABAn",
                Occupancy = 7,
                Rate = 400,
                Sqft = 900,
                Amenity = "",
                CreateDate = new DateTime(2025, 2, 20, 10, 25, 44, 105, DateTimeKind.Local).AddTicks(6529)
            },
            new Villa()
            {
                Id = 5,
                Name = "Luxury Pool Villa",
                Details = "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.",
                ImageUrl = "https://www.adriaticluxuryvillas.com/uploads/images/villa-di-polisane-zadar-dalmatia-1716977474706.jpg",
                Occupancy = 5,
                Rate = 300,
                Sqft = 1100,
                Amenity = "",
                CreateDate = new DateTime(2025, 2, 20, 10, 25, 44, 105, DateTimeKind.Local).AddTicks(6532)
            });
        }
    }
}
