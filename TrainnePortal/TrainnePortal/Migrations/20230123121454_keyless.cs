using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainnePortal.Migrations
{
    /// <inheritdoc />
    public partial class keyless : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OverView",
                table: "OverView");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OverView",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OverView",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OverView",
                table: "OverView",
                column: "Name");
        }
    }
}
