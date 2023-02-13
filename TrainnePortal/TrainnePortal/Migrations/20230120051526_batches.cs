using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainnePortal.Migrations
{
    /// <inheritdoc />
    public partial class batches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Course1",
                table: "BatchDetails");

            migrationBuilder.DropColumn(
                name: "Course2",
                table: "BatchDetails");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BatchDetails",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "Course4",
                table: "BatchDetails",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Course3",
                table: "BatchDetails",
                newName: "course");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "BatchDetails",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "BatchDetails",
                newName: "Course4");

            migrationBuilder.RenameColumn(
                name: "course",
                table: "BatchDetails",
                newName: "Course3");

            migrationBuilder.AddColumn<string>(
                name: "Course1",
                table: "BatchDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Course2",
                table: "BatchDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
