using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZingCRM_Demo.Migrations
{
    /// <inheritdoc />
    public partial class add_purchaseRequisitionsTable_requestedamountCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "RequestedAmount",
                table: "PurchaseRequisitions",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestedAmount",
                table: "PurchaseRequisitions");
        }
    }
}
