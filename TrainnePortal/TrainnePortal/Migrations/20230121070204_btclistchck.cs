using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainnePortal.Migrations
{
    /// <inheritdoc />
    public partial class btclistchck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCheck",
                table: "BatchList",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCheck",
                table: "BatchList");
        }
    }
}
