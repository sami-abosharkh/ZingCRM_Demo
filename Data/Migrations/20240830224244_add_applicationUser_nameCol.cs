using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZingCRM_Demo.Migrations
{
/// <inheritdoc />
public partial class add_applicationUser_nameCol : Migration
{
/// <inheritdoc />
protected override void Up(MigrationBuilder migrationBuilder)
{
migrationBuilder.AddColumn<string>(
name: "Name",
table: "AspNetUsers",
type: "nvarchar(max)",
nullable: true);
}

/// <inheritdoc />
protected override void Down(MigrationBuilder migrationBuilder)
{
migrationBuilder.DropColumn(
name: "Name",
table: "AspNetUsers");
}
}
}
