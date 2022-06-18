using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibraryEF.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "ShopingCarModel");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "ShopingCarModel",
                newName: "FoodCount");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "ShopingCarModel",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ShopingCarModel");

            migrationBuilder.RenameColumn(
                name: "FoodCount",
                table: "ShopingCarModel",
                newName: "FoodId");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "ShopingCarModel",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
