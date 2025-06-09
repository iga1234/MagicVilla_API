using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUrlImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://placehold.co/600x401");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://placehold.co/600x402");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://placehold.co/600x403");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://https://placehold.co/600x404");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://https://placehold.co/600x405");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.myluxoria.com%2Fpl%2Fwille-pula%2Fvilla-vestibul&psig=AOvVaw3NHQ8dlOMqLJ8h69c1lHCe&ust=1740129122224000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDc66P00YsDFQAAAAAdAAAAABAE");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://unique-residence.com/wp-content/uploads/2020/05/WILLA-E%CC%81LE%CC%81GANT_mirror-1.jpg");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.behance.net%2Fgallery%2F93248823%2FElegant-Modern-Villa%3Flocale%3Dpl_PL&psig=AOvVaw3NHQ8dlOMqLJ8h69c1lHCe&ust=1740129122224000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDc66P00YsDFQAAAAAdAAAAABAd");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Feastwest.com%2Finsights%2Fvacation-rentals%2Fwhat-is-the-difference-between-a-hotel-room-and-a-villa%2F&psig=AOvVaw3NHQ8dlOMqLJ8h69c1lHCe&ust=1740129122224000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKDc66P00YsDFQAAAAAdAAAAABAn");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.adriaticluxuryvillas.com/uploads/images/villa-di-polisane-zadar-dalmatia-1716977474706.jpg");
        }
    }
}
