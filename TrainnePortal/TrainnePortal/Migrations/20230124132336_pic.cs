using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainnePortal.Migrations
{
    /// <inheritdoc />
    public partial class pic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pic",
                table: "TrainneDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pic",
                table: "TrainneDetails");
        }
    }
}
