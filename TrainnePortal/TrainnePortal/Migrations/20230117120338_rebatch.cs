using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainnePortal.Migrations
{
    /// <inheritdoc />
    public partial class rebatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Jan2023",
                table: "Jan2023");

            migrationBuilder.RenameTable(
                name: "Jan2023",
                newName: "BatchDetails");

            migrationBuilder.AddColumn<int>(
                name: "batchId",
                table: "BatchDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BatchDetails",
                table: "BatchDetails",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BatchDetails",
                table: "BatchDetails");

            migrationBuilder.DropColumn(
                name: "batchId",
                table: "BatchDetails");

            migrationBuilder.RenameTable(
                name: "BatchDetails",
                newName: "Jan2023");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jan2023",
                table: "Jan2023",
                column: "Id");
        }
    }
}
