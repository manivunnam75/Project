using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainnePortal.Migrations
{
    /// <inheritdoc />
    public partial class overview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OverView",
                columns: table => new
                {
                    Sno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverView", x => x.Sno);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OverView");
        }
    }
}
