using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherFinderAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Lon",
                table: "LocationItems",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<string>(
                name: "LocName",
                table: "LocationItems",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Lat",
                table: "LocationItems",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "LocationItems",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Lon",
                table: "LocationItems",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "LocName",
                table: "LocationItems",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Lat",
                table: "LocationItems",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "LocationItems",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
