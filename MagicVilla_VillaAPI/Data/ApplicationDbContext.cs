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
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
            new Villa()
            {
                Id = 1,
                Name = "Royal Villa",
                Details = "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.",
                ImageUrl = "https://placehold.co/600x401",
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
                ImageUrl = "https://placehold.co/600x402",
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
                ImageUrl = "https://placehold.co/600x403",
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
                ImageUrl = "https://placehold.co/600x404",
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
                ImageUrl = "https://placehold.co/600x405",
                Occupancy = 5,
                Rate = 300,
                Sqft = 1100,
                Amenity = "",
                CreateDate = new DateTime(2025, 2, 20, 10, 25, 44, 105, DateTimeKind.Local).AddTicks(6532)
            });
        }
    }
}
