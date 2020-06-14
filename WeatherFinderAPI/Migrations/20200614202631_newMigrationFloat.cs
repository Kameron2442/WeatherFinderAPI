using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherFinderAPI.Migrations
{
    public partial class newMigrationFloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Lon",
                table: "LocationItems",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Lat",
                table: "LocationItems",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Lon",
                table: "LocationItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "Lat",
                table: "LocationItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
