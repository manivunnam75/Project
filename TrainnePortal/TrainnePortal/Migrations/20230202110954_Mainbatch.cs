using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainnePortal.Migrations
{
    /// <inheritdoc />
    public partial class Mainbatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DOJ",
                table: "TrainneDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TrainneDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BatchId",
                table: "BatchList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOJ",
                table: "TrainneDetails");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TrainneDetails");

            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "BatchList");
        }
    }
}
