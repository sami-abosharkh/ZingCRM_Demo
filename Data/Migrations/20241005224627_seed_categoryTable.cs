using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZingCRM_Demo.Migrations
{
    /// <inheritdoc />
    public partial class seed_categoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Everything that has to do with 2D and 3D designs.", "Designs" },
                    { 2, "All Electronic and Appliances which include batteries and tablets.", "Electronics & Appliances" },
                    { 3, "All items designated for gifting in an activity that is gifting related, which includes notebooks and vouchers.", "Gifting" },
                    { 4, "All promoters and supervisors.", "Manpower" },
                    { 5, "All items that are required for an office launch, this includes the gifts and danglers and other production elements that were created for the office launch.", "Office Launches" },
                    { 6, "Anything that needed to be attested for a specific project.", "Official Documents" },
                    { 7, "All recruited photographers and videographers.", "Photography & Videography" },
                    { 8, "All production elements within a project not including a giveaway and office launch project.", "POSM Productions" },
                    { 9, "Anything Logistics including Installation and Dismantling of any soft or hard POSM.", "Logistics" },
                    { 10, "Anything required to run a promotion activity which includes tables and uniforms.", "Promoting Material" },
                    { 11, "All location rental costs.", "Rental" },
                    { 12, "All international shipments.", "Shipping International" },
                    { 13, "All local shipments including store deployment.", "Shipping Local" },
                    { 14, "All costs related to renting a temporary warehouse.", "Storage & Warehousing" },
                    { 15, "All travels and lodging for specific projects.", "Travel Expenses" },
                    { 16, "All VR and App Programming related costs.", "Programming" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.RenameColumn(
                name: "TimeCreated",
                table: "AspNetUsers",
                newName: "Date");
        }
    }
}
