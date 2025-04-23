using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreateDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.myluxoria.com%2Fpl%2Fwille-pula%2Fvilla-vestibul&psig=AOvVaw3NHQ8dlOMqLJ8h69c1lHCe&ust=1740129122224000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDc66P00YsDFQAAAAAdAAAAABAE", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.", "https://unique-residence.com/wp-content/uploads/2020/05/WILLA-E%CC%81LE%CC%81GANT_mirror-1.jpg", "Diamond Pool Villa", 6, 350.0, 700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.behance.net%2Fgallery%2F93248823%2FElegant-Modern-Villa%3Flocale%3Dpl_PL&psig=AOvVaw3NHQ8dlOMqLJ8h69c1lHCe&ust=1740129122224000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDc66P00YsDFQAAAAAdAAAAABAd", "Diamond Villa", 4, 250.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Feastwest.com%2Finsights%2Fvacation-rentals%2Fwhat-is-the-difference-between-a-hotel-room-and-a-villa%2F&psig=AOvVaw3NHQ8dlOMqLJ8h69c1lHCe&ust=1740129122224000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDc66P00YsDFQAAAAAdAAAAABAn", "Premium Poll Villa", 7, 400.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Situated in Poissy, a small commune outside of Paris, Villa Savoye is one of the most significant contributions to modern architecture in the 20th century. Completed in 1929, Le Corbusier's masterpiece is a modern take on a French country house that celebrates and reacts to the new machine age.", "https://www.adriaticluxuryvillas.com/uploads/images/villa-di-polisane-zadar-dalmatia-1716977474706.jpg", "Luxury Pool Villa", 5, 300.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
