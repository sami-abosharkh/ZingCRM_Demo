using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZingCRM_Demo.Migrations
{
    /// <inheritdoc />
    public partial class seed_itemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 4, "Male Promoter" },
                    { 2, 4, "Female Promoter" },
                    { 3, 4, "Male Supervisor" },
                    { 4, 4, "Female Supervisor" },
                    { 5, 4, "Male Usher" },
                    { 6, 4, "Female Usher" },
                    { 7, 4, "Laborer" },
                    { 8, 1, "HARD POSM: Gondola" },
                    { 9, 1, "HARD POSM: Gondola End Stand" },
                    { 10, 1, "HARD POSM: 60x40 FSU" },
                    { 11, 1, "HARD POSM: 50x50 FSU" },
                    { 12, 1, "HARD POSM: 1x1" },
                    { 13, 1, "HARD POSM: 2x1" },
                    { 14, 1, "HARD POSM: 2x2" },
                    { 15, 1, "HARD POSM: 3x2" },
                    { 16, 1, "HARD POSM: 3x3" },
                    { 17, 1, "HARD POSM: 4x2" },
                    { 18, 1, "HARD POSM: 4x4" },
                    { 19, 1, "HARD POSM: 5x2" },
                    { 20, 1, "HARD POSM: 5x3" },
                    { 21, 1, "HARD POSM: 5x5" },
                    { 22, 1, "Exhibition Booth 3x3" },
                    { 23, 1, "Exhibition Booth 5x3" },
                    { 24, 1, "Exhibition Booth 5x5" },
                    { 25, 1, "Exhibition Booth 7x5" },
                    { 26, 1, "D-Com Banner" },
                    { 27, 1, "Social Media Post" },
                    { 28, 1, "SOFT POSM: Danglers" },
                    { 29, 1, "SOFT POSM: Wobblers" },
                    { 30, 1, "SOFT POSM: Dividers" },
                    { 31, 1, "SOFT POSM: Shelf Strips" },
                    { 32, 1, "SOFT POSM: Base Wrap" },
                    { 33, 1, "SOFT POSM: Floor Sticker" },
                    { 34, 1, "SOFT POSM: Tent Card" },
                    { 35, 2, "Phone" },
                    { 36, 2, "Tablet" },
                    { 37, 2, "Screen" },
                    { 38, 3, "Voucher" },
                    { 39, 3, "Pen" },
                    { 40, 3, "Notebook" },
                    { 41, 3, "Box" },
                    { 42, 7, "Videography" },
                    { 43, 7, "Photography" },
                    { 44, 7, "Photography & Videography" },
                    { 45, 7, "Drone Videography" },
                    { 46, 7, "Drone Photography" },
                    { 47, 8, "HARD POSM: Gondola" },
                    { 48, 8, "HARD POSM: Gondola End Stand" },
                    { 49, 8, "HARD POSM: 60x40 FSU" },
                    { 50, 8, "HARD POSM: 50x50 FSU" },
                    { 51, 8, "HARD POSM: 1x1" },
                    { 52, 8, "HARD POSM: 2x1" },
                    { 53, 8, "HARD POSM: 2x2" },
                    { 54, 8, "HARD POSM: 3x2" },
                    { 55, 8, "HARD POSM: 3x3" },
                    { 56, 8, "HARD POSM: 4x2" },
                    { 57, 8, "HARD POSM: 4x4" },
                    { 58, 8, "HARD POSM: 5x2" },
                    { 59, 8, "HARD POSM: 5x3" },
                    { 60, 8, "HARD POSM: 5x5" },
                    { 61, 8, "Exhibition Booth 3x3" },
                    { 62, 8, "Exhibition Booth 5x3" },
                    { 63, 8, "Exhibition Booth 5x5" },
                    { 64, 8, "Exhibition Booth 7x5" },
                    { 65, 8, "SOFT POSM: Danglers" },
                    { 66, 8, "SOFT POSM: Wobblers" },
                    { 67, 8, "SOFT POSM: Dividers" },
                    { 68, 8, "SOFT POSM: Shelf Strips" },
                    { 69, 8, "SOFT POSM: Base Wrap" },
                    { 70, 8, "SOFT POSM: Floor Sticker" },
                    { 71, 8, "SOFT POSM: Tent Card" },
                    { 72, 9, "Stand Deployment and Installation" },
                    { 73, 9, "Booth Deployment and Installation" },
                    { 74, 10, "Uniforms" },
                    { 75, 10, "Promoter Tables" },
                    { 76, 10, "Decorations" },
                    { 77, 10, "Branded Cups" },
                    { 78, 10, "Unbranded Cups" },
                    { 79, 10, "Spoons" },
                    { 80, 10, "Forks" },
                    { 81, 10, "Kraft Plates" },
                    { 82, 10, "Hair Nets" },
                    { 83, 10, "Masks" },
                    { 84, 10, "Gloves" },
                    { 85, 11, "Mall Rental" },
                    { 86, 11, "Supermarket Rentals" },
                    { 87, 11, "Event Rentals" },
                    { 88, 12, "KSA - UAE" },
                    { 89, 12, "UAE - KSA" },
                    { 90, 13, "Jeddah - Riyadh" },
                    { 91, 13, "Jeddah - Dammam" },
                    { 92, 13, "Riyadh - Jeddah" },
                    { 93, 13, "Riyadh - Dammam" },
                    { 94, 13, "Dammam - Riyadh" },
                    { 95, 13, "Dammam - Jeddah" },
                    { 96, 13, "Jeddah - Remote Cities" },
                    { 97, 16, "Microsite" },
                    { 98, 16, "Apps" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98);
        }
    }
}
