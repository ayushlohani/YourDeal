using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YourDeal.Migrations
{
    /// <inheritdoc />
    public partial class Added_Properites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FarmHouses",
                table: "FarmHouses");

            migrationBuilder.RenameTable(
                name: "FarmHouses",
                newName: "PropertiesTb");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertiesTb",
                table: "PropertiesTb",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertiesTb",
                table: "PropertiesTb");

            migrationBuilder.RenameTable(
                name: "PropertiesTb",
                newName: "FarmHouses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FarmHouses",
                table: "FarmHouses",
                column: "Id");
        }
    }
}
